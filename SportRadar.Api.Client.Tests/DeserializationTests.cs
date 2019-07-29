using AndriiKurdiumov.SportRadar.Client.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace SportRadar.Api.Client.Tests
{
    [TestClass]
    public class DeserializationTests
    {
        [TestMethod]
        public void DeserializeDailyResults()
        {
            // Arrange
            var content = File.ReadAllText("daily_results.json");

            // Act
            var dailyResults = JsonConvert.DeserializeObject<DailyResults>(content);

            // Assert
            dailyResults.Validate();
        }

        [TestMethod]
        public void DeserializeSchedule()
        {
            // Arrange
            var content = File.ReadAllText("schedule.json");

            // Act
            var dailyResults = JsonConvert.DeserializeObject<Schedule>(content);

            // Assert
            dailyResults.Validate();
        }

        [TestMethod]
        public void DeserializeLiveResultsNoData()
        {
            // Arrange
            var content = File.ReadAllText("live_results.json");

            // Act
            var dailyResults = JsonConvert.DeserializeObject<LiveResult>(content);

            // Assert
            dailyResults.Validate();
        }

        [TestMethod]
        public void DeserializeLiveResults()
        {
            // Arrange
            var content = File.ReadAllText("live_results_data.json");

            // Act
            var dailyResults = JsonConvert.DeserializeObject<LiveResult>(content);

            // Assert
            dailyResults.Validate();
        }
    }
}
