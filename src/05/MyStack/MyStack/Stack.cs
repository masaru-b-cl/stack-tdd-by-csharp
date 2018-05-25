using System;

namespace MyStack
{
    public class Stack
    {
        private int value;
        private int size;

        public Stack()
        {
        }

        public bool IsEmpty => size == 0;

        public int Top
        {
            get
            {
                AssertNotEmpty();
                return value;
            }
        }

        public int Size => size;

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