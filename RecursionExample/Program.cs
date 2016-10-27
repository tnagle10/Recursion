using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Fact(2));

        }


        static int Fact(int x)
        {
            if (x == 1)
            
                return 1;
            int output = x * Fact(x - 1);
            Console.WriteLine(output);
            
                return x * Fact(x - 1);

        }


    }
}
