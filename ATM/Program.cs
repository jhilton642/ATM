using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance;
            string accountName;
            Checking checking = null;
            Savings savings = null;
            while (true)
            {
                Console.WriteLine("1. Exit program");
                Console.WriteLine("2. Create Checking Account");
                Console.WriteLine("3. Create Savings Account");
                Console.WriteLine("4. Get Checking Balance");
                Console.WriteLine("5. Get Savings Balance");
                Console.WriteLine("6. Make a Deposit to Checking");
                Console.WriteLine("7. Make a Deposit to Savings");
                int menuOption = Utils.GetNumber("Enter a menu option: ");
                if (menuOption == 1)
                {
                    break;
                }
                if (menuOption == 2)
                {
                    float fIntrestRate = 0.02F;
                    accountName = Utils.GetInput("What would you like to name your account: ");
                    balance = Utils.GetNumber("What is the initial balance of the account: ");
                    checking = new Checking(accountName,balance,fIntrestRate);
                }
                if (menuOption == 3)
                {
                    float fIntrestRate = 0.03F;
                    accountName = Utils.GetInput("What would you like to name your account: ");
                    balance = Utils.GetNumber("What is the initial balance of the account: ");
                    savings = new Savings(accountName, balance, fIntrestRate);
                    
                }
                if (menuOption == 4)
                {
                    Console.WriteLine(checking);
                   
                }
                if (menuOption == 5)
                {
                    Console.WriteLine(savings);
                }
                if (menuOption == 6)
                {
                    int depositAmount = Utils.GetNumber("How much would you like to deposit: ");
                    checking.Deposit(depositAmount);
                }
                if (menuOption == 7)
                {
                    int depositAmount = Utils.GetNumber("How much would you like to deposit: ");
                    savings.Deposit(depositAmount);
                }
            }
        }
    }
}
