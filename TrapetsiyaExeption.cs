using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    class WordException : Exception
    {
        public WordException(string? message) : base(message)
        {
        }
    }
}
