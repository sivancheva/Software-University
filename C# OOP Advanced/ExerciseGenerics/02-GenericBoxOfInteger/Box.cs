using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    public class Box<T>
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

        public override string ToString()
        {
            return $"{this.element.GetType().FullName}: {this.element}";
        }

    }   

}
