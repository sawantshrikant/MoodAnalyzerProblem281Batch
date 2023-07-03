using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem281Batch
{
    public class MoodAnalyser
    {
        private string meassage;

        public MoodAnalyser(string meassage)
        {
            this.meassage = meassage;
        }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="meassage""></param>
        public string AnalyseMood()
        {
            //try
            //{
            //    if (this.meassage.Contains("Sad"))
            //    {
            //        return "SAD";
            //    }
            //    else
            //    {
            //        return "HAPPY";
            //    }
            //}
            //catch 
            //{
            //    return "HAPPY";
            //}


            try
            {
                if (this.meassage.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MEASSAGE, "Mood should not be Empty");
                }

                if (this.meassage.Contains("Sad"))
                {
                    return "SAD";
                }

                else
                {
                    return "HAPPY";
                }
            }

            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.Null_MESSAGE, "Mood should not be null");
            }
        }
    }
}
