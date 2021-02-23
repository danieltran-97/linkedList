﻿using System;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of singlylinkedlist
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.insertFirst(100);
            myList.insertFirst(50);
            myList.insertFirst(99);
            myList.insertFirst(88);
            myList.insertLast(9910);
            myList.displayList();
            myList.deleteFirst();
            myList.displayList();
        }
        //this class will use the Node class
        public class SinglyLinkedList
        {
            private Node first;
            public bool isEmpty()
            {
                return (first == null);
            }
            // inserts first node at the beginning of the list
            public void insertFirst(int data)
            {
                Node newNode = new Node();
                newNode.data = data;
                newNode.next = first;
                first  = newNode;
            }
            public Node deleteFirst()
            {
                Node temp = first;
                first = first.next;
                return temp;

            }
            //Used to print out the contents of the list
            public void displayList()
            {
                Console.WriteLine("List (first -- last)");
                Node current = first;
                while (current != null)
                {
                    current.displayNode();
                    current = current.next;
                }
                Console.WriteLine();
            }
            public void insertLast(int data)
            {
                Node current = first;
                while(current.next != null)
                {
                    current = current.next;
                }
                Node newNode = new Node();
                newNode.data = data;
                current.next = newNode;

            }
        }
        public class Node 
        {
            public int data;
            // recursive
            public Node next;

            public void displayNode()
            {
                Console.WriteLine("<" + data + ">");
            }
        }
    }
}
