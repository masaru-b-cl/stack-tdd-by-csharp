using System;

namespace MyStack
{
    public class Stack
    {
        private int size;

        public bool IsEmpty => size == 0;

        public int Size => size;

        private int value;

        public int Top
        {
            get
            {
                AssertNotEmpty();
                return value;
            }
        }

        public void Push(int value)
        {
            this.value = value;
            size++;
        }

        public void Pop()
        {
            AssertNotEmpty();
        }

        private void AssertNotEmpty()
        {
            if (IsEmpty) throw new InvalidOperationException();
        }
    }
}