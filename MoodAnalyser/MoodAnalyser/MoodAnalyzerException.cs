using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyzerException : Exception
    {
        public ExceptionType type;
        //Enumeration
        public enum ExceptionType
        {
            NULL_EXCEPTION,
            EMPTY_EXCEPTION,
            NO_SUCH_CLASS,
            NO_SUCH_CONSTRUCTOR
        }
        //Exception Constructor.
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
