using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> godine = new List<int>() { 2009, 2010, 2011 };
            try
            {
                Console.WriteLine(godine[2]);
                Console.WriteLine(godine[5]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
