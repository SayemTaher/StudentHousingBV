using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

//#######################################
//info 
//#######################################
// Convaetion of names chnage to add _. to private names due to need for more varibles of the same stuff
// and keep encapsulation form, this change is cosue by implemetaion of .json 
//                                                           ~Michal


namespace Student_Housing
{
    public class Account
    {
        private string _email;
        private string _password;
        private Enumeration.Role _role;

       //Created for serialization for json
        public string Email => _email;
        public string Password => _password;
        public Enumeration.Role Role => _role;  
        
        [JsonConstructor]
        public Account(string email, string password, Enumeration.Role role)
        {
            this._email = email;
            this._password = password;
            this._role = role;

        }

        public void SetEmail(string email)
        {
            this._email = email;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetPassword(string password)
        {
            this._password = password;
        }

        public string GetPassword()
        {
            return _password;
        }
    }
}
