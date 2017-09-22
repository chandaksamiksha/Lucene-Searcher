using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneSearchRestaurants
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Intrest> InterestsList = Repository.GetAll();
            Searcher.AddUpdateLuceneIndex(InterestsList);
            Console.WriteLine("\nEnter Key For Index ");
            List<Intrest> searchResult =Searcher.Search(Console.ReadLine()).ToList();
            foreach (var r in searchResult)
            {
            Console.WriteLine($"Name : {r.Name}\nAddress : {r.Address}");
            }
            
           Console.ReadKey(true);
            
        }
    }
}
