using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperture temperture = new Temperture();
            temperture.Celsius = 40.8;
            Console.WriteLine("Temperature in Celsius : " + temperture.Celsius);
            Console.WriteLine("Temperature in Fahreneit : " + temperture.fahreneit);
        }
    }
    class Temperture
    {
        private double temperature;
        public double Celsius
        {
            set
            {
                temperature = value;
            }
            get
            {
                return temperature;
            }
        }
        public double fahreneit
        {
            get
            {
                return ((temperature * 9 / 5) + 32);
            }
        }
    }
}
