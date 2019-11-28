using System;

namespace conseq
{
    public class Sequence_Sum_Cnt_Dec_Ker_Kiv_Extr : Sequence_Sum_Cnt
    { // Jelenleg csak a default konstruktor létezik.
        public bool Eldontes(int ll)
        {
            // T tulajdonság: 80-nél nagyobb szám
            
            return kivalasztas(ll)<T.Length;
            // if (van==true)Console.WriteLine("Van benne 80tól nagyobb elem");
            // else Console.WriteLine("Nincs benne ilyen elem");
        }
       public bool Eldontes2(int ll)
        {
            // T tulajdonság: 80-nál nagyobb szám
            int i=0;
            while (i<T.Length && (T[i]>ll)) i++;
            return !(i<T.Length);
        }
        public int kivalasztas(int ll)
        {
            int i=0;
            while (i<T.Length && !(T[i]>ll)) i++;
            return i;
        }
                /// <summary>
        /// A d-vel osztva r maradékot adó számok közül, a legnagyobb indexe
        /// </summary>
        /// <param name="d"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int maxi(int d, int r)
        {// Az int és az Int32 szinonimák
         //   Int32 max = Int32.MinValue;
            int maxi;
            int i = 0;
            while(T[i]%d!=r) i++;
            maxi=i;
            if(maxi>=T.Length) return maxi;
            for (; i < T.Length; i++)
            {
                if (T[i]%d==r && T[maxi]<T[i])
                    maxi= i;
            }
            return maxi;
        }

    }
}