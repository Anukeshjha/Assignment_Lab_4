using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que8
{
    internal class Program
    {
        public enum Season
        {
            Summer,
            Winter,
            Rainy,
            Spring,
            Autumn
        }
        static void Main(string[] args)
        {
            Season now = Season.Spring;
            switch (now)
            {
                case Season.Spring:
                    Console.WriteLine("It's spring time!");
                    break;
                case Season.Rainy:
                    Console.WriteLine("It's Rainy time!");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer time!");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's autumn!");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's winter time!");
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    break;
            }
        }
    }
}