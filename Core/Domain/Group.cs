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
            Title = !string.IsNullOrWhiteSpace(title) ? title.Trim() : throw new ArgumentException("Group title is empty!");
            _students = students.ToList();
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
