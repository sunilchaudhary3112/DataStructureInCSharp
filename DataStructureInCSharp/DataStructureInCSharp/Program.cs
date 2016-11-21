using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //**// start of stack code
            StackA stack = new StackA(10);
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.push(6);
            stack.push(7);
            stack.push(8);
            stack.display();
            Console.WriteLine("*************");
            stack.pop();
            stack.pop();
            stack.pop();
            stack.pop();
            stack.display();
            Console.ReadLine();
            //**//End of stack code
            //**//Start of Queue code Array implementation
            //QueueA queue = new QueueA(10); //Array implementation
            ////QueueL queue = new QueueL();A //LinkedList implementation
            //queue.enqueue(1);
            //queue.enqueue(2);
            //queue.enqueue(3);
            //queue.enqueue(4);
            //queue.enqueue(5);
            //queue.enqueue(6);
            //queue.dequeue();
            //queue.dequeue();
            //queue.dequeue();
            //queue.display();
            //Console.ReadLine();
            //**//End of Queue code Array implementation

            //**//Code for circular linked list
            //CircularLinkedList CLList = new CircularLinkedList();
            //CLList.insertBegin(50);
            //CLList.insertBegin(40);
            //CLList.insertBegin(30);
            //CLList.insertBegin(20);
            //CLList.insertBegin(10);
            ////CLList.display();
            ////Console.ReadLine();
            //CLList.insertAtEnd(60);
            //CLList.insertAtEnd(70);
            //CLList.insertAtEnd(80);
            //CLList.insertAtEnd(90);
            ////CLList.display();
            ////Console.ReadLine();
            //CLList.insertBefore(53, 6);
            //CLList.insertBefore(52, 6);
            //CLList.insertAfter(54, 7);
            //CLList.insertAfter(55, 8);
            //CLList.removeFromBegin();
            //CLList.removeFromEnd();
            //CLList.display();
            //Console.ReadLine();
            //**//End of Code for circular linked list
        }
    }
}
