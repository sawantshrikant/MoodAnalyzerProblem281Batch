using MoodAnalyzerProblem281Batch;

namespace MoodAnalyzerMstest281Batch
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1: Given ? I am in sad Mood ? meassage Should Return SAD
        /// </summary>
        [TestMethod]
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string meassage = "I am in Sad Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(meassage);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        ///  TC 1.2 & 2.1: Given ?I am in HAPPY Mood? and null meassage Should Return HAPPY
        /// </summary>
        [TestMethod]
        [DataRow("I am in Happy Mood")]
        [DataRow(null)]
        public void GivenHappyMoodShouldReturnHappy(string meassage)
        {
            // Arrange
            String expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(meassage);

            // Act
            string mood = moodAnalyser.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }


        /// <summary>
        /// TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating Empty Mood.
        /// Given-When-Then
        /// </summary>
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                string meassage = "";
                MoodAnalyser moodAnalyse = new MoodAnalyser(meassage);
                string mood = moodAnalyse.AnalyseMood();

            }

            catch (MoodAnalyserCustomException e) 
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}