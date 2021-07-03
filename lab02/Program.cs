using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Calculator");

            Console.Write("number=");

            var number = Double.Parse(Console.ReadLine()) ;
            var Calc = new Calculator(number);

          var result =  Calc.Calcutor();
            Console.WriteLine(" :your result: "+result);

            var inputnumber = Calc.Display();
            Console.WriteLine(":your number:"+inputnumber);
            Console.ReadLine();
            
        }

       
    }
}
