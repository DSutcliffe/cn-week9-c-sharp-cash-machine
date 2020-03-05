using System;

namespace cn_week9_c_sharp_cash_machine
{
    class Program
    {
        void withdrawal(int bankBalance, int withdrawalAmount)
        {
            bankBalance -= withdrawalAmount;
            Console.WriteLine("My new balance is: £{0}", bankBalance);
        }
        void checkPin(string userInput, string pinNumber)
        {
            if(userInput == pinNumber)
            {
                Console.WriteLine("PIN OK");
            }
            else
            {
                Console.WriteLine("PIN INCORRECT");
            }
        }
        static void Main(string[] args)
        {
            Program cashMachine = new Program();
            cashMachine.withdrawal(500, 30);

            // taking user input
            string pinNumber = "1000";
            string userInput;
            Console.Write("Please enter your input: ");
            userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            cashMachine.checkPin(userInput, pinNumber);
        }
    }
}
