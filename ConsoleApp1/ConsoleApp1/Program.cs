using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String First = ("");
            String Last = ("");
            String Street = ("");
            String zip = ("");
            String phone = ("");
            String email = ("");
            int age = 0;
            WriteLine("Hello what is your first name");
            First = ReadLine();
            WriteLine("Hello what is your last name");
            Last = ReadLine();
            WriteLine("What is your age");
            age = int.Parse(ReadLine());
            WriteLine("What is your address");
                Street = ReadLine();
            WriteLine("What is your zip code");
                zip = ReadLine();
            WriteLine("What is your Phone Number");
            phone = ReadLine();
            WriteLine("What is your Email address");
            email = ReadLine();

            WriteLine(Last + "," + First + "," + Street + "," + zip + "," + phone + "," );
            WriteLine(" age=" + age);
            WriteLine(Street + "," + zip);
            WriteLine("phone number is " + phone);
            ReadLine();
            
            
        }
    }
}

