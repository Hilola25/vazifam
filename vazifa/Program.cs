using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vazifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("10 lik sonni kiriting: ");
            int s=int.Parse(Console.ReadLine());

            string natija = "";

            while (s > 0)
            {
                int q = s % 2;
                natija = q + natija;
                s /= 2;
            }

            Console.WriteLine("2 lik natijasi: "+ natija);
            Console.ReadKey();
        }
    }
}
