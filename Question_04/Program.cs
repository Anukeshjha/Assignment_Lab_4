using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Collection = new CustomList<String>();
            Collection[0] = "Suraj jha";
            Collection[1] = "Sameer jha";
            Collection[2] = "Sachin jha";
            Collection[3] = "Kunal jha";
            Collection[4] = "Abhisekh jha";
            Console.WriteLine("Anukesh Friend list : ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(Collection[i]);
        }
    }
    class CustomList<T>
    {
        private T[] list = new T[5];
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}
