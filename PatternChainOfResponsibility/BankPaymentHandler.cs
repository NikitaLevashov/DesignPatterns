using System;
using System.Collections.Generic;
using System.Text;

namespace PatternChainOfResponsibility
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Выполняем банковский перевод");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
