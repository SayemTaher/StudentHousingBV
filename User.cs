using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

//#######################################
//info 
//#######################################
// Convaetion of names chnage to add _. to private names due to need for more varibles of the same stuff
// and keep encapsulation form, this change is cosue by implemetaion of .json 
//                                                           ~Michal



namespace Student_Housing
{
    public class User
    {
        private string _name;
        private string _lastName;
        private Property _property;
        private Account _account;
        private Guid _id;

        //Created for serialization for json
        public string Name => _name;
        public string LastName => _lastName;
        public Property Property => _property;
        public Account Account => _account;       
        public Guid Id => _id;
        //Info for json which constructor to use


        [JsonConstructor]
        public User(string Name, string LastName, Property Property, Account Account, Guid Id)
        {
            this._lastName = LastName;
            this._name = Name;
            this._property = Property;
            this._account = Account;
            this._id = Id;
        }   
        public User(string Name, string LastName, Property Property, Account Account) 
        {
            this._lastName = LastName;
            this._name = Name;
            this._property = Property;
            this._account = Account;
            this._id = Guid.NewGuid();
        }
        public void DepositMoney()
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            this._name = name;
        }
        public string GetName()
        {
            return this._name;
        }

        public void SetProperty(Property property)
        {
            this._property = property;
        }

        public Property GetProperty()
        {
            return this._property;
        }

        public Account GetAccount()
        {
            return this._account;
        }

        public void CreateTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void DoTask(Task task)
        {
            throw new NotImplementedException();
        }

        public void CreateComplain()    
        {
            throw new NotImplementedException();
        }

        public void CreateExpense() 
        { 
            throw new NotImplementedException(); 
        }

        public void DeleteExpense()
        {
            throw new NotImplementedException();
        }





    }
}
