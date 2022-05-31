using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class MarkReport
    {
        private readonly List<Student> _students;

        public string StudyProgramName { get; } = null!;
        public string Speciality { get; } = null!;
        public string Department { get; } = null!;
        public uint Year { get; }
        public uint Semester { get; }
        public uint Course { get; }
        public string Group { get; } = null!;
        public uint MarkReportYear { get; } = (uint)DateTime.Now.Year;
        public Subject Subject { get; } = null!;
        public IReadOnlyList<Student> Students { get => _students.AsReadOnly(); }

        public MarkReport(IEnumerable<Student> students, string studyProgramName, string speciality, string department, uint year, uint semester, uint course, string group, uint markReportYear, Subject subject)
        {
            _students = students.ToList();           
            StudyProgramName = !string.IsNullOrWhiteSpace(studyProgramName) ? studyProgramName.Trim() : throw new ArgumentException("Study Program title is empty!");
            Speciality = !string.IsNullOrWhiteSpace(speciality) ? speciality.Trim() : throw new ArgumentException("Speciality title is empty!");
            Department = !string.IsNullOrWhiteSpace(department) ? department.Trim() : throw new ArgumentException("Department title is empty!");
            Year = year;
            Semester = semester;
            Course = course;
            Group = !string.IsNullOrWhiteSpace(group) ? group.Trim() : throw new ArgumentException("Group title is empty!");
            MarkReportYear = markReportYear;
            Subject = subject;
        }
    }
}
