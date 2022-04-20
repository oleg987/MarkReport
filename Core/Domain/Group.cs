using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Core.Domain
{
    public class Group
    {
        private readonly List<Student> _students;
        public string Title { get; } = null!;
        public IReadOnlyList<Student> Students { get => _students.AsReadOnly(); }

        public Group(string title, IEnumerable<Student> students)
        {
            Title = title.Trim(); // TODO: Add null or empty check.
            _students = students.ToList();
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
