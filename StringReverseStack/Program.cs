using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackChar = new Stack<char>();
            Console.WriteLine("Please enter a 5 letter word to push into the stack");
            for (int i = 0; i < 5; i++)
            {
                char n = char.Parse(Console.ReadLine());
                
                stackChar.Push(n);
               
            }
            Console.WriteLine("the stack reversed is: ");
            int count = stackChar.Count;
            for (int i = 0; i < count; i++)
            {
                char n = stackChar.Pop();
                Console.Write(n + " ");
            }


            Console.ReadLine();
        }
    }
}
