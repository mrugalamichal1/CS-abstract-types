using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_abstract_types
{
    class List<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        //Constructor of empty list
        public List()
        {
            this.Head = this.Tail = null;
        }

        //Method to add element in front
        public void AddHead(Node<T> element)
        {
            if (this.Tail == null && this.Head == null)
                this.Tail = this.Head = element;
            else
            {
            this.Head.Next = element;
            element.Previous = this.Head;
            this.Head = element;
            }

        }

        //Method to add element on back
        public void AddTail(Node<T> element)
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

        //Method to display content of the list from tail to head
        public void DisplayContent()
        {
            Node<T> temp = this.Tail;
            if (this.Tail == null && this.Head == null)
                Console.WriteLine("List is empty");
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.Data.ToString());
                    temp = temp.Next;
                }
            }
        }

        //Method to empty list
        public void Clear()
        {
            this.Head = this.Tail = null;
        }
        
        //Method to check if element of the list exists
        public bool Exists(T data)
        {
            bool exists = false;
            Node<T> temp = this.Tail;
            while (temp != null)
            {
                if (temp.Data.ToString() == data.ToString())
                    exists = true;
                temp = temp.Next;
            }
            return exists;
        }

        //Method to remove element/s with certain value
        public bool Remove(T data)
        {
            Node<T> temp = this.Tail;
            while (temp != null)
            {
                if (temp.Data.ToString() == data.ToString())
                {
                    temp.Previous.Next = temp.Next;
                    temp.Next.Previous = temp.Previous;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        //Method to return length of list
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

        //Method to remove element at index
        public bool RemoveAtIndex(int index)
        {
            Node<T> temp = this.Tail;
            if (this.Length()-1 < index)
            {
                Console.WriteLine("Index out of range");
                return false;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }
                if (temp == this.Tail)
                {
                    this.Tail = this.Tail.Next;
                    this.Tail.Previous = null;
                }
                else if (temp == this.Head)
                {
                    this.Head = this.Head.Previous;
                    this.Head.Next = null;
                }
                else
                {
                    temp.Previous.Next = temp.Next;
                    temp.Next.Previous = temp.Previous;
                }
            }
            return true;
        }

    }
}
