using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Client
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public BankCard? Card { get; init; }

        public Client(string? name, string? surname, BankCard? card)
        {
            Name = name;
            Surname = surname;
            Card = card;
        }

    }
}
