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
            var content = File.ReadAllText("daily_results.json");

            var dailyResults = JsonConvert.DeserializeObject<DailyResults>(content);
        }
    }
}
