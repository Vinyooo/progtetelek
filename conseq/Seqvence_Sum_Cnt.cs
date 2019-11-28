using System.Linq;

namespace conseq
{
    public class Sequence_Sum_Cnt : Sequence
    { // Jelenleg csak a default konstruktor létezik.
        
        /// <summary>
        /// t elemeinek összege
        /// </summary>
        /// <returns>sum</returns>
        public int osszegKepzes()
        {
            var sum = T[0];
            for(int i=1;i<T.Length;i++)
                    sum += T[i];
            return sum;
        }
        /// <summary>
        /// A d-vel osztva 0 maradékot adó egészek összege
        /// </summary>
        /// <param name="d"></param>
        /// <returns>sum</returns>
        public int osszegKepzes(int d) => (from int v in T
                                           where v % d == 0
                                           select v).Sum();
        /// <summary>
        /// A d-vel osztva r maradékot adó egészek összege
        /// </summary>
        /// <param name="d"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int osszegKepzes(int d, int r)
        {
            int sum = 0;
            foreach(int v in T)
                if(v%d==r)
                    sum += v;
            return sum;
        }
        /// <summary>
        ///  t elemeinek száma
        /// </summary>
        /// <returns></returns>
        public int megszamlalas()
        {
            return T.Length;
        }
        /// <summary>
        /// t adott értéknél nagyobb elemeinek száma
        /// </summary>
        /// <param name="ll"></param>
        /// <returns></returns>
        public int megszamlalas(int ll)
        {
            return (from v in T
                    where ll < v
                    select v).Count();
        }
        /// <summary>
        /// t adott érték közötti elemeinek száma
        /// </summary>
        /// <param name="ll"></param>
        /// <param name="ul"></param>
        /// <returns></returns>
        public int megszamlalas(int ll, int ul) => (from v in T
                                                    where ll < v && v < ul
                                                    select v).Count();
    }
}