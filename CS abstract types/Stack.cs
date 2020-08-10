using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_abstract_types
{
    class Stack<T>
    {
        public Node<T> Top { get; set; }

        //Constructor of empty stack
        public Stack()
        {
            this.Top = null;
        }


        //Method to add element on the top of the stack
        public void Push(Node<T> element)
        {
            if (this.Top == null)
            {
                this.Top = element;
            }
            else
            {
                element.Previous = this.Top;
                this.Top.Next = element;
                this.Top = element;
            }
        }

        //Method to remove top element from the stack
        public T Pop()
        {
            Node<T> temp = null;
            if (this.Top == null)
                Console.WriteLine("Stack is empty");
            else
            {
                temp = this.Top;
                this.Top = this.Top.Previous;
            }
            return temp.Data;
        }

        //Method to return top element from the stack
        public T Peek()
        {
            return this.Top.Data;
        }

        //Method to empty stack
        public void Clear()
        {
            this.Top = null;
        }

        //Method to display elements of the stack
        public void DisplayContent()
        {
            Node<T> temp = this.Top;
            if (temp == null)
                Console.WriteLine("Stack is empty");
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Previous;
            }
        }

        //Method for returning stack length
        public int Length()
        {
            int lenght = 0;
            Node<T> temp = this.Top;
            while (temp != null)
            {
                lenght++;
                temp = temp.Previous;
            }
            return lenght;
        }
    }
}
