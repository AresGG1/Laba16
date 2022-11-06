using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters;
using System.Xml.Schema;

namespace Lab16_2
{
    public class Deque<T>
    {
        private const int maxElems = 255;
        private T[] elements;
        private T first;
        private T rare;
        private int size;

        public Deque(IEnumerable<T> array)
        {
            int size = 0;
            elements = new T[maxElems];
            foreach (var elem in array)
            {
                elements[size] = elem;
                size++;
            }

            this.size = size;
        }
        
        public Deque(params T[] array)
        {
            int size = 0;
            elements = new T[maxElems];
            foreach (var elem in array)
            {
                elements[size] = elem;
                size++;
            }

            this.first = elements[0];
            this.rare = elements[size-1];
            this.size = size;
        }

        public Deque()
        {
            elements = new T[maxElems];
            size = 0;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public void pushBack(T value)
        {
            if(size < maxElems)
                elements[size] = value;
            this.rare = elements[size];
            size++;
            this.rare = elements[size-1];

        }

        public void pushFront(T value)
        {
            if (size < maxElems-1)
            {
                T[] newArray = new T[maxElems];
                for (int i = 0; i < size; i++)
                {
                    newArray[i + 1] = elements[i];
                }
                size++;
                newArray[0] = value;
                this.elements = newArray;
                this.first = elements[0];
                this.rare = elements[size-1];
            }
        }

        public T Front
        {
            get
            {
                if(size > 0)
                    return this.first;
                throw new Exception("Empty Queue");
            }
        }
        public T Back
        {
            get
            {
                if(size > 0)
                    return elements[size-1];
                throw new Exception("Empty Queue");
            }
        }

        public void Clear()
        {
            this.elements = new T[maxElems];
            this.rare = default(T);
            this.size = 0;
        }

        public T PopFront()
        {
            if (size > 0)
            {
                T[] newArray = new T[maxElems];
                for (int i = 0; i < size-1; i++)
                {
                    newArray[i] = elements[i+1];
                }

                size--;
                T res = elements[0];
                this.elements = newArray;
                return res;
            }
            this.rare = elements[size-1];
            throw new Exception("Empty Queue");
        }
        public T PopBack()
        {
            if (size > 0)
            {
                T[] newArray = new T[maxElems];
                for (int i = 0; i < size-1; i++)
                {
                    newArray[i] = elements[i];
                }
                T res = elements[size-1];
                size--;
                this.elements = newArray;
                return res;
            }
            this.rare = elements[size-1];
            throw new Exception("Empty Queue");
        }

        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}