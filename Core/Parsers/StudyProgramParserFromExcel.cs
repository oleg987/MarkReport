using Core.Domain;
using Core.Events;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Parsers
{
    public class StudyProgramParserFromExcel
    {
        private readonly string _pathToDataFile;

        public event EventHandler<OnMessageEventArgs> OnMessage;

        public StudyProgramParserFromExcel(string pathToDataFile)
        {
            _pathToDataFile = !string.IsNullOrWhiteSpace(pathToDataFile) ? pathToDataFile : throw new ArgumentException("Помилка: Не вказано шлях до файлу інформаційної бази.");
        }

        public IEnumerable<StudyProgram> Parse()
        {
            using var package = new ExcelPackage(_pathToDataFile);

            var workbook = package.Workbook;
            var studyProgramWorksheet = workbook.Worksheets["study_program"];
            var groupWorksheet = workbook.Worksheets["students"];

            var students = new List<Student>();

            int groupDataBeginRow = 2;

            while (groupWorksheet.Cells["A" + groupDataBeginRow].Value is not null && groupWorksheet.Cells["B" + groupDataBeginRow].Value is not null)
            {
                try
                {
                    students.Add(new Student(groupWorksheet.Cells["B" + groupDataBeginRow].Value.ToString(), groupWorksheet.Cells["A" + groupDataBeginRow].Value.ToString()));
                }
                catch (Exception e)
                {
                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: {e.Message}; Лист: \"students\"; Рядок №: {groupDataBeginRow};"));
                }
                
                groupDataBeginRow++;
            }            

            var uniqueGroupNames = students.Select(s => s.Group).Distinct();

            var groups = new List<Group>(uniqueGroupNames.Count());

            foreach (var group in uniqueGroupNames)
            {
                groups.Add(new Group(group, students.Where(s => s.Group == group)));
            }

            var studyPrograms = new List<StudyProgram>();

            int studyProgramDataBeginRow = 2;

            while (studyProgramWorksheet.Cells["A" + studyProgramDataBeginRow].Value is not null)
            {
                string studyProgramName = null;

                try
                {
                    studyProgramName = studyProgramWorksheet.Cells["A" + studyProgramDataBeginRow].Value.ToString();
                }
                catch (Exception)
                {

                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказана назва освітньої програми; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                    studyProgramDataBeginRow++;
                    continue;
                }

                string speciality = null;

                try
                {
                    speciality = studyProgramWorksheet.Cells["B" + studyProgramDataBeginRow].Value.ToString();
                }
                catch (Exception)
                {

                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказана назва спеціальності; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                    studyProgramDataBeginRow++;
                    continue;
                }

                string department = null;

                try
                {
                    department = studyProgramWorksheet.Cells["C" + studyProgramDataBeginRow].Value.ToString();
                }
                catch (Exception)
                {

                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказана назва кафедри; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                    studyProgramDataBeginRow++;
                    continue;
                }

                uint year = 0;

                try
                {
                    year = Convert.ToUInt32(studyProgramWorksheet.Cells["D" + studyProgramDataBeginRow].Value.ToString());
                }
                catch (Exception)
                {

                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказан рік освітньої програми; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                    studyProgramDataBeginRow++;
                    continue;
                }

                uint semester = 0;

                try
                {
                    semester = Convert.ToUInt32(studyProgramWorksheet.Cells["E" + studyProgramDataBeginRow].Value.ToString());
                }
                catch (Exception)
                {

                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказан семестр освітньої програми; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                    studyProgramDataBeginRow++;
                    continue;
                }

                uint course = 0;

                try
                {
                    course = Convert.ToUInt32(studyProgramWorksheet.Cells["F" + studyProgramDataBeginRow].Value.ToString());
                }
                catch (Exception)
                {

                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказан курс освітньої програми; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                    studyProgramDataBeginRow++;
                    continue;
                }

                string[] groupNames = null;

                try
                {
                    groupNames = studyProgramWorksheet.Cells["G" + studyProgramDataBeginRow].Value.ToString().Split(',');
                }
                catch (Exception)
                {

                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказані групи освітньої програми; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                    studyProgramDataBeginRow++;
                    continue;
                }

                for (int i = 0; i < groupNames.Length; i++)
                {
                    groupNames[i] = groupNames[i].Trim();
                }

                int currentSubjectColumn = 8;

                var subjects = new List<Subject>();

                while (studyProgramWorksheet.Cells[studyProgramDataBeginRow, currentSubjectColumn].Value is not null || studyProgramWorksheet.Cells[studyProgramDataBeginRow, currentSubjectColumn + 1].Value is not null)
                {
                    string subjectTitle = null;

                    try
                    {
                        subjectTitle = studyProgramWorksheet.Cells[studyProgramDataBeginRow, currentSubjectColumn].Value.ToString();
                    }
                    catch (Exception)
                    {

                        OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказана назва {currentSubjectColumn - 7}-го предмету; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                        currentSubjectColumn += 2;
                        continue;
                    }

                    string subjectControl = null;

                    try
                    {
                        subjectControl = studyProgramWorksheet.Cells[studyProgramDataBeginRow, currentSubjectColumn + 1].Value.ToString();
                    }
                    catch (Exception)
                    {

                        OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: Не вказана форма контролю {currentSubjectColumn - 7}-го предмету; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                        currentSubjectColumn += 2;
                        continue;
                    }

                    try
                    {
                        var subject = new Subject(subjectTitle, subjectControl);
                        subjects.Add(subject);
                    }
                    catch (Exception e)
                    {

                        OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: При створенні {currentSubjectColumn - 7}-го предмету - {e.Message}; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                        currentSubjectColumn += 2;
                        continue;
                    }                    

                    currentSubjectColumn += 2;
                }

                var studyProgramGroups = groups.Where(g => groupNames.Contains(g.Title));

                try
                {
                    var studyProgram = new StudyProgram(studyProgramGroups, subjects, studyProgramName, speciality, department, year, semester, course);
                    studyPrograms.Add(studyProgram);
                }
                catch (Exception e)
                {
                    OnMessage?.Invoke(this, new OnMessageEventArgs($"Помилка: При створенні освітньої програми - {e.Message}; Лист: \"study_program\"; Рядок №: {studyProgramDataBeginRow};"));
                }                

                studyProgramDataBeginRow++;
            }

            return studyPrograms;
        }
    }
}
