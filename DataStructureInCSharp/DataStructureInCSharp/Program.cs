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

            //1. Stack
            //**// start of stack code
            //StackA stack = new StackA(10);
            //stack.push(1);
            //stack.push(2);
            //stack.push(3);
            //stack.push(4);
            //stack.push(5);
            //stack.push(6);
            //stack.push(7);
            //stack.push(8);
            //stack.display();
            //Console.WriteLine("*************");
            //stack.pop();
            //stack.pop();
            //stack.pop();
            //stack.pop();
            //stack.display();
            //Console.ReadLine();
            //**//End of stack code

            //2. Queue
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

            //3. Circular LinkedList
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

            //4. Tree
            //**// Start of BinaryTree code
            //BinaryTree tree = new BinaryTree();
            //tree.root = new BTNode(1);
            //tree.root.left = new BTNode(2);
            //tree.root.right = new BTNode(3);
            //tree.root.left.left = new BTNode(4);
            //tree.root.left.right = new BTNode(5);
            ////tree.levelOrderTraverseWithouQueue();
            ////tree.leveOrderTraveseWithQueue();
            //tree.inOrderTraverseWithoutRecursion();
            //Console.ReadLine();
            //**// End of  BinaryTree code


            //4. Binary Search Tree
            //**// Start of Binary Serach Tree code
            //BST tree = new BST();
            //tree.insert(4);
            //tree.insert(2);
            //tree.insert(3);
            //tree.insert(1);
            //tree.insert(5);
            //tree.insert(6);
            //tree.insert(7);
            //BSTNode nodeSearched = tree.search(tree.root, 5);
            //Console.WriteLine("Node is " + nodeSearched.data);
            //Console.WriteLine("Inorder traversal");
            //tree.inorder(tree.root);
            //Console.ReadLine();
            //tree.delete(6);
            //tree.inorder(tree.root);
            //Console.ReadLine();
            //**// End of  Binary Search Tree code

            //5. Graph
            //**// Start of Garph code
            //AdjListGraph graph = new AdjListGraph(4);
            //graph.addEdge(0, 1);
            //graph.addEdge(0, 2);
            //graph.addEdge(0, 3);
            //graph.addEdge(1, 2);
            //graph.addEdge(2, 3);
            //graph.displayGraph();
            //Console.ReadLine();

            //**// End of Graph code

            //6. Sorting
            //**// Selection Sort
            Sorting sort = new Sorting(10);
            sort.createRandomArray();
            //sort.selectionSort();
            sort.bubbleSort();
            sort.display();
            Console.ReadLine();

        }
    }
}
