﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class Savings : Account
    {
        public Savings(string accountName, decimal balance, float interestRate) : base(accountName, balance, interestRate)
        {
            //      gift of a $100 for opening an new account
            this.Deposit(100);
        }
    }
}