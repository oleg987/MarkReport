using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OfficeOpenXml;
using Core.Events;

namespace Core.Workers
{
    public class MarkReportWorker
    {
        private readonly IEnumerable<StudyProgram> _studyPrograms;
        private readonly string _reportDestinationPath;

        public event EventHandler<OnMessageEventArgs> OnMessage;

        public MarkReportWorker(IEnumerable<StudyProgram> studyPrograms, string destinationPath)
        {
            _studyPrograms = studyPrograms;
            _reportDestinationPath = destinationPath;
        }

        public async Task CreateMarkReportsAsync()
        {
            // Сформировать объекты MarkReport.
            var markReports = GetMarkReports();

            if (markReports.Count == 0)
            {
                OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Немає відомостей доступних для формування;"));
                return;
            }

            // Создать файлы Excel с ведомостями.

            using var template = new ExcelPackage("template.xlsx");

            foreach (var markReport in markReports)
            {
                await SaveMarkReport(template, markReport);
            }
        }

        // Create Mark Reports from Study Programs.
        private List<MarkReport> GetMarkReports()
        {
            var markReports = new List<MarkReport>();

            if (_studyPrograms is null || !_studyPrograms.Any())
            {                
                return markReports;
            }

            foreach (var studyProgram in _studyPrograms)
            {
                foreach (var group in studyProgram.Groups)
                {
                    foreach (var subject in studyProgram.Subjects)
                    {
                        try
                        {
                            var markReport = new MarkReport(
                            group.Students,
                            studyProgram.Title,
                            studyProgram.Speciality,
                            studyProgram.Department,
                            studyProgram.Year,
                            studyProgram.Semester,
                            studyProgram.Course,
                            group.Title,
                            (uint)DateTime.Now.Year,
                            subject);

                            markReports.Add(markReport);
                        }
                        catch (Exception e)
                        {
                            OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Помилка при формуванні відомості. {e.Message};"));
                        }
                    }
                }
            }

            return markReports;
        }

        private async Task SaveMarkReport(ExcelPackage template, MarkReport markReport)
        {
            var filePath = GetMarkReportPath(markReport);

            if (filePath is null)
            {
                return;
            }

            var file = new FileInfo(filePath);

            // If file already exists delete it.
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                    file = new FileInfo(filePath);
                }
                catch (Exception e)
                {
                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: {e.Message};"));
                    return;
                }
            }

            using var reportFile = new ExcelPackage(file);

            FillMarkReport(template, reportFile, markReport);

            await reportFile.SaveAsync();
        }

        private string? GetMarkReportPath(MarkReport markReport)
        {
            var groupName = markReport.Group.Split('-')[0];

            var dir = new DirectoryInfo($@"{_reportDestinationPath}/{groupName}");

            if (!dir.Exists)
            {
                try
                {
                    dir.Create();
                }
                catch (Exception e)
                {
                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: {e.Message};"));
                    return null;
                }
            }

            var courseSubDir = new DirectoryInfo($@"{_reportDestinationPath}/{groupName}/{markReport.Course} курс");

            if (!courseSubDir.Exists)
            {
                try
                {
                    courseSubDir.Create();
                }
                catch (Exception e)
                {
                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: {e.Message};"));
                    return null;
                }
            }

            var groupSubDir = new DirectoryInfo($@"{_reportDestinationPath}/{groupName}/{markReport.Course} курс/{markReport.Group}");

            if (!groupSubDir.Exists)
            {
                try
                {
                    groupSubDir.Create();
                }
                catch (Exception e)
                {
                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: {e.Message};"));
                    return null;
                }
            }

            var filePath = $@"{_reportDestinationPath}/{groupName}/{markReport.Course} курс/{markReport.Group}/{markReport.Group}_{markReport.Subject.Title}_{markReport.Subject.ControlType}.xlsx";

            return filePath;
        }

        private void FillMarkReport(ExcelPackage template, ExcelPackage reportFile, MarkReport markReport)
        {
            var worksheet = reportFile.Workbook.Worksheets.Add($"{markReport.Group}", template.Workbook.Worksheets[0]);

            worksheet.Cells["C4"].Value = markReport.Speciality;
            worksheet.Cells["C5"].Value = markReport.StudyProgramName;
            worksheet.Cells["C6"].Value = markReport.Year;
            worksheet.Cells["H5"].Value = markReport.Semester;
            worksheet.Cells["H6"].Value = markReport.Course;
            worksheet.Cells["H7"].Value = markReport.Group;
            worksheet.Cells["F10"].Value = $"{markReport.MarkReportYear} року";
            worksheet.Cells["C11"].Value = markReport.Subject.Title;
            worksheet.Cells["E12"].Value = markReport.Subject.ControlType;

            int studentsDataBeginRow = 18;

            foreach (var student in markReport.Students)
            {
                worksheet.Cells["B" + studentsDataBeginRow].Value = student.FullName;
                studentsDataBeginRow++;
            }
        }
    }
}
