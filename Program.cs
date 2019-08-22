using Com.Omoniyi24.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessa
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareNumber comNumber = new CompareNumber();
            Number number = new Number();
            number.getInputNumber = 1;
            Result result = comNumber.checkNumber(number.getInputNumber);
            Console.WriteLine(result.getResult);
        }
    }
}
