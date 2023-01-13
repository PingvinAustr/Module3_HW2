using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_HW_2
{
    public class Contact
    {
        private string _name;
        private string _phone;
        private string _email;

        public Contact(string name, string phone, string email)
        {
            _name = name;
            _phone = phone;
            _email = email;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
