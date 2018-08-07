using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T> : IComparable<Box<T>>
        where T:IComparable
    {
        private T element;

        public Box()
        {
            this.Element = element;
        }

        public T Element
        {
            get { return element; }
            set { element = value; }
        }
        
        public int CompareTo(Box<T> other)
        {
            return this.Element.CompareTo(other.Element);
        }

        public override string ToString()
        {
            return $"{this.element.GetType().FullName}: {this.element}";
        }

    }   

}
