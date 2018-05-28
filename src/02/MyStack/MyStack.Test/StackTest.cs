using System;

using Xunit;

namespace MyStack.Test
{
    public class StackTest
    {
        [Fact]
        public void 作成直後は空()
        {
            var stack = new Stack();
            Assert.True(stack.IsEmpty);
        }
    }
}
