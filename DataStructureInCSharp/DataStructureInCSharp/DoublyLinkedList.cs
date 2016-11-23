using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharep
{
    public class DLLNode
    {
        public int data;
        public DLLNode prev;
        public DLLNode next;
        public DLLNode(int data)
        {
            this.data = data;
            prev = null;
            next = null;
        }
        public DLLNode(int data, DLLNode prev, DLLNode next)
        {
            this.data = data;
            this.prev = prev;
            this.next = next;
        }
        public int getData()
        {
            return data;
        }
        public void setData(int data)
        {
            this.data = data;
        }
        public DLLNode getPrev()
        {
            return prev;
        }
        public DLLNode getNext()
        {
            return next;
        }
        public void setPrev(DLLNode prev)
        {
             this.prev = prev;
        }
        public void setNext(DLLNode next)
        {
            this.next = next;
        }
    }
    class DoublyLinkedList
    {
        public DLLNode head = null;
        public int length;
        public DoublyLinkedList()
        {
            //head = new DLLNode(int.MinValue, null, null);
            length = 0;
        }
        public void insertAtBegin(DLLNode newNode)
        {
            if(length == 0)
            {
                head = newNode;
                length++;
                return;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
                length++;
            }

        }
        public void insertAtEnd(DLLNode node)
        {
            DLLNode currentNode = head;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = node;
            node.prev = currentNode;
            length++;
        }
        public void insert(DLLNode node, int pos)
        {
            if(pos < 0)
            {
                pos = 0;
            }
            if(pos > length)
            {
                pos = length;
            }
            if(head == null)
            {
                head = node;
            }
            else if(pos == 0)
            {
                node.next = head;
                head.prev = node;
                head = node;
                length++;
            }
            else
            {
                DLLNode currentNode = head;
                for(int i = 0; i< pos; i++)
                {
                    currentNode = currentNode.next;
                }
                node.next = currentNode.next;
                node.prev = currentNode;
                (currentNode.next).prev = node;
                currentNode.next = node;
                length++; 
            }
        }
        public void removeFromBegin()
        {
            if(length == 0)//if empty list
            {
                return;
            }
            if(head != null && head.next == null)//if only one node in list
            {
                DLLNode nodeToRemove = head;
                head = null;
                length--;
                return;
            }
            else
            {
                DLLNode nodeToRemove = head;
                (head.next).prev = null;
                head = head.next;
                length--;
                return;

            }
            

        }
        public void removeFromEnd()
        {
            if (length == 0)//if empty list
            {
                return;
            }
            DLLNode currentNode = head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            (currentNode.prev).next = null;
        }
        public void display()
        {
            DLLNode currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }


    }
}
