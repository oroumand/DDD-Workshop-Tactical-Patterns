namespace DomainServices.BankAccounts
{
    public interface IMoneyTransfer
    {
        bool Transfer(BankAccount from, BankAccount to, CentralBankMoneyTransferSettings centralBankMoneyTransferSettings);
    }
}