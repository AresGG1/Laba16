using System;
using System.Collections.Concurrent;
using System.Net;
using System.Reflection.Emit;

namespace Lab16
{
    public class CustomStack
    {
        private const int MAX_SIZE = 255;
        private int size;
        private char[] elems;

        public int Size
        {
            get
            {
                return size;
            }
        }

        public CustomStack()
        {
            elems = new char[MAX_SIZE];
            size = 0;
        }

        public void Append(char elem)
        {
            elems[size] = elem;
            size++;
        }

        public char Pop()
        {
            if (size != 0)
            {
                var elem = elems[size - 1];
                size--;
                return elem;
            }
            throw new Exception("Empty stack ");
        }
    }
}