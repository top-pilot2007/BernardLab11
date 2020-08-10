using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BernardLab11
{
    public abstract class  Movie
    {
        public  virtual string Title()
        {
            
            return _title();
            
        }
        public  virtual string Category (string userCategory)
        {
            _category = userCategory;
            return _category;
           
        }

        //private string _title;
        private string _category;

        private string _title()
        {
            List<string> _category = new List<string>();
            foreach (string item in _category)
             { Console.WriteLine(item); };
            return "";
            
        }

        public static bool UserContinueSelection { get; set; } = true;
        public static void UserContinue()
        {
            Console.Write("Continue? (y/n): ");
            var userChoice = Console.ReadLine();

            if (userChoice.Contains("Y", StringComparison.InvariantCultureIgnoreCase))
            {
                UserContinueSelection = true;
            }
            else
            {
                UserContinueSelection = false;
            }
        }
    }
}
