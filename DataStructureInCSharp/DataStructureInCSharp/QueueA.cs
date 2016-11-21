using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    public class QueueA
    {
        int front, rear, size;
        int capacity;
        int[] array;
        public QueueA(int capacity)
        {
            
            this.front = this.size = 0;
            this.capacity = capacity;
            this.rear = capacity - 1;
            this.array = new int[capacity];
        }
        public bool isFull()
        {
            return size == capacity;
        }
        public bool isEmpty()
        {
            return size == 0;
        }
        public void enqueue(int data)
        {
            if(isFull())
            {
                return;
            }
            rear = (rear + 1) % capacity;
            array[rear] = data;
            size++;
        }
        public int dequeue()
        {
            if (isEmpty())
                return int.MinValue;
            int item = array[front];
            front = (front + 1) % capacity;
            size--;
            return item;
        }
        public void display()
        {
            if(isEmpty())
            {
                return;
            }
            for (int i = front ; i<= rear ; i = (i+1)%capacity)
            {
                Console.WriteLine(array[i]);
            }
        }


    }
    
}
