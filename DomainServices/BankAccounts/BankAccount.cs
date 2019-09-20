using System;
using System.Collections.Generic;
using System.Text;

namespace DomainServices.BankAccounts
{
    public class CentralBankMoneyTransferSettings
    {
        public int MaxAmount { get; set; }
    }
    public class BankAccount
    {
    }
    public class MoneyTransfer : IMoneyTransfer
    {
        public bool Transfer(BankAccount from, BankAccount to, CentralBankMoneyTransferSettings centralBankMoneyTransferSettings)
        {
            return true;
        }

    }
    public class SatnaTransfer : IMoneyTransfer
    {
        public bool Transfer(BankAccount from, BankAccount to, CentralBankMoneyTransferSettings centralBankMoneyTransferSettings)
        {
            throw new NotImplementedException();
        }
    }
    public class PayaTransfer : IMoneyTransfer
    {
        public bool Transfer(BankAccount from, BankAccount to, CentralBankMoneyTransferSettings centralBankMoneyTransferSettings)
        {
            throw new NotImplementedException();
        }
    }
}
