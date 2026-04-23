using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    public class Transaction
    {
        public Transaction (Decimal amount, TransactionKind kind)
        {
            Amount = amount;
            Kind = kind;
        }
        public decimal Amount { get; }
        public TransactionKind Kind { get; }
    }


}
