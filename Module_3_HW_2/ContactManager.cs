using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_3_HW_2
{
    public class ContactManager
    {
        private readonly CultureInfo _culture;
        private readonly ContactCollection _contactCollection;
        public ContactManager(string culture)
        {
            _culture = new CultureInfo(culture);
            _contactCollection = new ContactCollection(_culture);
        }

        public ContactManager(CultureInfo culture)
        {
            _culture = culture;
            _contactCollection = new ContactCollection(_culture);
        }

        public bool AddContact(Contact contact)
        {
            try
            {
                _contactCollection.AddContact(contact);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveContact(string name)
        {
            var contact = _contactCollection.GetContact(name);
            try
                {
                    _contactCollection.RemoveContact(contact);
                    return true;
                }
                catch
                {
                    return false;
                }
        }

        public Contact FindContact(string name)
        {
            return _contactCollection.FindContact(name);
        }

        public List<ContactGroup> GetContactGroups()
        {
            return _contactCollection.GetContactGroups();
        }
    }
}