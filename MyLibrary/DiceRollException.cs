using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    // Exception class
    internal class DiceRollException : Exception // The Symbol [I/O] on the left of the rows count tell the instances of Exceptions
    {

        //Few constructors you might want to build
        public DiceRollException() { }
        public DiceRollException(string message) : base
            (message) { }
        public DiceRollException(string message, Exception
            innerException) : base(message, innerException) { }



    }
}
