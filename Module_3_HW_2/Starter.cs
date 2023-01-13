using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_HW_2
{
    public static class Starter
    {
        public static void DisplayGroupContacts(
            string branchName,
            List<ContactGroup> contactGroups)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(branchName);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var group in contactGroups)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[{group.GroupName}]");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var contact in group.Contacts)
                {
                    Console.WriteLine(
                        $"{contact.Name} - " +
                        $"{contact.Phone} - {contact.Email}");
                }
            }
        }

        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ENGLISH
            var cultureEng = new CultureInfo("en-US");
            var contactManagerEng = new ContactManager(cultureEng);
            var contactsEng = new List<Contact>
             {
                    new Contact(
                        "Aohn Doe",
                        "123-456-7890",
                        "aohndoe@email.com"),
                    new Contact(
                        "Bane Smith",
                        "098-765-4321",
                        "banesmith@email.com"),
                    new Contact(
                        "Cob Johnson",
                        "111-111-1111",
                        "cobjohnson@email.com"),
                    new Contact(
                        "Daryl Dixon",
                        "111-112-1111",
                        "daryl@email.com"),
                    new Contact(
                        "2D2R",
                        "222-222-2212",
                        "R2D2@email.com"),
                    new Contact(
                        "3PCO",
                        "333-333-3333",
                        "3PCO@email.com"),
                    new Contact(
                        "Ян",
                        "222-212-2222",
                        "who@email.com"),
                    new Contact(
                        "Анна",
                        "222-221-2222",
                        "anna@email.com"),
             };

            foreach (var contact in contactsEng)
            {
                contactManagerEng.AddContact(contact);
            }

            // UKRAINIAN
            var cultureUkr = new CultureInfo("uk-UA");
            var contactManagerUkr = new ContactManager(cultureUkr);
            var contactsUkr = new List<Contact>
            {
                    new Contact(
                        "Геннадий Петренко",
                        "+380934567890",
                        "gena@email"),
                    new Contact(
                        "Ан Панов",
                        "+380987654321",
                        "ivan.ivanov@email.com"),
                    new Contact(
                        "Бександр Петров",
                        "+380441234567",
                        "oleksandr.petrov@email.com"),
                    new Contact(
                        "Врія Сидорова",
                        "+380934567890",
                        "maria.sidorova@email.com"),
                    new Contact(
                        "Гай Юлій Цезар",
                        "+380916767890",
                        "zes.com"),
                    new Contact(
                        "John Rambo",
                        "+380937537890",
                        "john@gmail.com"),
                    new Contact(
                        "838",
                        "+380934124890",
                        "taxi@gmail.com"),
                    new Contact(
                        "575",
                        "+380932467890",
                        "taxi@gmail.com"),
            };

            foreach (var contact in contactsUkr)
            {
                contactManagerUkr.AddContact(contact);
            }

            DisplayGroupContacts(
                "English contacts",
                contactManagerEng.GetContactGroups());
            DisplayGroupContacts(
                "\n\nUkrainian contacts",
                contactManagerUkr.GetContactGroups());
            Console.ReadKey();
        }
    }
}
