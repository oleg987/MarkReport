using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Events
{
    public class OnMessageEventArgs : EventArgs
    {
        public string Message { get; }

        public OnMessageEventArgs(string message)
        {
            Message = message;
        }
    }
}
