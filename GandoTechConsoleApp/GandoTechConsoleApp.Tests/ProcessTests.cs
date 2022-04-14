using Xunit;

namespace GandoTechConsoleApp.Tests
{
    public class ProcessTests
    {
        [Fact]
        public void AppIsNotWorkingWithZeroSleepInterval()
        {
            var resut = MyProcess.DoProcess(0, 1);

            Assert.False(resut);
        }
        
        [Fact]
        public void AppIsNotWorkingWithNegativeSleepInterval()
        {
            var resut = MyProcess.DoProcess(-1000, 1);

            Assert.False(resut);
        }
    }
}
