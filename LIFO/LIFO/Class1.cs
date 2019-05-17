using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{
    public class Element<T>
    {
        public T Value;
        public Element<T> nextElement;

        public Element(T i)
        {
            Value = i;
        }
    }

    public class Stacks<T>
    {
        public class Element<T>
        {
            public T Value;
            public Element<T> nextElement;

            public Element(T i)
            {
                Value = i;
            }
        }
        private Element<T> firstElement;

        public int Count
        {
            get
            {
                var ValueHowl = 0;
                var currentElement = firstElement;
                while (currentElement != null)
                {
                    ValueHowl++;
                    currentElement = currentElement.nextElement;
                }
        
                return ValueHowl;
            }
        }

        public void Push(T NEW)
        {
            var newElement = new Element<T>(NEW);
            if (firstElement != null)
                newElement.nextElement = firstElement;
            firstElement = newElement;
        }

        public T Peek()
        {
            return firstElement.Value;
        }

        public T Pop()
        {
            if (firstElement == null) throw new InvalidOperationException("Stack is Empty");

            var deletingElement = firstElement.Value;
            firstElement = firstElement.nextElement;
            return deletingElement;
        }
    }
    

}
