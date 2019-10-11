using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{

    enum TypeOfAccount
    {
        Checking, 
        Saving, 
        CD, 
        Loan


    }

    class Account
    {
        private static int lastAccountNumber = 0;


        #region Properties
        public string AccountName { get; set; }
        public decimal Balance { get; private set; }
        public string EmailAddress { get; set; }
        public TypeOfAccount AccountType { get; set; }

        public int AccountNumber { get; private set; }
        public DateTime CreatedDate { get; private set; }
        #endregion

        #region Constructor

        public Account()
        {
            AccountNumber = ++lastAccountNumber;

            CreatedDate = DateTime.Now;

        }


        #endregion

        #region Methods

        public void Deposit(decimal amount)
        {
            Balance += amount;

        }
        /// <summary>
        /// Withdraw money from your account
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }

        #endregion



    }
}
