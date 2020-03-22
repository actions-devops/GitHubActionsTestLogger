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

        private void ThrowException() => throw new InvalidOperationException("test");

        [Fact]
        public void Test3() => ThrowException();

        [Fact]
        public void Test4() => Assert.Contains(new[] {1, 2, 3}, i => i == 4);

        [Fact(Skip = "Skipped for some reason")]
        public void Test5() => Assert.True(true);
    }
}