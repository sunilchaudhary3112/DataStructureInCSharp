using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    class StackA
    {
        int[] array;
        int top;
        int capacity;
        
        public StackA(int capacity)
        {
            this.capacity = capacity;
            top = -1;
            array = new int[capacity];
            
        }
        public bool isFull()
        {
            return top == capacity - 1;
        }
        public bool isEmpty()
        {
            return top == -1;
        }
        public void push(int data)
        {
            if(isFull())
            {
                return;
            }
            array[++top] = data;
            
        }
        public void pop()
        {
            if(isEmpty())
            {
                return;
            }
            int item = array[top];
            top--;
        Console.WriteLine("data popped " + item);
        }
        public void display()
        {
            if(isEmpty())
            {
                return;
            }
            for (int i = 0 ; i <= top ; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
