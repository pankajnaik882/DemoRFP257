using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Username
    {
        public static void DisplayUsername()
        {
            Console.WriteLine("Print the Username");
            String username = Console.ReadLine();

            int val = username.Length;
            Console.WriteLine("The Number of Characters are " + val);

            if (username.Length > 3 && username.Length < 5)
            {
                Console.WriteLine("Hello " + username + " How are you ?");
                Console.WriteLine("Hello {0}, How are you ? ", username);
            }
            else if (username.Length > 5)
            {
                Console.WriteLine("The name is having more than 5 Characters");
 
            }
            else
            {
                Console.WriteLine("The name is not having minimum 3 characters");
            }
        }

    }
}
