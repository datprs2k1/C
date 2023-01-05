using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_2
{
    internal class Account
    {
        private int id;
        private string firstName;
        private string lastName;
        private double balance;

        public Account() { }
        public Account(int id, string firstName, string lastName, double balance)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public int ID { get => id; set => id = value; }
        public string FirstName { get=> firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double Balance { get => balance; set => balance = value; }

        public void Input()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("Account");
            Console.Write("ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            lastName= Console.ReadLine();
            Console.Write("Balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
        }

        public void Show()
        {
            Console.Write("----------------------------------\n");
            Console.WriteLine("Account");
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            Console.WriteLine("Balance: {0}", balance);
        }
    }
}
