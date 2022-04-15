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

        public string UniversityName { get; } = null!;
        public string InstituteName { get; } = null!;
        public string Speciality { get; } = null!;
        public string Department { get; } = null!;
        public uint Year { get; }
        public uint Semester { get; }
        public uint Course { get; }
        public string Group { get; } = null!;
        public uint MarkReportYear { get; } = (uint)DateTime.Now.Year;
        public Subject Subject { get; } = null!;
        public IReadOnlyList<Student> Students { get => _students.OrderBy(s => s.FullName).ToList().AsReadOnly(); }

        public MarkReport(List<Student> students, string universityName, string instituteName, string speciality, string department, uint year, uint semester, uint course, string group, uint markReportYear, Subject subject)
        {
            _students = students;
            UniversityName = universityName; // TODO: Add null or empty check.
            InstituteName = instituteName;
            Speciality = speciality;
            Department = department;
            Year = year;
            Semester = semester;
            Course = course;
            Group = group;
            MarkReportYear = markReportYear;
            Subject = subject;
        }
    }
}
