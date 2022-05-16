using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public class OnErrorEventArgs : EventArgs
    {
        public string Message { get; }

        public OnErrorEventArgs(string message)
        {
            Message = message;
        }
    }
}
