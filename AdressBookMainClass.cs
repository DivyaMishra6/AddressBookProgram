namespace AddressBookProblem
{
    class AdressBookMainClass
    {
        // Define a list to store the contacts
        List<Contact> con = new List<Contact>();
        Contact obj = new Contact();

        // AddDetails method to add new contact to the list
        public void AddDetails()
        {
            Console.WriteLine("Enter First Name: ");
            obj.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            obj.lastName = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            obj.mobileNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            obj.address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            obj.city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            obj.state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            obj.zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            obj.email = Console.ReadLine();

            con.Add(obj);
            Console.WriteLine("Contact added successfully!");

        }

        // DisplayContact method to display all contacts in the address book
        public void DisplayContact()
        {
            if (con.Count == 0)
            {
                Console.WriteLine("Address book is empty!");
                return;
            }

            // Sort the contactList alphabetically by Person's name
            con.Sort((x, y) => string.Compare(x.firstName, y.firstName));

            // Display the sorted contact list
            Console.WriteLine("Address Book:");
            Console.WriteLine("===================================");
            foreach (var contact in con)
            {
                Console.WriteLine(contact.ToString());
                Console.WriteLine("-----------------------------------");
            }
        }

        // Main method to execute the program
        public static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("!!!!!!Welcome to Updated Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AdressBookMainClass addressBook = new AdressBookMainClass();

            while (flag == true)
            {
                Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            // Add new contact
                            Console.WriteLine("Please add new contact details: ");
                            addressBook.AddDetails();
                            addressBook.DisplayContact();
                            break;
                        }
                    case 0:
                        {
                            // Display all contacts and exit the program
                            addressBook.DisplayContact();
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            flag = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }
        }

    }
}