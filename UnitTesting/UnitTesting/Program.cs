using System;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }//closing Main

        static void FirstLoadUI(string user)
        {
            Console.WriteLine($"Hello {user}, welcome back!");
            Interface();
        }//closing FirstLoadUI

        static void Interface()
        {
            Console.WriteLine("Please select what you would like to do.");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            if(input == "1")
            {
                //call view balance method
            }
            if(input == "2")
            {
                //call withdraw method
            }
            if(input == "3")
            {
                //call deposit method
            }
            else
            {
                //close console
            }
        }//closing Inferface

        static void Balance()
        {

        }//closing Balance

        static void Withdraw()
        {

        }//closing Withdraw

        static void Deposit()
        {

        }//closing Deposit
    }
}
