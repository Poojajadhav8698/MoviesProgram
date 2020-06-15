using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> movies = new List<string>();
            movies.Add("URL#5 ");
            movies.Add("GullBoy#7 ");
            movies.Add("Badla#3 ");
            movies.Add("KabiSingh#5");
            movies.Add("Output ");

            List<int> value = new List<int>();
            
            foreach (string MV in movies)
            {
               
            Console.WriteLine(MV[MV.LastIndexOf("#")+1]);

            }

            Console.ReadKey();
        }
    }
}
