using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var S = new Stack<int>(5);
            S.push(1);
            S.push(2);
            S.push(3);
            S.push(4);
            S.push(5);
            Console.WriteLine("Elements in Stack : ");
            for (int i = 0; i < S.count; i++)
                Console.WriteLine(S[i]);
            Console.WriteLine("Element Popped is : " + S.pop());
            Console.WriteLine("Pushed Element is : 6");
            S.push(6);
            Console.WriteLine("New Elements in Stack : ");
            for (int i = 0; i < S.count; i++)
                Console.WriteLine(S[i]);
        }
    }
    class Stack<T>
    {
        private T[] stack;
        private int top;
        public Stack(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Value must be greater than 0");
            }
            stack = new T[size];
            top = -1;
        }
        public T this[int index]
        {
            get
            {
                return stack[index];
            }
            set
            {
                stack[index] = value;
            }
        }
        public int count
        {
            get
            {
                return top + 1;
            }
        }
        public void push(T item)
        {
            if (top == stack.Length - 1)
            {
                throw new ArgumentException("Stack is OverFlow");
            }
            stack[++top] = item;
        }
        public T pop()
        {
            if (top < 0)
            {
                throw new ArgumentException("Stack is Empty!!");
            }
            return stack[top--];
        }
    }
}
