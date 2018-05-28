namespace MyStack
{
    public class Stack
    {
        public bool IsEmpty => true;

        public int Size => 1;

        private int value;

        public int Top => value;

        public void Push(int value)
        {
            this.value = value;
        }
    }
}
