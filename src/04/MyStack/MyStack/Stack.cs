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

        public int Top => value;

        public int Size => size;

        public void Push(int value)
        {
            this.value = value;
            size++;
        }
    }
}