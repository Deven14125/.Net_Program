using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class StackClass
    {
        public void GetStackValue()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            stack.Push(11);
            stack.Push(12);

            Console.WriteLine("After Push() Value Into Stack : ");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=========================================");

            
            Console.WriteLine("After Pop() Value From Stack : ");
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
       
            Console.WriteLine("=========================================");

            
            Console.WriteLine("After Peek() Value In Stack : ");
            
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Console.WriteLine("=========================================");

            
            Console.WriteLine("After Check Contains() Value In Stack Or Not: ");
            
            Console.WriteLine(stack.Contains(0));
            Console.WriteLine(stack.Contains(7));
            Console.WriteLine(stack.Contains(15));

            Console.WriteLine("=========================================");

            stack.Clear();
        }
    }
}
