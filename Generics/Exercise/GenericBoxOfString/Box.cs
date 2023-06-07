using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box <T> where T : IComparable<T>
    {
        
        private List<T> list;       
        public Box()
        {

            this.list = new List<T>();

        }

        public void Add(T item) 
        {
           list.Add(item);
        }

        public int Count(T item)
        {
            int count = 0;

            foreach (T element in list) 
            {
                
                if (element.CompareTo(item) > 0) count++; 
            }
            return count;
        }

       

        public override string ToString()
        {
            //return $"{typeof(T)}: {value.ToString()}";
            return $"{Count}";
        }
    }
}
