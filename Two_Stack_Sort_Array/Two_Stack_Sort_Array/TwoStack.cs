using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Stack_Sort_Array
{
    class TwoStack
    {
        public int[] s;
        public int top1, top2;
        public int max;
        public TwoStack(int size)
        {
            s = new int[size];
            top1 = -1;
            top2 = 0;
            max = size;
        }
        public void print()
        {
            if (top2 == 0&&top1==-1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top1; i++)
                {
                    Console.Write(s[i] + " . ");
                }
            }
        }
        public void push(int data)
        {
            if (top1 == top2)
            {
                Console.WriteLine("Stack Is Full !");
                return;
            }
            else
            {
                s[++top1] = data;
                top2++;
            }
        }
        public void push2(int data)
        {
            if (top2 == max - 1)
            {
                Console.WriteLine("Stack Is Full !");
                return;
            }
            else
            {
                s[++top2] = data;
            }
        }
        public int pop()
        {
            if (top2 == 0 && top1 == -1)
            {
                Console.WriteLine("Stack is Empty !");
                return -1;
            }
            else
            {
                Console.WriteLine($"{s[top1]} Is Deleted...");
                return s[top1--];
            }
        }
        public int pop2()
        {
            if (top2 == 0 && top1 == -1)
            {
                Console.WriteLine("Stack is Empty !");
                return -1;
            }
            else
            {
                Console.WriteLine($"{s[top2]} Is Deleted...");
                return s[top2--];
            }
        }
        public void bubbleSortStack(int[] arr, int n)
        {
            Stack<int> s1 = new Stack<int>();

            foreach (int num in arr)
                s1.Push(num);

            Stack<int> s2 = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    while (s1.Count != 0)
                    {
                        int t = s1.Pop();

                        if (s2.Count == 0)
                            s2.Push(t);
                        else
                        {
                            if (s2.Peek() > t)
                            {
                                int temp = s2.Pop();
                                s2.Push(t);
                                s2.Push(temp);
                            }
                            else
                            {
                                s2.Push(t);
                            }
                        }
                    }

                    arr[n - 1 - i] = s2.Pop();
                }
                else
                {
                    while (s2.Count != 0)
                    {
                        int t = s2.Pop();

                        if (s1.Count == 0)
                            s1.Push(t);

                        else
                        {
                            if (s1.Peek() > t)
                            {
                                int temp = s1.Pop();

                                s1.Push(t);
                                s1.Push(temp);
                            }
                            else
                                s1.Push(t);
                        }
                    }

                    arr[n - 1 - i] = s1.Pop();
                }
            }
        }

    }
}
