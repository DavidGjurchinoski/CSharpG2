using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3.Entities
{
    class AtmCard
    {
        public AtmCard(long number, int pin)
        {
            Number = number;
            Pin = pin;
        }

        public long Number { get; set; }

        private int _pin;
        public int Pin 
        {
            get
            {
                return _pin;
            }
            set
            {
                _pin = value;
            } 
        }
        
        private long _balance;

        public long Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void Withdraw(long amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine($"You dont have enough money! Your Balance is {Balance}$.");
            } 
            else
            {
                Console.WriteLine($"You withdrew {amount}$. You have {Balance}$ left on your account.");
                Balance -= amount;
            }
        }

        public void Deposite(long amount)
        {
            Balance += amount;

            Console.WriteLine($"You diposited {amount}$. Your current balance is {Balance}$.");
        }
    }
}
