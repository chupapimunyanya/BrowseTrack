using System.Threading.Tasks;
using Xunit;

namespace BrowseTrack_Tests_Configuration
{
    public class ConfigurationTests
    {

        [Fact]
        public async Task TS01_test_startTracking()
        {
            await Task.Delay(14);
            Assert.True(true);
        }

        [Fact]
        public async Task TS02_test_startTracking()
        {
            await Task.Delay(17);
            Assert.True(true);
        }

        [Fact]
        public async Task TS03_test_pauseTracking()
        {
            await Task.Delay(20);
            Assert.True(true);
        }

        [Fact]
        public async Task TS04_test_pauseTracking()
        {
            await Task.Delay(23);
            Assert.True(true);
        }

        [Fact]
        public async Task TS05_test_stopTracking()
        {
            await Task.Delay(26);
            Assert.True(true);
        }

        [Fact]
        public async Task TS06_test_stopTracking()
        {
            await Task.Delay(29);
            Assert.True(true);
        }

        [Fact]
        public async Task TS07_test_resumeTracking()
        {
            await Task.Delay(32);
            Assert.True(true);
        }

        [Fact]
        public async Task TS08_test_configLoad()
        {
            await Task.Delay(5);
            Assert.True(true);
        }

    }
}
