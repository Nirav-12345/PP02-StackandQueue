using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUC3
{
    public class LinkedQueue
    {
        Node head = null;






        public void Enqueue(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = node;
            }

            Console.WriteLine("{0} inserted into linked list ", node.data);
        }

        public void Display()
        {
            Node tmp = this.head;

            if (tmp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (tmp != null)
            {
                Console.WriteLine(tmp.data + " ");
                tmp = tmp.Next;
            }
        }


        internal void dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Deletion is not possible");
            }

            Console.WriteLine("Vlaue Dequeue" + this.head.data);
            this.head = this.head.Next;
        }
    }



}
