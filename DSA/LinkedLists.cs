using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DSA
{
    /// <summary>
    /// Linked Lists, as the word implies, a list where the nodes are linked together.
    /// Each node contains data and a pointer.
    /// The way they are linked together is that each node points to where 
    /// in the memory the next node is placed.
    /// https://www.w3schools.com/dsa/dsa_theory_linkedlists.php
    /// </summary>
    internal class LinkedLists
    {
        internal class Node
        {
            public Node(int data) { this.Data = data; }
            public int Data { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }
        }

        internal void SinglyLinkedList()
        {
            Node node1 = new(1);
            Node node2 = new(2);
            Node node3 = new(3);
            Node node4 = new(4);
            Node node5 = new(5);

            node1.NextNode = node2;
            node2.NextNode = node3;
            node3.NextNode = node4;
            node4.NextNode = node5;

            var currentNode = node1;
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " -> ");
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine("null");
        }

        internal void DoublyLinkedList()
        {
            Node node1 = new(1);
            Node node2 = new(2);
            Node node3 = new(3);
            Node node4 = new(4);
            Node node5 = new(5);

            node1.NextNode = node2;

            node2.NextNode = node3;
            node2.PrevNode = node1;

            node3.NextNode = node4;
            node3.PrevNode = node2;

            node4.NextNode = node5;
            node4.PrevNode = node3;

            node5.PrevNode = node4;

            Node currentNode = node1;
            Console.WriteLine("Traversing forward");
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " -> ");
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine("null");

            currentNode = node5;
            Console.WriteLine("Traversing backward");
            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " -> ");
                currentNode = currentNode.PrevNode;
            }
            Console.WriteLine("null");
        }

        internal void CircularSinglyLinkedList()
        {
            Node node1 = new(1);
            Node node2 = new(2);
            Node node3 = new(3);
            Node node4 = new(4);
            Node node5 = new(5);

            node1.NextNode = node2;
            node2.NextNode = node3;
            node3.NextNode = node4;
            node4.NextNode = node5;
            node5.NextNode = node1;

            var currentNode = node1;
            var startNode = node1;
            Console.Write(currentNode.Data + " -> ");
            currentNode = currentNode.NextNode;

            while (currentNode != startNode)
            {
                Console.Write(currentNode.Data + " -> ");
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine(" ... ");
        }

        internal void CircularDoublyLinkedList()
        {
            Node node1 = new(1);
            Node node2 = new(2);
            Node node3 = new(3);
            Node node4 = new(4);
            Node node5 = new(5);

            node1.PrevNode = node5;
            node1.NextNode = node2;

            node2.NextNode = node3;
            node2.PrevNode = node1;

            node3.NextNode = node4;
            node3.PrevNode = node2;

            node4.NextNode = node5;
            node4.PrevNode = node3;

            node5.NextNode = node1;
            node5.PrevNode = node4;

            Node currentNode = node1;
            Node startNode = node1;

            Console.WriteLine("Traversing forward");
            Console.Write(currentNode.Data + " -> ");
            currentNode = currentNode.NextNode;
            while (currentNode != startNode)
            {
                Console.Write(currentNode.Data + " -> ");
                currentNode = currentNode.NextNode;
            }
            Console.WriteLine(" ... ");

            
            Console.WriteLine("Traversing backward");
            currentNode = node5;
            Console.Write(currentNode.Data + " -> ");
            currentNode = currentNode.PrevNode;
            startNode = node5;
            while (currentNode != startNode)
            {
                Console.Write(currentNode.Data + " -> ");
                currentNode = currentNode.PrevNode;
            }
            Console.WriteLine(" ... ");
        }
    }
}
