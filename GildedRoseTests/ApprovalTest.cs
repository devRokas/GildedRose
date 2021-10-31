using Xunit;
using System;
using System.IO;
using System.Text;
using ApprovalTests.Reporters;
using GildedRose;

namespace GildedRoseTests
{
    [UseReporter(typeof(DiffReporter))]
    public class ApprovalTest
    {
        [Fact]
        public void ThirtyDays()
        {
            var fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeOutput));
            Console.SetIn(new StringReader("a\n"));

            Program.Main();
            var output = fakeOutput.ToString();

            var result = File.ReadAllText("expectedResult.txt");
            
            Assert.Equal(result, output);
        }
    }
}
