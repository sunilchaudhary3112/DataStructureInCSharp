using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    class QueueL
    {
        CircularLinkedList CList;
        public QueueL()
        {
            CList = new CircularLinkedList();
        }
        public void enqueue(int data)
        {
            CList.insertAtEnd(data);
        }
        public void dequeue ()
        {
            CList.removeFromBegin();
        }
        public void display()
        {
            CList.display();
        }
    }
}
