using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoFeladat2021.MainPrograms
{
    public class Mathemathics
    {
        //int túlcsordulást lehetne vizsgálni,
        //mert futási időben nem figyeli a program magától az overflowexceptiont
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        //itt szerintem jobb lett volna intervallumosan megírni,
        //pl.:a és b közötti páratlan számokat,
        //mert az int vagy long MinValue-tól nehezen számolja ki a gép
        //illetve ha csak a pozitív páratlan számokat vesszük, akkor is hiányzik az 1
        //és akkor 1 nél kisebb korlátra, exception-t dobni
        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (var i = 2; i <= limit; i++)
                if (i % 2 != 0)
                    yield return i;
        }
    }
}
