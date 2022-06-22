using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    internal class MoneyJar
    {
        private decimal currentAmount = 0;
        List<Deposit> depositList = new List<Deposit>();

        public MoneyJar (decimal amount)
        {
            currentAmount = amount;
        }

        public decimal CurrentAmountInMoneyJar
        {
             get { return currentAmount; }
        }
        public void DepositMoney(Deposit deposit)
        {
            depositList.Add(deposit);
            currentAmount = currentAmount + deposit.AmountOfDeposit;
        }
        public void WithdrawMoney(decimal amount)
        {
           this.currentAmount = this.currentAmount + amount;
        }

    }
}
