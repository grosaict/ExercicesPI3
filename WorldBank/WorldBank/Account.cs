using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    abstract class Account
    {
        public Persona Holder { get; set; }
        public long AccountNumber { get; set; }
        public int BranchOffice { get; set; }
        public double Balance { get; set; }
        public double WithdrawalFee { get; set; }

        public Account(Persona holder, long accountNumber, int branchOffice, double balance, double withdrawalFee)
        {
            Holder          = holder;
            AccountNumber   = accountNumber;
            BranchOffice    = branchOffice;
            Balance         = balance;
            WithdrawalFee   = withdrawalFee;
        }

        public virtual void Withdrawal() { }
        public abstract double CheckBalance() { }                               // CHECK HOW TO FIX THIS ERROR WITH TEACHER
        public abstract void Transfer(Account account, double value) { }        // CHECK HOW TO FIX THIS ERROR WITH TEACHER
    }
}
