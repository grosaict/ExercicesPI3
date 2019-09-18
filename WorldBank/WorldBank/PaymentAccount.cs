using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class PaymentAccount : Account
    {
        public PaymentAccount(Persona holder, long accountNumber, int branchOffice, double balance, double withdrawalFee)
            : base(holder, accountNumber, branchOffice, balance, withdrawalFee) { }
    }
}
