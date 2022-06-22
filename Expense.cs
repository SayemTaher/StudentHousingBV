using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    internal class Expense
    {


        private decimal price;
        private string name;
        private User student;

        public Expense (string name, decimal price, User student)
        {
            this.name = name;
            this.price = price;
            this.student = student;
        }
        public Expense(string name, decimal price)
        {
            this.name = name;
            this.price = price;  
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
