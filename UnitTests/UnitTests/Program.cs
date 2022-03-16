using System;

namespace UnitTests
{
    public class Program
    {
        public static void UserInterface()
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Hello! Choose one of the following operations: ");
            Console.WriteLine("-----------------------------------------------");
            int operation;
            while (true)
            {
                Console.WriteLine("Press (1) to ViewBalance");
                Console.WriteLine("Press (2) to Withdraw money");
                Console.WriteLine("Press (3) to Deposit money");
                Console.WriteLine("Press (0) to exit");
                Console.WriteLine("-----------------------------------------------");
                Console.Write("Your option is : ");
                operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------");
                if (operation==0)
                {
                    Console.WriteLine("\nThanks for using our ATM!");
                    break;
                }
                decimal money;

                switch (operation)
                {

                    case 1:
                        ViewBalance();
                        break;
                    case 2:
                        Console.Write("Enter the amount of money to withdraw: ");
                        money = Convert.ToDecimal(Console.ReadLine());
                        WithDraw(money);
                        break;
                    case 3:
                        Console.Write("Enter the amount of money to Deposit: ");
                        money = Convert.ToDecimal(Console.ReadLine());
                        Deposit(money);
                        break;   
                }
            }

        }
        public static decimal ViewBalance()
        {
            Console.WriteLine($"Your balance is {balance}$");
            Console.WriteLine("-----------------------------------------------");
            return balance;
        }
        public static decimal WithDraw(decimal money)
        {
            if (money > balance)
            {
                Console.WriteLine($"Sorry, You can't Withdraw more money than what’s available ({balance}$)");
                Console.WriteLine("-----------------------------------------------");
            }
            else if (money < 0)
            {
                Console.WriteLine("You can't WithDraw a negative amount of money!");
                Console.WriteLine("-----------------------------------------------");
            }
            else
            {
                Console.WriteLine($"You did a WithDraw of {money}$");
                Console.WriteLine("-----------------------------------------------");
                return balance -= money;
            }
            return balance;
        }
        public static decimal Deposit(decimal money)
        {
            if (money<0)
            {
                Console.WriteLine("You can't Deposite a negative amount of money!");
                Console.WriteLine("-----------------------------------------------");
            }
            else
            {
                Console.WriteLine($"You did a Deposit of {money}$");
                Console.WriteLine("-----------------------------------------------");
                return balance += money;
            }
            return balance;
        }

        public static decimal balance = 1000;
        static void Main(string[] args)
        {
            try
            {
            UserInterface();
            }
            catch(FormatException e)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("\nSorry, but you entered a wrong format...");
                Console.WriteLine("Program will restart and let you choose again. \n");
                UserInterface();
            }
        }
    }
}
