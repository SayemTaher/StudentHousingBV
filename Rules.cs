using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    internal class Rules
    {
        private Property property;
        private string content;

        public string GetContent()
        {
            return content;
        }
        public void SetContent (string content)
        {
            this.content = content;
        }
        public Property GetProperty()
        {
            return property;
        }
        public void SetProperty(Property property)
        {
            this.property = property;
        }
    }
}
