using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class BankCard
    {
        public string? PAN { get; init; }
        public string? PIN { get; init; }
        public string? CVV { get; init; }
        public string? ExpireDate { get; init; }

        private double balance;

        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid amount");

                balance = value;
            }
        }

        public BankCard(string? pan, string? pin, string? cvv, string? expireDate, double balance)
        {
            PAN = pan;
            PIN = pin;
            CVV = cvv;
            ExpireDate = expireDate;
            Balance = balance;
        }

    }

}
