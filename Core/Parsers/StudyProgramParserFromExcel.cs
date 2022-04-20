using Core.Domain;
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

        public StudyProgramParserFromExcel(string pathToDataFile)
        {
            _pathToDataFile = pathToDataFile; // TODO: Add null or empty check.
        }

        public IEnumerable<StudyProgram> Parse()
        {
            using var package = new ExcelPackage(_pathToDataFile); // TODO: Add null or empty check.

            var workbook = package.Workbook;
            var studyProgramWorksheet = workbook.Worksheets["study_program"];
            var groupWorksheet = workbook.Worksheets["students"];

            var students = new List<Student>();

            int groupDataBeginRow = 2;

            while (groupWorksheet.Cells["A" + groupDataBeginRow].Value is not null && groupWorksheet.Cells["B" + groupDataBeginRow].Value is not null)
            {
                students.Add(new Student(groupWorksheet.Cells["B" + groupDataBeginRow].Value.ToString(), groupWorksheet.Cells["A" + groupDataBeginRow].Value.ToString()));
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
                string studyProgramName = studyProgramWorksheet.Cells["A" + studyProgramDataBeginRow].Value.ToString();
                string speciality = studyProgramWorksheet.Cells["B" + studyProgramDataBeginRow].Value.ToString();
                string department = studyProgramWorksheet.Cells["C" + studyProgramDataBeginRow].Value.ToString();
                uint year = Convert.ToUInt32(studyProgramWorksheet.Cells["D" + studyProgramDataBeginRow].Value.ToString());
                uint semester = Convert.ToUInt32(studyProgramWorksheet.Cells["E" + studyProgramDataBeginRow].Value.ToString());
                uint course = Convert.ToUInt32(studyProgramWorksheet.Cells["F" + studyProgramDataBeginRow].Value.ToString());
                string[] groupNames = studyProgramWorksheet.Cells["G" + studyProgramDataBeginRow].Value.ToString().Split(',');

                for (int i = 0; i < groupNames.Length; i++)
                {
                    groupNames[i] = groupNames[i].Trim();
                }

                int currentSubjectColumn = 8;

                var subjects = new List<Subject>();

                while (studyProgramWorksheet.Cells[studyProgramDataBeginRow, currentSubjectColumn].Value is not null)
                {
                    var subjectTitle = studyProgramWorksheet.Cells[studyProgramDataBeginRow, currentSubjectColumn].Value.ToString();
                    var subjectControl = studyProgramWorksheet.Cells[studyProgramDataBeginRow, currentSubjectColumn + 1].Value.ToString();
                    var subject = new Subject(subjectTitle, subjectControl);
                    subjects.Add(subject);

                    currentSubjectColumn += 2;
                }

                var studyProgramGroups = groups.Where(g => groupNames.Contains(g.Title));

                var studyProgram = new StudyProgram(studyProgramGroups, subjects, studyProgramName, speciality, department, year, semester, course);
                studyPrograms.Add(studyProgram);

                studyProgramDataBeginRow++;
            }

            return studyPrograms;
        }
    }
}
