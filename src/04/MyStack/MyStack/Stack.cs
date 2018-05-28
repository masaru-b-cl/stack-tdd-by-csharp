namespace MyStack
{
    public class Stack
    {
        private int size;

        public bool IsEmpty => size == 0;

        public int Size => size;

        private int value;

        public int Top => value;

        public void Push(int value)
        {
            this.value = value;
            size++;
        }
    }
}