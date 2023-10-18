using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionDemo;
namespace ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                MathsCalculations cal = new MathsCalculations();
                Console.WriteLine("Enter no1 ");
                int? no1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter no1 ");
                int? no2 = Convert.ToInt32(Console.ReadLine());

                cal.Divide(no1, no2);

                //string name = "";
                //if (name=="")
                //{
                //    throw new ArgumentException("String is empty");
                //}
                //else
                //{
                //    //  string v=cal.SayHello  (name);
                //    string v = cal.Greet(name);
                //    Console.WriteLine(v);
                //}

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Pls enter valid number");
                //Console.WriteLine(ex.StackTrace);//where did the exception occur along with line number
                //Console.WriteLine(ex.Source);//Name of the program/app where the app occured
                //Console.WriteLine(ex.Message);//Message of exception--
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("From program = " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally fired......");
                //closing connections, releasing resouces is done in the finally,
                //Always fired whether there is exception or not.

            }
            Console.Read();
        }
    }
}
