using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Change1()
        {
            var x = new change.Program();
            var y = x.exchange(1967);
            Assert.Equal(new int[] { 1, 1, 4, 1, 0, 1, 1, 1, 0 }, y);
        }

        [Theory]
        [InlineData(1967, new int[] { 1, 1, 4, 1, 0, 1, 1, 1, 0 })]
        [InlineData(3748, new int[] {3, 1, 2, 0, 2, 0, 1, 1, 1})]
        public void TestAddMethod(int a, int[] expected)
        {
            var cal = new change.Program();
            var r = cal.exchange(a);

            Assert.Equal(expected, r);
        }

        // [Theory]
        // [InlineData(1, 2, 3)]
        // [InlineData(3, 2, 5)]
        // [InlineData(3, 4, 7)]
        // public void TestAddMethod(int a, int b, int expected)
        // {
        //     var cal = new Calculator();
        //     var r = cal.Add(a, b);

        //     Assert.Equal(expected, r);
        // }
        // [Fact]
        // public void TestAddZero()
        // {
        //     var cal = new Calculator();
        //     var r = cal.Add(0, 0);

        //     Assert.Equal(-1, r);
        // }
    }
}
