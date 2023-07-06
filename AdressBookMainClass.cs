namespace AddressBookProblem
{
    public class AdressBookMainClass
    {
        List<Contact> con = new List<Contact>();
        Contact obj = new Contact();
        Dictionary<string, List<Contact>> AddressBookDic = new Dictionary<string, List<Contact>>();
        public void AddDetails()
        {
            List<Contact> con = new List<Contact>();
            Contact obj = new Contact();

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
            
        }

        //FOR EDIT CONTACT
        public void EditContact()
        {
            Console.WriteLine("Enter the first name of the person to update:");
            string name = Console.ReadLine();

            Contact contactToUpdate = con.FirstOrDefault(c => c.firstName.Equals(name, StringComparison.OrdinalIgnoreCase));

           if (contactToUpdate == null)
           {
             Console.WriteLine("Contact not found!");
                return;
           }

           Console.WriteLine("For update:");
           Console.WriteLine("a)First Name \n b)Last Name \n c)Mobile Number \n d)Address \n e)City \n f)State \n g)Zip \n h)Email Id");
           char update = Convert.ToChar(Console.ReadLine());
           switch (update)
           {
              case 'a':
                  {
                        Console.WriteLine("Please enter the new first name:");
                        string value = Console.ReadLine();
                        contactToUpdate.firstName = value;
                       Console.WriteLine("First name updated.");
                       break;
                  }
              case 'b':
                  {
                       Console.WriteLine("Please enter the new last name:");
                       string value = Console.ReadLine();
                       contactToUpdate.lastName = value;
                       Console.WriteLine("Last name updated.");
                       break;
                  }
              case 'c':
                  {
                      Console.WriteLine("Please enter the new mobile number:");
                      string value = Console.ReadLine();
                      contactToUpdate.mobileNumber = value;
                      Console.WriteLine("Mobile number updated.");
                      break;
                  }
              case 'd':
                  {
                        Console.WriteLine("Please enter the new address:");
                        string value = Console.ReadLine();
                        contactToUpdate.address = value;
                        Console.WriteLine("Address updated.");
                        break;
                  }
              case 'e':
                  {
                       Console.WriteLine("Please enter the new city:");
                       string value = Console.ReadLine();
                       contactToUpdate.city = value;
                       Console.WriteLine("City updated.");
                        break;
                  }
               case 'f':
                  {
                        Console.WriteLine("Please enter the new state:");
                        string value = Console.ReadLine();
                        contactToUpdate.state = value;
                        Console.WriteLine("State updated.");
                        break;
                  }
              case 'g':
                  {
                       Console.WriteLine("Please enter the new zip:");
                       string value = Console.ReadLine();
                       contactToUpdate.zip = value;
                       Console.WriteLine("Zip updated.");
                       break;
                  }
               case 'h':
                  {
                       Console.WriteLine("Please enter the new email id:");
                       string value = Console.ReadLine();
                       contactToUpdate.email = value;
                       Console.WriteLine("Email id updated.");
                       break;
                  }
                default:
                  {
                        Console.WriteLine("No changes made.");
                        break;
                  }
           }
        }

        //FOR DELETE

        public void DeleteContact()
        {
            Console.WriteLine("Enter the First Name of the contact to be deleted:");
            string name = Console.ReadLine();

            Contact contactToDelete = con.FirstOrDefault(c => c.firstName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contactToDelete == null)
            {
                Console.WriteLine("Contact not found!");
               return;
            }

            con.Remove(contactToDelete);
            Console.WriteLine("Contact deleted successfully!");
        }


        // FOR DISPLAY
        public void DisplayContact()
        {

            foreach (var key in AddressBookDic.Keys)
            {
                Console.WriteLine($"key is {key}");

                Console.WriteLine("The Details you stored in Address Book:");

                List<Contact> con = AddressBookDic[key];
                foreach (var change in con)
                {

                    Console.WriteLine(change.ToString());
                }

            }

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("!!!!!!Welcome to Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AdressBookMainClass person = new AdressBookMainClass();
            bool flag = true;
            int n;
            while (flag == true)
            {
                Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine("No. of contact you wana add or otherwise press 1:");
                n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {

                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("Please add new contact details: ");
                                person.AddDetails();
                                person.DisplayContact();
                                break;
                            }
                        case 0:
                            {
                                Console.WriteLine("Do you Want to Edit(1) or Delete(2) your Contact :");

                                int option1 = int.Parse(Console.ReadLine());
                                switch (option1)
                                {
                                    case 1:
                                        {
                                             person.EditContact();
                                            //person.AddDetails();
                                            person.DisplayContact();
                                            flag = true;
                                            break;

                                        }
                                    case 2:
                                        {

                                            person.DeleteContact();
                                            person.DisplayContact();
                                            flag = false;
                                            break;

                                        }


                                    default:
                                        {
                                            Console.WriteLine("press any key for exit:");
                                            flag = false;
                                            break;

                                        }

                                }
                                break;
                            }
                    }


                }
            }


        }
    }
}