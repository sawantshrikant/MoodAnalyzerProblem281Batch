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
            if (this.meassage.Contains ("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
