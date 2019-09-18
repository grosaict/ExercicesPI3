﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorldBank
{
    class CheckingAccount : Account
    {
        public string Type { get; }
        public double AccountLimit { get; }
        public double LimitFee { get; }

        public CheckingAccount
            (
                Persona holder,
                long accountNumber,
                int branchOffice,
                double balance,
                double withdrawalFee,
                string type,
                double accountLimit,
                double limitFee
            )
            : base
            (
                holder,
                accountNumber,
                branchOffice,
                balance,
                withdrawalFee
            )
        {
            Type            = type;
            AccountLimit    = accountLimit;
            LimitFee        = limitFee;
        }
        public override double CheckBalance()
        {
            return Balance + AccountLimit;
        }
    }
}
