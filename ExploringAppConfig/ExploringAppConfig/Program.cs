using System;
using System.Configuration;

namespace ExploringAppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Raphael Kuttruf";
            Console.WriteLine($"Hello {userName}");

            // read settings
            string userNameInAppConfig = ConfigurationManager.AppSettings["UserName"];
            string userIDInAppConfig = ConfigurationManager.AppSettings["UserID"];
            Console.WriteLine($"Your configured user name is: {userNameInAppConfig}");
            Console.WriteLine($"Your configured user ID is: {userIDInAppConfig}");

            // Change setting at runtime and save it
            Console.WriteLine("I can simplify your settings for you...");
            int userID = Int32.Parse(userIDInAppConfig);
            ConfigurationManager.AppSettings["UserID"] = userID.ToString();

            // read again
             userNameInAppConfig = ConfigurationManager.AppSettings["UserName"];
             userIDInAppConfig = ConfigurationManager.AppSettings["UserID"];
            Console.WriteLine($"Your configured user name is: {userNameInAppConfig}");
            Console.WriteLine($"Your configured user ID is: {userIDInAppConfig}");

            Console.ReadLine();
        }
    }
}
