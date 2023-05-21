using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Stack_Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoStack S = new TwoStack(100);

            S.push(13);
            S.push(93);
            S.push(65);
            S.push(28);
            S.push(71);
            S.push(92);
            S.push(11);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stack Is : ");
            S.print();
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            S.pop();
            S.pop();
            S.bubbleSortStack(S.s, S.top1 + 1);
            Console.WriteLine("\nAfter Sorting.....");
            Console.WriteLine("\n\nNow Stack Is : ");
            S.print();
            Console.ResetColor();
            Console.WriteLine("\n");


            Console.ReadKey();

        }
    }
}
