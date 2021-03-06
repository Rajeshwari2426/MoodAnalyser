using MoodAnalyser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    public class AnalyzeMood
    {
        //variable
        public string message;       
        /// default contructor       
        public AnalyzeMood()
        {

        }
        //parameterized constructor
        public AnalyzeMood(string message)
        {
            this.message = message;
        }
        //Method to return the type of Mood
        public string Mood()
        {
            try
            {
                message = message.ToLower();
                if (message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_EXCEPTION, "Message cann't be null");
                }
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_EXCEPTION, "Message cann't be Empty");
                }
                if (message.Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}
