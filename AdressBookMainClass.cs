namespace AddressBookProblem
{
    public class AdressBookMainClass
    {
       
        Dictionary<string, List<Contact>> AddressBookDic = new Dictionary<string, List<Contact>>();
        public void AddDetails()
        {
            List<Contact> con = new List<Contact>();
            Contact obj = new Contact();

            Console.WriteLine("Enter First Name: ");
            obj.firstName = Console.ReadLine();
            //Check for no duplicate Entry
            if (AddressBookDic.ContainsKey(obj.firstName))
            {
                Console.WriteLine("Duplicate Entries are not possible");
                return;
            }

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
            AddressBookDic.Add(obj.firstName, con);

        }

        public void SearchPersonInCityOrState()
        {
            Console.WriteLine("Enter City or State name to search Person: ");
            string cityOrStateName = Console.ReadLine();

            var result = AddressBookDic.Values.SelectMany(x => x.Where(y => y.city.ToLower().Equals(cityOrStateName) || y.state.ToLower().Equals(cityOrStateName)));

            if (result.Count() == 0)
            {
                Console.WriteLine($"No Person found in {cityOrStateName}");
            }
            else
            {
                Console.WriteLine($"Persons found in {cityOrStateName}");
                foreach (var contact in result)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }

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
            bool flag = true;
            Console.WriteLine("!!!!!!Welcome to Updated Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AdressBookMainClass person = new AdressBookMainClass();

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
                            flag = true;
                            break;

                        }
                    case 0:
                        {
                            Console.WriteLine("Do you want to search Person in a City or State YES(1) or NO(0)");
                            int option1 = int.Parse(Console.ReadLine());

                            switch (option1)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Please Enter city or state name: ");
                                        person.SearchPersonInCityOrState();
                                        flag = true;
                                        break;
                                    }
                                case 0:
                                    {
                                        Console.WriteLine("press any key for exit:");
                                        flag = false;
                                        break;
                                    }

                                default:
                                    Console.WriteLine("Invalid option selected");
                                    break;
                            }
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