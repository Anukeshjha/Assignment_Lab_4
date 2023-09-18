
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Balance = 20000;
            Console.WriteLine("The available balance is : " + account.Balance);
            account.Balance = 1500;
            Console.WriteLine("The available balance is : " + account.Balance);
        }
    }
    class Account
    {
        private int bal;
        public int Balance
        {
            get
            {
                return bal;
            }
            set
            {
                if (value >= 0)
                {
                    bal = value;
                }
                else
                    throw new ArgumentException("Value must be greater than 0");
            }
        }
    }
}
