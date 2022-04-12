using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackConsoleApplication
{
    internal class MyStack1
    {
        static readonly int MAX1 = 1000; //size of the array
        int top1;                        //integer variable to store top position
        int[] array1 = new int[MAX1];    //integer array

        bool IsEmpty()
        {
            return (top1 < 0);
        }
        public MyStack1()
        {
            top1 = -1;
        }
        internal bool Push(int data) //method to perform push operation
        {
            if(top1 >= MAX1)
            {
                Console.WriteLine("Stack OverFlow");
                return false;
            }
            else
            {
                array1[top1++] = data;
                return true;
            }

        }
        internal int Pop()  //method to perform pop operation
        {
            if (top1 < 0)
            {
                Console.WriteLine("Stack UnderFlow");
                return 0;
            }
            else
            {
                int value = array1[top1--];
                return value;
            }
        }
        internal void Peek()  //method to check/get the top element
        {
            if(top1<0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("The top Most element of the stack is : {0}", array1[top1]);
            }
            
        }
        internal void PrintStack()  //method to print the stack using for loop
        {
            if (top1 < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top1; i >= 0; i--)  //we had used array, so that we r printing Stack through for loop. 
                {
                    Console.WriteLine(array1[i]);
                }
            }
        }
    }
    internal class MyStack
    {
        static void Main(String[] args)
        {
            MyStack1 stack1 = new MyStack1();
            try
            {
                stack1.Push(10);
                stack1.Push(20);
                stack1.Push(30);
                stack1.Push(40);
                stack1.PrintStack();
                stack1.Peek();
                Console.WriteLine("Item popped from Stack : {0}", stack1.Pop());
                stack1.PrintStack();
            }
            catch(IndexOutOfRangeException index)
            {
                Console.WriteLine("Handled IndexOutOfRangeException in the Main method");
            }
            
        }
    }
}
