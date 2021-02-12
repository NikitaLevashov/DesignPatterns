using System;
using System.Collections.Generic;
using System.Text;

namespace PatternChainOfResponsibility
{
    public class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPalTransfer { get; set; }
        public Receiver(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}
