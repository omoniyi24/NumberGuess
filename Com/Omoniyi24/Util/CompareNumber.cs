using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Omoniyi24.Util
{
    class CompareNumber
    {
        GuessNumber guessNumber = new GuessNumber();
        Result result = new Result();
        public Result checkNumber(int number)
        {
            int guessedNum = guessNumber.generateNumber(0, 9);

            if (guessedNum  == number)
            {
                result.getResult = "You are CORRECT!!!";
            }
            else
            {
                result.getResult = "You are WRONG!!!";
            }
            return result;
        }
    }
}
