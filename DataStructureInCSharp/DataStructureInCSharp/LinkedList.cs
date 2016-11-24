using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    public class ListNode
    {
        public int data;
        public ListNode next;
        public ListNode()
        {
            //data = 0;
            //next = null;
        }
        public ListNode(int data)
        {
            this.data = data;
        }
        public void setData(int data)
        {
            this.data = data;
        }
        public int getdata()
        {
            return data;
        }
        public void setNext(ListNode next)
        {
            this.next = next;
        }
        public ListNode getNext()
        {
            return this.next;
        }
    }
    public class LinkedListL
    {
        public ListNode head;
        private int length = 0;
        public LinkedListL()
        {
            length = 0;
        }
        public ListNode getHead()
        {
            return head;
        }
        public void insertAtBegin(ListNode node)
        {
            node.setNext(head);
            head = node;
            length++;
        }
        public void insertAtEnd(ListNode node)
        {
            if (head == null)
            {
                head = node;
            }
            else
            {
                ListNode currentNode = head;
                while (currentNode.getNext() != null)
                {
                    currentNode = currentNode.getNext();
                }
                currentNode.setNext(node);
                length++;


            }
        }
        public void insert(int data, int position)
        {
            //fix the length
            if (position < 0)
                position = 0;
            if (position > length)
                position = length;
            if (head == null)
            {
                head = new ListNode(data);
            }
            else if (position == 0)
            {
                ListNode newNode = new ListNode(data);
                newNode.next = head;
                head = newNode;
            }
            else
            {
                ListNode cuurentNode = head;
                for (int i = 1; i < position; i++)
                {
                    cuurentNode = cuurentNode.next;
                }
                ListNode newNode = new ListNode(data);
                newNode.next = cuurentNode.next;
                cuurentNode.setNext(newNode);
            }
            length++;
        }
        public ListNode removeFromBegin()
        {
            ListNode node = head;
            if (node != null)
            {
                head = node.getNext();
                node.setNext(null);
            }
            return node;
        }
        public ListNode reomveFromEnd()
        {
            ListNode prevNode, currentNode, temp;
            if (head == null)
            {
                return null;
            }
            currentNode = head;
            prevNode = currentNode;
            if (currentNode.next == null)
            {
                head = null;
                return prevNode;
            }
            while (currentNode.next != null)
            {
                prevNode = currentNode;
                currentNode = currentNode.next;
            }
            prevNode.next = null;
            return currentNode;

        }
        public void removeMatch(int data)
        {
            if (head == null)
            {
                return;
            }
            if (head.data == data)
            {
                head = head.getNext();
                return;
            }
            ListNode cuurentNode = head;
            ListNode nextNOde = cuurentNode.getNext();
            while (nextNOde != null)
            {
                if (nextNOde.data == data)
                {
                    cuurentNode.setNext(nextNOde.getNext());
                    return;
                }
                cuurentNode = nextNOde;
                nextNOde = nextNOde.next;
            }
        }
        public void display()
        {
            ListNode currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }
        }

    }
}
