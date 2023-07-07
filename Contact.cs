using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mobileNumber { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}\nMobile Number: {mobileNumber}\nAddress: {address}\nCity: {city}\nState: {state}\nZip: {zip}\nEmail: {email}\n";
        }
    }
}
