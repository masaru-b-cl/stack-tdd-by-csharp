namespace MyStack
{
    public class Stack
    {
        private int value;

        public Stack()
        {
        }

        public bool IsEmpty => true;

        public int Top => value;

        public int Size => 1;

        public void Push(int value)
        {
            this.value = value;
        }
    }
}
