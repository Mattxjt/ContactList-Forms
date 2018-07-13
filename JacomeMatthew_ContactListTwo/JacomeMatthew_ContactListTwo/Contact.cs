using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JacomeMatthew_ContactListTwo
{
   public class Contact
    {
        // Properties
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string email;

      
        // Override to string
        public override string ToString()
        {
            return firstName + " " + lastName + " " + phoneNumber;
        }
    }
}
