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
                Console.WriteLine("The stack is full");
                return;
            }
            StackArray[EmptyCell] = NewElement;
            EmptyCell++;
        }

        public char TryRemove()
        {
            if (EmptyCell == 1)
            {
                Console.WriteLine("The stack is empty");
                return (char) 0;
            }

            EmptyCell--;
            return StackArray[EmptyCell];
        }

        public void PrintStack ()
        {
            if (EmptyCell == 0)
            {
                Console.WriteLine("The stack is empty");
                return;
            }

            for (int i = (StackArray.Length-1); i>=0; i--)
            {
                if (i < EmptyCell) Console.WriteLine(StackArray[i]);
                else Console.WriteLine("--");
            }
            Console.WriteLine();
        }

        public bool StackIsFull()
        {
            return EmptyCell == StackArray.Length;
        }

        public bool StackIsEmpty()
        {
            return EmptyCell == 0;
        }

        public int CurrentNumElements()
        {
            return EmptyCell;
        }
    }

    class StackExample
    {
        static void Main()
        {
            StackDemo Stack1 = new StackDemo();
            StackDemo Stack2 = new StackDemo();

            Stack1.InitializeStack(10);

            for (int i = 0; i<5; i++)
            {
                Stack1.TryAdd((char) ('A' +i));
            }

            Console.WriteLine("Stack 1 is:");
            Stack1.PrintStack();

            Stack2.InitializeStack(Stack1.CurrentNumElements());

            while(!Stack1.StackIsEmpty())
            {
                Stack2.TryAdd(Stack1.TryRemove());
            }

            Console.WriteLine("Stack 2 is:");
            Stack2.PrintStack();
        }
    }
}
