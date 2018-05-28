using System;

using Xunit;

namespace MyStack.Test
{
    public class StackTest
    {
        private Stack stack;

        public StackTest()
        {
            stack = new Stack();
        }

        [Fact]
        public void 作成直後は空()
        {
            Assert.True(stack.IsEmpty);
        }

        [Fact]
        public void Pushしたら空でない()
        {
            stack.Push(1);
            Assert.False(stack.IsEmpty);
        }

        [Fact]
        public void Pushした値をTopで取得できる()
        {
            stack.Push(1);
            Assert.Equal(1, stack.Top);
        }

        [Fact]
        public void 一つPushするとSizeが1増える()
        {
            stack.Push(1);
            Assert.Equal(1, stack.Size);
            stack.Push(2);
            Assert.Equal(2, stack.Size);
        }
    }
}
