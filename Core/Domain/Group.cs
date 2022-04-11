using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Group
    {
        private readonly List<Student> _students;
        public string Title { get; } = null!;
        public IReadOnlyList<Student> Students { get => _students.AsReadOnly(); }

        public Group(string title, IEnumerable<Student> students)
        {
            Title = title; // TODO: Add null or empty check.
            _students = students.ToList();
        }
    }
}
