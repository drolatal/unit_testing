using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoFeladat2021.MainPrograms
{
    public class LeapYear
    {

        public bool checkLeapYear (int year)
        {//4-el kell oszthatónak lennie a szükőévnek
            //1582-ben vezették be a gregorián naptárat, előtte más módon számolták a szökőéveket

            if (((year % 2 == 0) && (year % 100 != 0)) || (year % 400 == 0)) 
                return true;
            else
                return false;
        }

    }
}
