using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello");
                int i, j, k;
                    try
                {
                    string s1=null;
                    i = 10;
                    j = 2;
                    k = i / j;
                    if (s1 == null)
                    {
                        throw new ArgumentNullException("s1 is null");
                    }
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("In the inner try catch");
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Outer try catch called.....");
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Outer Finally fired.....");
            }
            Console.Read();
        }
    }
}
