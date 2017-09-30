using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Arrays
    {
        /* Given an array of ints, return true if 6 appears 
           as either the first or last element in the array. 
           The array will be length 1 or more. 
        */
        public bool FirstLast6(int[] numbers)
        {
            // 0 is always the first index and 
            // Length - 1 of an array is always the last index
            return (numbers[0] == 6 || numbers[numbers.Length - 1] == 6);
        }
        public bool CommonEnd(int[] a, int[] b)
        {
            return (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1]);
        }

        //Return an int array length n containing the first n digits of pi.

        //MakePi(3) -> {3, 1, 4}

           public int[] MakePi(int n)
        {
            //make an array of length n
            int[] PiArray = new int[n];

            //convert math.pi to string; the issue is this wouldn't work for higher numbers. also remove the decimal.
            string Pi = Convert.ToString(Math.PI).Remove(1,1);

            //loop through the string and send each digit into array, first converting them to an int with (int)Char.GetNumericValue (it returns a double w/out (int))
            for (int i = 0; i < n; i++)
            {
               
                   PiArray[i] = (int)Char.GetNumericValue(Pi[i]);

            }
            return PiArray;



        }

        //Given an array of ints, return true if the array is length 1 or more, and the first element and the last element are equal.



        public bool SameFirstLast(int[] numbers)
    {
            if (numbers.Length > 1 && numbers[0] == numbers[numbers.Length-1])
                return true;

            else
                return false;
    }
}
}
