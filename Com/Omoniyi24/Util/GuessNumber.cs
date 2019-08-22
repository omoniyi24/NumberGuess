using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Omoniyi24.Util
{
    class GuessNumber
    {
        public int generateNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
