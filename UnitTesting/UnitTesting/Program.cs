using System;

namespace UnitTesting
{
   public class Program
    {
        static void Main(string[] args)
        {
            string startingBalance = "1000";
            string currentUser = "Tyler";
            FirstLoadUI(currentUser, startingBalance);
        }//closing Main

        static void FirstLoadUI(string user, string currentBalance)
        {
            Console.WriteLine($"Hello {user}, welcome back!");
            Interface(user, currentBalance);
        }//closing FirstLoadUI

        static void Interface(string user, string balance)
        {
            Console.WriteLine("Please select what you would like to do.");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");

            string input = Console.ReadLine();

            if(input == "1")
            {
                Balance(user, balance);
            }
            if(input == "2")
            {
                Console.WriteLine("How much would you like to withdraw?");
                Withdraw(balance, Console.ReadLine());
            }
            if(input == "3")
            {
                Console.WriteLine("How much are you depositing?");
                Deposit(balance, Console.ReadLine());                
            }
            else
            {
                //close console
            }
        }//closing Inferface

        public static string Balance(string user, string balance)
        {
            string response = $"{user} your balance is ${balance}";
            return response;
        }//closing Balance

        public static string Withdraw(string balance, string amount)
        {
            int response = Convert.ToInt32(balance) - Convert.ToInt32(amount);
            return response.ToString();
        }//closing Withdraw

        public static string Deposit(string balance, string amount)
        {
            int response = Convert.ToInt32(balance) + Convert.ToInt32(amount);
            return response.ToString();
        }//closing Deposit
    }
}
