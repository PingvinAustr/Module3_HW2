using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_HW_2
{
    public class ContactGroup
    {
        public ContactGroup(string groupName)
        {
            GroupName = groupName;
            Contacts = new List<Contact>();
        }

        public string GroupName { get; set; }
        public List<Contact> Contacts { get; set; }
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
            OrderContacts();
        }

        public void RemoveContact(Contact contact)
        {
            Contacts.Remove(contact);
        }

        public void OrderContacts()
        {
            Contacts = Contacts.OrderBy(x => x.Name).ToList();
        }
    }
}
