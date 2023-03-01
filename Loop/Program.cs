using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 6;

            
            for (int i = 1; i <= rows; ++i)
            {

                
                for (int j = 1; j <= i; ++j)
                {
                    Console.WriteLine(j + " ");
                }
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}
   
