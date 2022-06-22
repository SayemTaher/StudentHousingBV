using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Student_Housing
{
    public class Event
    {
        private User _student;
        private DateTime _startDate;
        private DateTime _endDate;
        private string _description;
        private Property _property;
        private string _name;

        public User Student => _student;
        public DateTime StartDate => _startDate;     
        public DateTime EndDate => _endDate;
        public string Description => _description;
        public Property Property => _property;
        public string NameOfEvent => _name;


        [JsonConstructor]
        public Event(string NameOfEvent, User Student, DateTime StartDate, DateTime EndDate, string Description, Property Property)
        {
            this._description = Description;
            this._student = Student; 
            this._startDate = StartDate;
            this._endDate = EndDate;
            this._property = Property;
            this._name = NameOfEvent;
        }

        public override string ToString()
        {
            string[] result = { _name, _student.Name, _startDate.ToString("dd/MM/yyyy"), _endDate.ToString("dd/MM/yyyy"), _description, _property.ToString() };
            return string.Join("|", result);
        }

        public void SetStudent(User student)
        {
            this._student = student;
        }

        public User GetStudent()
        {
            return this._student;
        }

        public void SetStartDate(DateTime startDate)
        {
            this._startDate = startDate;
        }

        public DateTime GetStartDate()
        {
            return this._startDate;
        }

        public void SetEndDate(DateTime endDate)
        {
            this._endDate = endDate;
        }

        public DateTime GetEndDate()
        {
            return _endDate;
        }
        
        public void SetDescription(string description)
        {
            this._description = description;
        }

        public string GetDescription()
        {
            return this._description;    
        }


    }
}
