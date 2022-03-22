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
        public int Pin { get; set; }
    }
}
