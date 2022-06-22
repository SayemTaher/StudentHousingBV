using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    internal class Complain
    {
        private Property property;
        private string content;
        private DateTime date;

        public Property GetProperty()

        {
            return property;
        }

        public void SetProperty(Property property)
        {
            this.property = property;
        }

        public string GetContent()
        {
            return content;
        }
        public void SetContent(string content)
        {
            this.content = content;
        }

        public DateTime GetDateTime()
        {
            return date;
        }

        public void SetDateTime(DateTime date)
        {
            this.date= date;
        }
         
    }
}
