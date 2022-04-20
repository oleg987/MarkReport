using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using OfficeOpenXml;

namespace Core.Workers
{
    public class MarkReportWorker
    {
        private readonly IEnumerable<StudyProgram> _studyPrograms;
        private readonly string _universityName = "ОДЕСЬКИЙ НАЦІОНАЛЬНИЙ ПОЛІТЕХНІЧНИЙ УНІВЕРСИТЕТ";
        private readonly string _instituteName = "ІНСТИТУТ КОМП'ЮТЕРНИХ СИСТЕМ";
        private readonly string _reportDestinationPath;

        public MarkReportWorker(IEnumerable<StudyProgram> studyPrograms, string destinationPath)
        {
            _studyPrograms = studyPrograms;
            _reportDestinationPath = destinationPath;
        }

        public void CreateMarkReports()
        {
            // TODO: Сформировать объекты MarkReport.
            var markReports = new List<MarkReport>();

            foreach (var studyProgram in _studyPrograms)
            {
                foreach (var group in studyProgram.Groups)
                {
                    foreach (var subject in studyProgram.Subjects)
                    {
                        var markReport = new MarkReport(
                            group.Students, 
                            _universityName, 
                            _instituteName, 
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
                }                
            }

            // TODO: Создать папки для групп.
            DirectoryInfo rootDirectory = new DirectoryInfo(_reportDestinationPath);

            if (!rootDirectory.Exists)
            {
                rootDirectory.Create();
            }

            // Get all unique group titles.

            var uniqueGroupTitles = _studyPrograms.SelectMany(sp => sp.Groups).Select(g => g.Title).Distinct();

            // Create directories for each group.

            var subDirectories = rootDirectory.GetDirectories();

            foreach (var groupTitle in uniqueGroupTitles)
            {
                if (!subDirectories.Any(sd => sd.Name == groupTitle))
                {
                    rootDirectory.CreateSubdirectory(groupTitle);
                }
            }

            // TODO: Создать файлы Excel с ведомостями.

            Assembly asm = Assembly.GetExecutingAssembly();

            using var templateStream = asm.GetManifestResourceStream("Core.template.xlsx");

            foreach (var markReport in markReports)
            {
                using var template = new ExcelPackage(templateStream);

                var path = $@"{_reportDestinationPath}/{markReport.Group}/{markReport.Subject.Title}_{markReport.Subject.ControlType}_{markReport.Year}.xlsx";

                using var reportFile = new ExcelPackage(path);

                var worksheet = reportFile.Workbook.Worksheets.Add($"{markReport.Group}", template.Workbook.Worksheets[0]);

                worksheet.Cells["A2"].Value = markReport.UniversityName;
                worksheet.Cells["A3"].Value = markReport.InstituteName;
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

                reportFile.Save();
            }
        }
    }
}
