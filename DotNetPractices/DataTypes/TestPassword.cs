using System;

namespace DotNetPractices.DataTypes
{
    public class TestPassword
    {
        public static void PasswordTest()
        {
            string username, password;
            int ctr = 0;
            Console.Write("\n\nCheck username and passwrod");
            Console.Write("N.B.: Default username and password is: username and password\n");
            Console.Write("--------------------------------\n");

            do
            {
                Console.Write("Input a username:");
                username = Console.ReadLine();

                Console.Write("Input a password:");
                password = Console.ReadLine();

                ctr++;
            } while ((username != "username" && password != "password") && (ctr != 3));
            if (ctr == 3)
            {
                Console.Write("\nLogin attemp more than three times. Try later!\n\n");
            }
            else
                Console.Write("\nPassword entered successfully!\n\n");
        }
    }
}