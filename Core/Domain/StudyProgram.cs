using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class StudyProgram
    {
        private readonly List<Group> _groups;
        private readonly List<Subject> _subjects;

        public string Title { get; } = null!;
        public string Speciality { get; } = null!;
        public string Department { get; } = null!;
        public uint Year { get; }
        public uint Semester { get; }
        public uint Course { get; }
        public IReadOnlyList<Group> Groups { get => _groups.AsReadOnly(); }
        public IReadOnlyList<Subject> Subjects { get => _subjects.AsReadOnly(); }

        public StudyProgram(IEnumerable<Group> groups, IEnumerable<Subject> subjects, string title, string speciality, string department, uint year, uint semester, uint course)
        {
            _groups = groups.ToList();
            _subjects = subjects.ToList();
            Title = title;
            Speciality = speciality;
            Department = department;
            Year = year;
            Semester = semester;
            Course = course;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
