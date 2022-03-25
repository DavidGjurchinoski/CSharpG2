using System;
using Task_3.Entities;

namespace Task_3
{
    class Program
    {
        static private Customer[] customers = new Customer[]
        {
            new Customer("FirstNam", "LastName1", new AtmCard(123456778, 123)),
            new Customer("SomeoneElse", "ElseSOmeone", new AtmCard(123455151256778, 123)),
            new Customer("David", "Gjurcinoski", new AtmCard(1234565151778, 123))
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the ATM app.");

                Customer customer = FindCustomerByCard(customers);

                if (customer != null)
                {
                    do
                    {
                        Console.WriteLine($"Welcome {customer.PrintFullName()}!");

                        Console.WriteLine("What would you like to do(Enter the number from the options):");
                        Console.WriteLine("1.Check Balance");
                        Console.WriteLine("2.Cash Withdrawal");
                        Console.WriteLine("3.Cash Deposit");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine($"Your balance is: {customer.Card.Balance}");
                                break;
                            case "2":
                                Console.WriteLine("How much would you like to withdraw?");

                                if (long.TryParse(Console.ReadLine(), out long validWitdrawAmount))
                                {
                                    customer.Card.Withdraw(validWitdrawAmount);
                                }
                                else
                                {
                                    Console.WriteLine("Enter only numbers!");
                                }
                                break;
                            case "3":
                                Console.WriteLine("How much would you like to deposite?");

                                if (long.TryParse(Console.ReadLine(), out long validDepositeAmount))
                                {
                                    customer.Card.Deposite(validDepositeAmount);
                                }
                                else
                                {
                                    Console.WriteLine("Enter only numbers!");
                                }
                                break;
                            default:
                                Console.WriteLine("Please enter only the number ifront of the available options!");
                                break;
                        }

                        Console.WriteLine("If you want to do another transaction enter 'y'!");

                    } while (Console.ReadLine() == "y");
                }
                dsahdjaKJSH
                Console.WriteLine($"Goodbye {customer.PrintFullName()}. Have a nice day!");
            }
        }
        private static Customer FindCustomerByCard(Customer[] custumersArray)
        {
            Console.WriteLine("Enter card number:");

            
            long inputCardNumber = TransformCardNumberToLong(Console.ReadLine());

            foreach (Customer customer in custumersArray)
            {
                if(inputCardNumber == customer.Card.Number)
                {
                    Console.WriteLine("Enter the PIN of the card");

                    if (int.TryParse(Console.ReadLine(), out int validPin))
                    {
                        if (validPin == customer.Card.Pin)
                        {
                            return customer;
                        }

                        Console.WriteLine("Wrong PIN!!!");
                        return null;
                    }
                }
            }

            Console.WriteLine("No card found with that number!");
            return null;
        }

        private static AtmCard ValidCard()
        {
            Console.WriteLine("Enter card number:");
            string inputCardNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(inputCardNumber))
            {
                Console.WriteLine("Invalid input for number!");
                return null;
            }

            long validCardNumber = TransformCardNumberToLong(inputCardNumber);

            Console.WriteLine("Enter pin:");
            string inputCardPin = Console.ReadLine();

            if (!int.TryParse(inputCardPin, out int validCardPin) && string.IsNullOrEmpty(inputCardPin))
            {
                Console.WriteLine("Invalid input for pin!");
                return null;
            }

            return new AtmCard(validCardNumber, validCardPin);
        }

        private static long TransformCardNumberToLong(string cardNumber)
        {
            string onlyNumberString = "";

            foreach(char charachter in cardNumber) 
            {
                if(int.TryParse(charachter.ToString(), out int validCharNum))
                {
                    onlyNumberString += charachter;
                }
            }
            
            return long.Parse(onlyNumberString);
        }

        private static Customer RegisterCustomer() 
        {   

        }
    }
}
