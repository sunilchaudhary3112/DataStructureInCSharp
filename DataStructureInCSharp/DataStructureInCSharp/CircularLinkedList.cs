using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    public class CLLNode
    {
        public int data;
        public CLLNode next;
        public CLLNode(int data)
        {
            this.data = data;
            next = null;
        }
    }
    public class CircularLinkedList
    {
        public CLLNode head;
        public int length = 0;
        public void insertBegin(int data)
        {
            CLLNode node = new CLLNode(data);
            node.next = head;
            if (head != null)//if list is not empty
            {
                CLLNode currentNode = head;
                while(currentNode.next != head)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = node;
                head = node;
                length++;
            }
            else//node is first node in circular list
            {
                node.next = node;
                head = node;
                length++;
            }
        }
        public void insertAtEnd(int data)
        {
            CLLNode node = new CLLNode(data);
            if(head!=null)
            {
                CLLNode currentNode = head;
                while (currentNode.next != head)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = node;
                node.next = head;
                length++;
            }
            else
            {
                head = node;
                node.next = node;
                length++;
            }
        }
        public void insertBefore(int data, int pos)
        {
            CLLNode node = new CLLNode(data);
            if(pos < 0)
            {
                pos = 0;
            }
            if(pos > length)
            {
                pos = length;
            }
            CLLNode currentNode = head;
            CLLNode prev = currentNode;
            for(int i = 1 ; i < pos ; i++)
            {
                prev = currentNode;
                currentNode = currentNode.next;
            }
            prev.next = node;
            node.next = currentNode;
            length++;
        }
        public void insertAfter(int data, int pos)
        {
            CLLNode node = new CLLNode(data);
            if (pos < 0)
                pos = 0;
            if (pos > length)
                pos = length;
            CLLNode currentNode = head;
            for(int i = 1 ; i < pos ; i++)
            {
                currentNode = currentNode.next;
            }
            node.next = currentNode.next;
            currentNode.next = node;
            length++;

        }
        public void removeFromBegin()
        {
            if (head == null)
                return;
            
            CLLNode currentNode = head;
            while (currentNode.next != head)
                currentNode = currentNode.next;

            head = head.next;
            currentNode.next = head;
            length--;
        }
        public void removeFromEnd()
        {
            if (head == null)
                return;
            CLLNode currentNode = head;
            CLLNode prev = currentNode;
            while(currentNode.next!=head)
            {
                prev = currentNode;
                currentNode = currentNode.next;
            }
            prev.next = head;
        }
        public void display()
        {
            if(head != null)
            {
                CLLNode currentNode = head;
                do
                {
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.next;
                } while (currentNode != head);
            }
        }

    }
}
