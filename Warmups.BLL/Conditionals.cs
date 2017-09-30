using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Conditionals
    {
        /* We have two children, a and b, and the parameters aSmile and 
           bSmile indicate if each is smiling. We are in trouble if they 
           are both smiling or if neither of them is smiling. Return true 
           if we are in trouble. 
        */
        public bool AreWeInTrouble(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
                return true;

            if (!aSmile && !bSmile)
                return true;

            return false;
        }

        /*The parameter weekday is true if it is a weekday, and the parameter vacation 
         * is true if we are on vacation.We sleep in if it is not a weekday or we're on 
         * vacation. Return true if we sleep in. 

sleepIn(false, false) -> true
sleepIn(true, false) -> false
sleepIn(false, true) -> true
*/


public bool CanSleepIn(bool isWeekday, bool isVacation)
        {
            if (isVacation)
                return true;

            if (!isWeekday)
                return true;

            return false;

        }

        /*Given two int values, return their sum.However, if the two values are
            the same, then return double their sum.

        SumDouble(1, 2) -> 3
        SumDouble(3, 2) -> 5
        SumDouble(2, 2) -> 8*/

        public int SumDouble(int a, int b)
        {
            if (a == b)
                return (a + b) * 2;

            return (a + b);
        }
    }
}
