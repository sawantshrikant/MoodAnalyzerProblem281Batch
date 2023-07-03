using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem281Batch
{
    public class MoodAnalyserCustomException : Exception
    {
        /// <summary>
        /// Enum for Exception Type
        /// </summary>
        public enum ExceptionType
        {
            Null_MESSAGE, EMPTY_MEASSAGE,
            NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE

        }

        //// Creating 'type' variable of type ExceptionType
        private readonly ExceptionType type;

        ///<summary>
        /// Parameterized Constructor sets the Exception Type and meassage.
        ///</summary>
        /// <param name="Type"></param>
        /// <param name="meassage"></param>
        public MoodAnalyserCustomException(ExceptionType Type, string meassage) : base(meassage)
        {
            this.type = Type;
        }
        
        
    }
}
