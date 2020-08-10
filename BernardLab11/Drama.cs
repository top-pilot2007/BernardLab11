using System;
using System.Collections.Generic;
using System.Text;

namespace BernardLab11
{
    public class Drama : Movie
    {
        public override string Title()
        {

            return _title();

        }
        public override string Category(string userCategory)
        {
            return _category();

        }
        private string _category()
        {
            Console.WriteLine("Drama");
            return " ";
        }
        private static string _title()
        {


            List<string> dramaList = new List<string>
            {
                "Malcolm X",
                "Hidden Figures",
                "Selma",
                "42",
                "Glory",
                "Beasts of No Nation",
                "The Color Purple",
                "Hotel Rwanda",
                "Ray",
                "Lord of War"
            };
            foreach (string item in dramaList)
                { Console.WriteLine(item); }
            return "";
        }
    }
}
