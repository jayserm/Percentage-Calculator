using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///Coded by Jayser M.
namespace percentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1; ///it will declare the variable a as an integer even if the default value is 1.
            decimal x = 100; ///this is the way how you get the percentage, dividing the integer 'a' by 100 (it is declared as a decimal in order to get a decimal result).
            Console.WriteLine("welcome to percentage calculator");
            retry: /// this is a reference to the command goto.
            Console.WriteLine("Input the number in order to see the percent");
            a = Convert.ToInt32(Console.ReadLine()); ///here you will input the number you want to convert and it will be declared as an int.
            Console.WriteLine("this is your result " + a / x); ///there is the computation, dividing a (which is your number) by x (which is 100).
            Console.WriteLine("Do you want to try another number? (Y/N) (Input Y for 'yes' and N for 'no' and then press enter)");
            string answer = Console.ReadLine();
            do
            {
                if (answer.Equals("y"))
                {
                    Console.Clear();
                    goto retry;
                }
                else if (answer.Equals("n"))
                {
                    Console.WriteLine("This app will close");
                    Console.WriteLine("Please, input any key to close it");
                    Console.ReadKey();
                    break;
                }
                
            }
            while (answer.ToLower() == "y");
        }
    }
}
