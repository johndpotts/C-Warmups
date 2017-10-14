using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmups.BLL
{
    public class Logic
    {
        /* When squirrels get together for a party, they like to have cigars. 
           A squirrel party is successful when the number of cigars is between 
           40 and 60, inclusive. Unless it is the weekend, in which case there is 
           no upper bound on the number of cigars. Return true if the party with 
           the given values is successful, or false otherwise. 
        */
        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (isWeekend)
                return cigars > 40;
            else
                return (cigars >= 40 && cigars <= 60);
        }

        //You and your date are trying to get a table at a restaurant.
        //The parameter "you" is the stylishness of your clothes, in the range 0..10,
        //and "date" is the stylishness of your date's clothes. The result getting the table
        //is encoded as an int value with 0=no, 1=maybe, 2=yes. If either of you is very stylish, 
        //8 or more, then the result is 2 (yes). With the exception that if either of you has style
        //of 2 or less, then the result is 0 (no). Otherwise the result is 1 (maybe). 
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle <= 2 || dateStyle <= 2)
                return 0;
            else if (yourStyle >= 8 || dateStyle >= 8)
                return 2;
            else return 1;

            
        }
    }
}
