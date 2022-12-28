
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first number:");
            int n1=int.Parse(Console.ReadLine());
            Console.Write("Enter your last number:");
            int n2 =int.Parse(Console.ReadLine());
            int m =0;
            for (int i = n1; i <= n2; i++)
            {
                for (int j=1 ; j <=i ;j++)
                {
                    if (i % j == 0)
                    { m++; 
                    
                    }
                    
                }
                if (m == 2)
                {
                    Console.WriteLine(i);
                    m = 0;
                }
                if( m != 2)
                {
                    m = 0;
                    continue;
                }
            }
            Console.ReadLine();
        }
    }
}
