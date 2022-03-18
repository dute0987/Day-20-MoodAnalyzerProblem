using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MoodAnalyse
{
    [TestClass]
    public class AnalyzerTest
    {
        /// <summary>
        /// 2.1: Given “I am in HAPPY Mood” and null message Should Return HAPPY
        /// </summary>
        [TestMethod]
        [DataRow("I am in HAPPY Mood")]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHappy(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            // Act
            string mood = moodAnalyse.AnalyseMood();

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}