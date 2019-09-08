using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class CheckingAccount : Account
    {
        public string Type { get; }
        public double AccountLimit { get; }
        public double LimitFee { get; }

        public CheckingAccount(Persona holder, long accountNumber, int branchOffice, double balance, double withdrawalFee)
                    : base(holder, accountNumber, branchOffice, balance, withdrawalFee) { }

        public override void Withdrawal() { }
        public override double CheckBalance() { return 0; }
        public override void Transfer(Account account, double value) { }

    }
}
