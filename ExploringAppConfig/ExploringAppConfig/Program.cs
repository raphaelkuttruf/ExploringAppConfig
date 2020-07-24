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


            Console.WriteLine(Properties.Settings.Default.Test_ID);
            Properties.Settings.Default.Test_ID = 555;
            Console.WriteLine(Properties.Settings.Default.Test_ID);
            Properties.Settings.Default.Save();

            if (Properties.MoreSettings.Default.I_Want_More)
            {
                Properties.MoreSettings.Default.I_Want_More = false;
                Console.WriteLine(Properties.MoreSettings.Default.More);
            }
            else
            {
                Console.WriteLine("Do you want more cookies?");
                Properties.MoreSettings.Default.I_Want_More = true;
            }
            Properties.MoreSettings.Default.Save();

            Console.ReadLine();

        }
    }
}
