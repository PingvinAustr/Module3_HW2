using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_HW_2
{
    public class ContactCollection
    {
        private List<Contact> _contacts;
        private CultureInfo _culture;
        private Alphabet _alphabet;
        private List<ContactGroup> _contactGroups;

        public ContactCollection(CultureInfo culture)
        {
            _contacts = new List<Contact>();
            _culture = culture;
            _alphabet = new Alphabet(_culture);
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            GroupContacts();
        }

        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
            GroupContacts();
        }

        public List<ContactGroup> GetContactGroups()
        {
            GroupContacts();
            return _contactGroups;
        }

        public Contact FindContact(string name)
        {
            return _contacts.FirstOrDefault(c => c.Name == name);
        }

        public Contact GetContact(string name)
        {
            return _contacts.FirstOrDefault(c =>
            c.Name.Equals(
                name,
                StringComparison.CurrentCultureIgnoreCase));
        }

        public List<Contact> SearchContacts(string searchTerm)
        {
            return _contacts.Where(c =>
            c.Name.Contains(searchTerm)).ToList();
        }

        private void GroupContacts()
        {
            var contactGroups = new Dictionary<string, ContactGroup>();
            foreach (var contact in _contacts)
            {
                var firstLetter = _alphabet.GetFirstLetter(contact.Name);
                var groupName = _alphabet.GetGroupName(firstLetter);
                if (!contactGroups.ContainsKey(groupName))
                {
                    contactGroups[groupName] = new ContactGroup(groupName);
                }

                contactGroups[groupName].AddContact(contact);
            }

            _contactGroups = contactGroups
                .Values.OrderBy(x => x.GroupName).ToList();
        }
    }
}
