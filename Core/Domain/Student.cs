using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Student
    {
        public string FullName { get; } = null!;
        public string Group { get; } = null!;

        public Student(string fullName, string group)
        {
            FullName = !string.IsNullOrWhiteSpace(fullName) ? fullName.Trim() : throw new ArgumentException("ПІБ студента не заповнені");
            Group = !string.IsNullOrWhiteSpace(group) ? group.Trim() : throw new ArgumentException("Не заповнена група у студента");
        }
    }
}
