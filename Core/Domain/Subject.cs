using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Subject
    {
        public string Title { get; } = null!;
        public string ControlType { get; } = null!;

        public Subject(string title, string controlType)
        {
            Title = !string.IsNullOrWhiteSpace(title) ? title.Trim() : throw new ArgumentException("Subject title is empty!");
            ControlType = !string.IsNullOrWhiteSpace(controlType) ? controlType.Trim() : throw new ArgumentException("Control type is empty!");
        }
    }
}
