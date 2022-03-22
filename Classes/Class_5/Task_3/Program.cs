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
            
        }

        private static Customer Authenticate()
        {

            Customer customer = FindCustomerByCard(new AtmCard(validCardNumber, validCardPin), customers);

            if(customer == null)
            {
                Console.WriteLine("No ACC with those inputs");

            }
        }

        private static Customer FindCustomerByCard(AtmCard card, Customer[] custumersArray)
        {
            foreach(Customer customer in custumersArray)
            {
                if(card.Number == customer.Card.Number && card.Pin == customer.Card.Pin)
                {
                    return customer;
                }
            }
            return null;
        }

        static AtmCard ValidCard()
        {
            Console.WriteLine("Enter card number:");
            string inputCardNumber = Console.ReadLine();

            if (!int.TryParse(inputCardNumber, out int validCardNumber) && string.IsNullOrEmpty(inputCardNumber))
            {
                Console.WriteLine("Invalid input for number!");
                return null;
            }

            Console.WriteLine("Enter pin:");
            string inputCardPin = Console.ReadLine();

            if (!int.TryParse(inputCardPin, out int validCardPin) && string.IsNullOrEmpty(inputCardPin))
            {
                Console.WriteLine("Invalid input for pin!");
                return null;
            }

            return new AtmCard(validCardNumber, validCardPin);
        }
    }
}
