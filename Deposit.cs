using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    internal class Deposit
    {
        private decimal amount;
        private User student;

        public Deposit(decimal amount, User student)
        {
            this.amount = amount;
            this.student = student;
        }
        public void DepositMoney(decimal amount)
        {
            this.amount = this.amount + amount;
        }
        public decimal AmountOfDeposit
        {
            get { return this.amount; }
        }

    }
}
