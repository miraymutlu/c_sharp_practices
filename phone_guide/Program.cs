using System;
using System.Collections.Generic;
using System.Linq;

namespace phone_guide;

class Contact
{
    public string PhoneNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}
class Program
{
    static List<Contact> contacts = new List<Contact>();
    static Contact AddPhoneNumber()
    {
        Console.WriteLine("Please enter the name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter the surname: ");
        string surname = Console.ReadLine();
        Console.WriteLine("Please enter the phone number: ");
        string phoneNumber = Console.ReadLine();

        Contact contact = new Contact
        {
            PhoneNumber = phoneNumber,
            Name = name,
            Surname = surname
        };

        return contact;
    }

    static void DeletePhoneNumber()
    {
        Console.WriteLine("Please enter the name and surname that you want to delete: ");
        string input = Console.ReadLine();
        int index = contacts.FindIndex(contact => $"{contact.Name} {contact.Surname}" == input);

        if (index != -1)
        {
            Console.WriteLine($"{input} is about to be deleted, do you confirm? (y/n)");
            string confirm = Console.ReadLine();
            if (confirm == "y")
            {
                contacts.RemoveAt(index);
                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Deletion cancelled.");
            }
        }
        else
        {
            string chose = "2";
            while (chose == "2")
            {
                Console.WriteLine("Data matching your search criteria could not be found in the directory. Please make a selection.\n" +
                                  "(1) Terminate the deletion\n" +
                                  "(2) Retry");
                chose = Console.ReadLine();
                if (chose == "1")
                {
                    break;
                }
                else if (chose == "2")
                {
                    Console.WriteLine("Please enter the name and surname that you want to delete: ");
                    input = Console.ReadLine();
                    index = contacts.FindIndex(contact => $"{contact.Name} {contact.Surname}" == input);

                    if (index != -1)
                    {
                        Console.WriteLine($"{input} is about to be deleted, do you confirm? (y/n)");
                        string confirm = Console.ReadLine();
                        if (confirm == "y")
                        {
                            contacts.RemoveAt(index);
                            Console.WriteLine("Contact deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Deletion cancelled.");
                        }
                        break;
                    }
                }
            }
        }
    }

    static void UpdatePhoneNumber()
    {
        Console.WriteLine("Please enter the name and surname that you want to update the phone number: ");
        string input = Console.ReadLine();
        int index = contacts.FindIndex(contact => $"{contact.Name} {contact.Surname}" == input);
        if (index != -1)
        {
            Console.WriteLine($"{input} is about to be updated, do you confirm? (y/n)");
            string confirm = Console.ReadLine();
            if (confirm == "y")
            {
                Console.WriteLine("Please enter the new number: ");
                string phoneNumber = Console.ReadLine();
                contacts[index].PhoneNumber = phoneNumber;
                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Updation cancelled.");
            }
        }
        else
        {
            string chose = "2";
            while (chose == "2")
            {
                Console.WriteLine("Data matching your search criteria could not be found in the directory. Please make a selection.\n" +
                                  "(1) Terminate the updation\n" +
                                  "(2) Retry");
                chose = Console.ReadLine();
                if (chose == "1")
                {
                    break;
                }
                else if (chose == "2")
                {
                    Console.WriteLine("Please enter the name and surname that you want to update the phone number: ");
                    input = Console.ReadLine();
                    index = contacts.FindIndex(contact => $"{contact.Name} {contact.Surname}" == input);
                    if (index != -1)
                    {
                        Console.WriteLine($"{input} is about to be updated, do you confirm? (y/n)");
                        string confirm = Console.ReadLine();
                        if (confirm == "y")
                        {
                            Console.WriteLine("Please enter the new number: ");
                            string phoneNumber = Console.ReadLine();
                            contacts[index].PhoneNumber = phoneNumber;
                            Console.WriteLine("Contact updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Updation cancelled.");
                        }
                        break;
                    }
                }
            }
        }
    }

    static void ListPhoneNumbers()
    {
        foreach (Contact contact in contacts)
        {
            Console.WriteLine($"Name: {contact.Name}\n" +
                              $"Surname: {contact.Surname}\n" +
                              $"Phone Number: {contact.PhoneNumber}");
        }
    }

    static void SearchPhoneNumber()
    {
        Console.WriteLine("(1) Search by name and surname: \n" +
                      "(2) Search by phone number: ");
        string input = Console.ReadLine();
        if (input == "1")
        {
            Console.WriteLine("Enter the name and surname that you want to search.");
            string fullName = Console.ReadLine();
            Contact foundContact = contacts.FirstOrDefault(contact => $"{contact.Name} {contact.Surname}" == fullName);
            if (foundContact != null)
            {
                Console.WriteLine($"Name: {foundContact.Name}\n" +
                                  $"Surname: {foundContact.Surname}\n" +
                                  $"Phone Number: {foundContact.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
        else if (input == "2")
        {
            Console.WriteLine("Enter the phone number that you want to search.");
            string phoneNumber = Console.ReadLine();
            Contact foundContact = contacts.FirstOrDefault(contact => contact.PhoneNumber == phoneNumber);
            if (foundContact != null)
            {
                Console.WriteLine($"Name: {foundContact.Name}\n" +
                                  $"Surname: {foundContact.Surname}\n" +
                                  $"Phone Number: {foundContact.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid selection");
        }

    }
    static void Main(string[] args)
    {
        contacts.Add(new Contact { PhoneNumber = "111 111 1111", Name = "Miray", Surname = "Mutlu" });
        contacts.Add(new Contact { PhoneNumber = "222 222 2222", Name = "Defne", Surname = "Mutlu" });
        contacts.Add(new Contact { PhoneNumber = "333 333 3333", Name = "Selma", Surname = "Mutlu" });
        contacts.Add(new Contact { PhoneNumber = "444 444 4444", Name = "Ahmet", Surname = "Mutlu" });
        contacts.Add(new Contact { PhoneNumber = "555 555 5555", Name = "Elif", Surname = "Ataç" });

        Console.WriteLine("Please select the action you want to do:\n" +
                           "(1) Add New Number\n" +
                           "(2) Delete Number\n" +
                           "(3) Update Number\n" +
                           "(4) List Contacts\n" +
                           "(5) Search in Contacts\n");

        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                contacts.Add(AddPhoneNumber());
                break;
            case "2":
                DeletePhoneNumber();
                break;
            case "3":
                UpdatePhoneNumber();
                break;
            case "4":
                ListPhoneNumbers();
                break;
            case "5":
                SearchPhoneNumber();
                break;
            default:
                Console.WriteLine("Invalid selection");
                break;
        }
    }
}
