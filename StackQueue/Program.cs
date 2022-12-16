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
                Console.WriteLine("3.Queue ");
                Console.WriteLine("Enter the option");
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

                    case 3:
                        string flag1 = "Y";
                        while (flag1 == "Y" || flag1 == "y")
                        {
                            Console.WriteLine("**1.Enqueue Operation**");
                            Console.WriteLine("**2.Dequeue Operation**");
                            Console.WriteLine("Enter the option");
                            int num1 = Convert.ToInt32(Console.ReadLine());
                            //Creating object for dequeue class
                            Queue queue = new Queue();
                            switch (num1)
                            {
                                case 1:
                                    queue.Enqueue(56);
                                    queue.Enqueue(30);
                                    queue.Enqueue(70);
                                    queue.Display();
                                    break;
                                case 2:
                                    queue.Enqueue(56);
                                    queue.Enqueue(30);
                                    queue.Enqueue(70);
                                    queue.Dequeue();
                                    queue.Display();
                                    break;
                                default:
                                    Console.WriteLine("Enter a valid option");
                                    break;
                            }
                            Console.WriteLine("\nDo you want to continue?(Y/N)");
                            flag1 = Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a Valid Option!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();
            }

        }
    }
}
