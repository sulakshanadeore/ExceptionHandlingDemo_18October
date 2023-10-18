using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MathsCalculations
    {

        public string SayHello(string name)
        {
            string op = null;
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Didn't receive the name input");
                //Console.WriteLine("didnt recieve the name-- name is null or empty");
            }
            else
            {
                op = "Good day, " + name;

            }
            return op;
        }
        public string Greet(string name)
        {
            string op = null;
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                     throw new ArgumentNullException("Didn't receive the name input");
                    //Console.WriteLine("didnt recieve the name-- name is null or empty");
                }
                else
                {
                    op= "Good day, " + name;

                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("From library= " + ex.Message);
                Console.WriteLine("didnt receive valid input for name");
            }
            return op;
        }
        public void Divide(int? i, int? j)
        {
            int?  k;
            try
            {
                k = i / j;
                Console.WriteLine(k);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You entered the second number as 0 and hence the exception");
                //Console.WriteLine($"From library ={ex.StackTrace}");
                //where did the exception occur along with line number
                //Console.WriteLine($"From library = {ex.Source}");
                //Name of the program/app where the app occured
                //Console.WriteLine($"From library= {ex.Message}");
                //Message of exception
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(  "Some error occured....");

            }


        }

    }
}
