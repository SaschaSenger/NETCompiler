using System;
using Xunit;

namespace TestCompilerFeatures
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            try
            {
                var comp = new NETCompilerPlayground.Compiler();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}