using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkList
    {
        public Node head;

        public void Add(int data)
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

        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }

            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.Next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.Next = this.head.Next;
                        head.Next = node;
                        break;
                    }
                    head = head.Next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            Console.WriteLine("Inserted value is " + head);
            return head;
        }
    }
}