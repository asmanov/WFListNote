using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFListNote
{
    public class Phone
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public Phone() { }

        public Phone(string firstName, string lastName, string phone1, string phone2)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone1 = phone1;
            Phone2 = phone2;
        }
    }
}
