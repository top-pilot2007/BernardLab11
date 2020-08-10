using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BernardLab11
{
    public class Scifi : Movie
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
            Console.WriteLine("SciFi");
            return " ";
        }

        private string _title()
        {
            List<string> scifiList = new List<string>
            {
                "Black Panther",
                "Blade",
                "Pitch Black",
                "The Brother from Another Planet",
                "Captain EO",
                "Space Is the Place",
                "The Meteor Man",
                "Black Orpheus",
                "Aliens",
                "The Matrix"
            };

            foreach (string item in scifiList)
                {Console.WriteLine(item);}
            return "";
        }

        
    }
    }


        //List<_title> scifiList = new List<_title>();

        //scifiList.Add("Star Wars");
            //"2001: A Space Odyssey",
            //"E.T. The Extra-terrestrial",
            //"A Clockwork Orange",
            //"Close Encounters of the Third Kind" };




    //public Scifi(string title, string category)
    //{
    //    Title = title;
    //    Category = category;
    //}
