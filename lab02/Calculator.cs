using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Calculator
    {
        public double number = 0.0; //properties

        public Calculator(double number)//constructor
        {
            this.number = number;//Dependency
        }
        public string Calcutor()
        {
            var result = "";
            if (number >= 50)
            {
                result = "pass";
            }
            else  
            {
                result = "fail";
            }
            return result;
        }public double Display()
           
        {
            return number;
        }
    }
}