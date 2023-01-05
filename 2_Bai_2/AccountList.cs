﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Bai_2
{
    internal class AccountList
    {
        private ArrayList list = new ArrayList();

        public void NewAccount()
        {
            Console.Write("----------------------------------\n");
            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < quantity; i++)
            {
                Account a = new Account();
                a.Input();
                list.Add(a);
            }
        }

        public void Report()
        {
            Console.WriteLine("List Account");
            Console.Write("----------------------------------\n");

            foreach (Account a in list)
            {
                a.Show();
            }
        }

        public void SaveFile()
        {
            Console.Clear();
            Console.Write("----------------------------------\n");

            Console.Write("File name: ");
            string fileName = Console.ReadLine();

            try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);

                StreamWriter streamWriter = new StreamWriter(fileStream);

                foreach(Account a in list)
                {
                    streamWriter.WriteLine("{0},{1},{2},{3}", a.ID, a.FirstName, a.LastName, a.Balance);
                }

                streamWriter.Close();
                fileStream.Close();
                
            } catch(IOException e)
            {
                Console.WriteLine(e.Message);   
            }
        }
   
        public void LoadFile()
        {

            Console.Clear();
            Console.Write("----------------------------------\n");

            Console.Write("File name: ");
            string fileName = Console.ReadLine();

          try
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);

                list.Clear();

                string str;

                while ((str = streamReader.ReadLine()) != null)
                {
                    string[] Account = str.Split(',');

                    Account a = new Account(Convert.ToInt32(Account[0]), Account[1], Account[2], Convert.ToDouble(Account[3]));

                    list.Add(a);
                }

                streamReader.Close();
                fileStream.Close();
            } catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
