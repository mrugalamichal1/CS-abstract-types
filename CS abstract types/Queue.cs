using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_abstract_types
{
    class Queue<T>
    {
        public Node<T> Tail { get; set; }
        public Node<T> Head { get; set; }

        //Constructor of empty queue
        public Queue()
        {
            this.Tail = this.Head = null;
        }

        //Method to add element on the back 
        public void Enqueue(Node<T> element)
        {
            if (this.Tail == null && this.Head == null)
                this.Tail = this.Head = element;
            else
            {
                this.Tail.Previous = element;
                element.Next = this.Tail;
                this.Tail = element;
            }
        }

        //Method to remove element in front
        public T Dequeue()
        {
            if (this.Tail == null && this.Head == null)
                Console.WriteLine("Queue is empty");
            else
                this.Head = this.Head.Previous;
            return this.Head.Data;
        }

        //Method for displaying elements of the queue from head to tail
        public void DisplayContent()
        {
            if (this.Tail == null && this.Head == null)
                Console.WriteLine("Queue is empty");
            else
            {
                Node<T> temp = this.Head;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data.ToString());
                    temp = temp.Previous;
                }
            }
        }

        //Method for emptying queue
        public void Clear()
        {
            this.Head = this.Tail = null;
        }

        //Method for returning queue length
        public int Length()
        {
            int lenght = 0;
            Node<T> temp = this.Tail;
            while (temp != null)
            {
                lenght++;
                temp = temp.Next;
            }
            return lenght;
        }
    }
}
