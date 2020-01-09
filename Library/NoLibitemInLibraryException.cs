using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class NoLibitemInLibraryException : System.Exception
    {
        public NoLibitemInLibraryException(string message) : base(message)
        {
        }
    }
}
