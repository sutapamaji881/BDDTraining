﻿namespace BDDTraining.ModelClass
{
    internal class Account
    {
        private int balance;

        public void deposite(int amount)
        {
            balance = balance + amount;
        }
        public int getBalance()
        {
            return this.balance;

        }
    }
}