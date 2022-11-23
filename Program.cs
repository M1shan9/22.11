using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
   float a, b, deg;

   try
   {
    Console.WriteLine("Enter the a:");
    a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the b:");
    b = Convert.ToInt32(Console.ReadLine());

    deg = (float)Math.Max(a, b);
    Console.WriteLine("result max = " + deg);
   }

   catch
   {
    Console.WriteLine("exception!");
   }

   finally
   {
    Console.WriteLine("block finally");
   }
   Console.ReadLine();
  }
    }
}
