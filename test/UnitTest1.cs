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
        [InlineData(3748, new int[] { 3, 1, 2, 0, 2, 0, 1, 1, 1 })]
        public void TestChangeMethod(int a, int[] expected)
        {
            var cal = new change.Program();
            var r = cal.exchange(a);

            Assert.Equal(expected, r);
        }

        [Theory]
        [InlineData(51, new int[] { 25, 26 })]
        [InlineData(50, new int[] { 11, 12, 13, 14 })]
        [InlineData(48, new int[] { 15, 16, 17 })]
        public void TestWhatMethod(int a, int[] expected)
        {
            var cal = new change.Program();
            var r = cal.what(a);

            Assert.Equal(expected, r);
        }
    }
}
