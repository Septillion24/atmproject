using System.Reflection;
using System.Xml;

class Program

{
    static void Main(string[] args)
    {

        BankDatabase bankDatabase = BankDatabase.Instance;
        Account? currentUserAccount;

        Console.WriteLine("Hello and welcome to Wells Farwood");

        while (true)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                if (name == "" || name == null)
                {
                    Console.WriteLine("Invalid name");
                    continue;
                }
                Console.WriteLine("Enter pin");
                string userinput = Console.ReadLine();
                int pin;
                try
                {
                    pin = int.Parse(userinput);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid pin");
                    continue;
                }
                if (bankDatabase.CreateAccount(name, pin))
                {
                    Console.WriteLine("Success!");
                }
                else
                {
                    Console.WriteLine("This account name already exists!");
                }





            }
            if (input == "2")
            {
                Console.WriteLine("Insert Username: ");
                string inputUserName = Console.ReadLine();
                Console.WriteLine("Insert Password: ");
                int inputPassword;
                if(!int.TryParse(Console.ReadLine(), out inputPassword))
                {
                    Console.WriteLine("Make sure to input an intger. \n");
                    continue;
                }
                if(bankDatabase.tryCheckLogin(inputUserName, inputPassword, out currentUserAccount))
                {
                    Console.WriteLine("Login success!");
                }


            }
        }
    }
}