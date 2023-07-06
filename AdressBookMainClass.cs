namespace AddressBookProblem
{
    public class AdressBookMainClass
    {
        List<Contact> con = new List<Contact>();
        Contact obj = new Contact();
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
        }
        public void DisplayContact()
        {

            foreach (var change in con)
            {
                Console.WriteLine(change.ToString());
            }

        }
        public void EditContact()
        {
            Console.WriteLine("Enter the name of the person for update:");
            string name = Console.ReadLine();

            foreach (var data in con)
            {
                if (data.firstName == name)
                {

                    Console.WriteLine("For update:");
                    Console.WriteLine("a)First Name \n b)LastName \n c)MobileNumber \n d) Address \n e)City \n f)State \n g)Zip \n h)EmailId");
                    char update = Convert.ToChar(Console.ReadLine());
                    switch (update)
                    {
                        case 'a':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.firstName = value;
                                Console.WriteLine("First Name updated...");
                                break;
                            }
                        case 'b':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.lastName = value;
                                Console.WriteLine("Last name updated...");
                                break;
                            }
                        case 'c':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.mobileNumber = value;
                                Console.WriteLine(" Mobile No updated...");
                                break;
                            }
                        case 'd':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.address = value;
                                Console.WriteLine("Address updated....");
                                break;
                            }
                        case 'e':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.city = value;
                                Console.WriteLine("City updated...");
                                break;
                            }
                        case 'f':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.state = value;
                                Console.WriteLine("State updated...");
                                break;
                            }
                        case 'g':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.zip = value;
                                Console.WriteLine("Zip updated....");
                                break;
                            }
                        case 'h':
                            {
                                Console.WriteLine("Please Enter the new value:");
                                string value = Console.ReadLine();
                                data.email = value;
                                Console.WriteLine("Emailid updated...");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("NO Changes");
                                break;
                            }
                    }
                }

            }
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("!!!!!!Welcome to Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AdressBookMainClass person = new AdressBookMainClass();

            bool flag = true;
            while (flag == true)
            {
                Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
                int option = int.Parse(Console.ReadLine());

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
                            Console.WriteLine("Do you Want to Edit your Contact YES(1) or NO(0):");
                            int option1 = int.Parse(Console.ReadLine());
                            switch (option1)
                            {
                                case 1:
                                    {
                                        person.EditContact();
                                        person.DisplayContact();
                                        flag = false;
                                        break;

                                    }
                                case 0:
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