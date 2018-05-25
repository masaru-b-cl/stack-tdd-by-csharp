using System;

namespace MyStack
{
    public class Stack
    {
        public int Size { get; private set; }

        public bool IsEmpty => Size == 0;

        private int[] values = new int[10];

        public void Push(int value)
        {
            values[Size] = value;
            Size++;
        }

        public int Top
        {
            get
            {
                AssertNotEmpty();
                return values[Size - 1];
            }
        }

        public void Pop()
        {
            AssertNotEmpty();
            Size--;
        }

        private void AssertNotEmpty()
        {
            if (IsEmpty) throw new InvalidOperationException();
        }
    }
}