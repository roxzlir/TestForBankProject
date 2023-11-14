using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForBankProject
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public double AccountBalance { get; set; }

        public BankAccount(int accountNumber, string accountOwner, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountOwner = accountOwner;
            AccountBalance = accountBalance;
        }
        public double AddFundsToAcc(double addAmount, double accountBalance)
        {
            AccountBalance = addAmount + accountBalance;
            return AccountBalance;
        }
    }               //Login login = new Login();
                    //login.LoginAs(); ----> Detta blir samma som den ovan!

    //BankAccount konto1 = new BankAccount(123, "Emil Nordin", 100);

    //konto1.AddFundsToAcc(GetInputNumber(),konto1.AccountBalance);
    //Console.WriteLine(konto1.AccountBalance);
}
