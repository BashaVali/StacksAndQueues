using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Welcome To Stack Problem-------------");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("1.Push ");
                Console.WriteLine("2.Peek And Pop ");
                int num = Convert.ToInt32(Console.ReadLine());
                Stack stack = new Stack();
                switch (num)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 2:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.IsEmpty();
                        stack.Pop();
                        stack.Peek();
                        stack.Display();
                        break;

                    default:
                        Console.WriteLine("Enter a Valid Option!!!");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
