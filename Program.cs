using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practisingrandomlist
{
    class Program
    {
        static void Main(string[] args)
        {
           int mylist;
            Random generator = new Random();
           
            for (int i = 0; i < 10; i++ )
            {
                mylist = Convert.ToInt32(generator.NextDouble() * 20);
                Console.WriteLine("{0}",mylist);
            }

                Console.ReadLine();
        }
    }
}
