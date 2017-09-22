using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneSearchRestaurants
{
    public class Intrest
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public static class Repository
    {
        public static Intrest Get(string name)
        {
            return GetAll().SingleOrDefault(x => x.Name.Equals(name));
        }
        public static List<Intrest> GetAll()
        {
            return PopulateList();
        }

        private static List<Intrest> PopulateList()
        {
            return new List<Intrest>
        {
        new Intrest { Name = "Abc Restaurant", Address = "Viman nagar,Pune"},
        new Intrest { Name = "Def Restaurant", Address ="Kharadi,Pune"},
        new Intrest { Name = "Hij Restaurant", Address = "Wadgaon Sheri,Pune"},
        };
        }
    }
}
