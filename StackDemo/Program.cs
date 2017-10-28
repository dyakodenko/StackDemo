using System;


namespace StackDemo
{
    class StackDemo
    {
        int EmptyCell = 0;
        char[] StackArray;

        public void InitializeStack(int StackSize)
        {
            StackArray = new char[StackSize];
        }

        public void TryAdd(char NewElement)
        {
            if (EmptyCell >= StackArray.Length)
            {
                Console.WriteLine("The stack is empty");
                return;
            }
        }
    }
}
