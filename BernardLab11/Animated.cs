using System;
using System.Collections.Generic;
using System.Text;

namespace BernardLab11
{
    public class Animated : Movie
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

            
                List<string> animatedList = new List<string>();
                {
                    animatedList.Add("Afro Samurai");
                    animatedList.Add("Lion King");
                    animatedList.Add("The Princess and the Frog");
                    animatedList.Add("Space Jam");
                    animatedList.Add("Osmosis Jones");
                    animatedList.Add("Shark Tale");
                    animatedList.Add("Madagascar");
                    animatedList.Add("Shrek");
                    animatedList.Add("Mulan");
                    animatedList.Add("VeggieTales");
                }
                foreach (string item in animatedList)
                { Console.WriteLine(item); }
                return "";
        }
    }
}
