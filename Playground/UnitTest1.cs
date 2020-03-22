using System;
using Xunit;

namespace Playground
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() => Assert.True(false);

        [Fact]
        public void Test2() => Assert.True(1 == 2);
    }
}