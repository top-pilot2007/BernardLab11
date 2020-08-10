using System;
using System.Collections.Generic;
using System.Text;

namespace BernardLab11
{
    public class Horror : Movie
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
            Console.WriteLine("Horror");
            return " ";
        }
        private string _title()
        {


            List<string> horrorList = new List<string>
            {
                "Get Out",
                "Blacula",
                "Vampire in Brooklyn",
                "Candyman",
                "Tales from the Hood",
                "Us",
                "Purge",
                "Spawn",
                "A Haunted House",
                "Scary Movie"
            };

            foreach (string item in horrorList)
                { Console.WriteLine(item); }
            return "";
        }
    }
}
