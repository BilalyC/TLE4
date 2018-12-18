using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string>();
            shopping.Add("Carottes");
            shopping.Add("Oignons");
            shopping.Add("Pommes de terre");
            shopping.Add("Salade");
            shopping.Add("Tomate");

            //List<string> shopping = new List<string> {"Carottes", "Oignons", "Pommes de terre", "Salade", Tomate"};

            foreach (string element in shopping)
            {
                Console.WriteLine(element);
            }
        }
    }
}
