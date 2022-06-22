using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Student_Housing
{
    public class Property
    {
        private string _name;
        private string _location;

        public string Name => _name;
        public string Location => _location;

        [JsonConstructor]

        public Property(string Name, string Location)
        {
            this._name = Name;
            this._location = Location;
        }
        public void SetName(string name)
        {
            this._name = name;
        }
        public override string ToString()
        {
            return _name;
        }

        public void  SetLocation(string location)
        {
            this._location=location;
        }
        public string getLocation()
        {
            return _location;
        }
           
        
               
    }
}
