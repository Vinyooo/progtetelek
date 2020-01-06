using System;

namespace conseq
{
    public class Sequence_2SingleVal : Sequence_Sum_Cnt
    { // Jelenleg csak a default konstruktor létezik.
        public bool Eldontes(int ll)
        {
            // T tulajdonság: 80-nél nagyobb szám
            
            return kivalasztas_gt(ll)< GetT().Length;
            // if (van==true)Console.WriteLine("Van benne 80tól nagyobb elem");
            // else Console.WriteLine("Nincs benne ilyen elem");
        }
       public bool Eldontes2(int ll)
        {
            // T tulajdonság: 80-nál nagyobb szám
            int i=0;
            while (i< GetT().Length && (GetT()[i]>ll)) i++;
            return !(i< GetT().Length);
        }
        public int kivalasztas_gt(int ll)
        {
            int i=0;
            while (i< GetT().Length && !(GetT()[i]>ll)) i++;
            return i;
        }
        public int kivalasztas_eq(int ll)
        {
            int i=0;
            while (i< GetT().Length && !(GetT()[i]==ll)) i++;
            return i;
        }
        /// <summary>
        /// Bináris (Logaritmikus) keresés.
        /// BinarySearch O(log n) lépésben, de csak rendezett sorozatokon!!
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int BinarySearch( int key)  
        { 
            int min = 0;
            int max = GetT().Length - 1; 
            while (min <=max)  
            {  
                int mid = (min + max) / 2;  
                if (key == GetT()[mid])  
                    return mid;
                else if (key < GetT()[mid])
                    max = mid - 1;
                else    
                    min = mid + 1;
            }  
            return -1;
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
            while(GetT()[i]%d!=r) i++;
            maxi=i;
            if(maxi>= GetT().Length) return maxi;
            for (; i < GetT().Length; i++)
            {
                if (GetT()[i]%d==r && GetT()[maxi]< GetT()[i])
                    maxi= i;
            }
            return maxi;
        }

    }
}