using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            String c;
            do
            {
                Console.WriteLine("ENQUEUE,DEQUEUE,PEEK,SHOW,QUIT [e/d/p/s/q]");
                c = Console.ReadLine();
                switch (c)
                {
                    case "e":
                        Console.WriteLine("Enter Integer:");
                        queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "d":
                        queue.Dequeue();
                        Console.WriteLine("Item is dequeued");
                        break;
                    case "p":
                        Console.WriteLine("PEEK:" + queue.Peek());
                        break;
                    case "s":
                        foreach (var item in queue)
                        {
                            Console.Write(item + " ");
                        }
                        break;
                    default:
                        break;
                }
            } while (c != "q");
            Console.Read();
        }
    }
}
