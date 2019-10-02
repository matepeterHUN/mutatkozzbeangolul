using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bemutatkozas_angolul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a vezetékneved!");
            string vn=Console.ReadLine();
            Console.WriteLine("Kérem a keresztneved!");
            string kn = Console.ReadLine();
            Console.WriteLine("Hány éves vagy?");
            int k=int.Parse(Console.ReadLine());
            Console.WriteLine("Mi a városod neve?");
            string v = Console.ReadLine();
            Console.Write("My name is {0} {1}.",kn,vn);
            Console.Write("I am {0} years old.",k);
            Console.WriteLine("I live in {0}.",v);
            Console.ReadKey();



        }
    }
}
