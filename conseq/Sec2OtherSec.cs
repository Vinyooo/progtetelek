using System.Collections.Generic;
using System.Linq;

namespace conseq
{
    public class Sec2OtherSec : Sequence_2SingleValAndSort
    {
        public Sec2OtherSec()
        {
        }
        public List<int> metszet( int[] arr2){
            List<int> lst = new List<int>();
            for (int i=0; i<arr2.Length; i++)
            {
                if (kivalasztas_eq(arr2[i]) < GetT().Length)
                {
                    lst.Add(arr2[i]);
                }
            }
            return lst;
        }
        public List<int> unio( int[] arr2){
            List<int> lst = new List<int>();
            lst= GetT().ToList();
            for (int i=0; i<arr2.Length; i++)
            {
                if (kivalasztas_eq(arr2[i]) >= GetT().Length)
                {
                    lst.Add(arr2[i]);
                }
            }
            return lst;
        }
        public List<int> kivalogatas_paritas( ){
            List<int> lst = new List<int>();
            for (int i=0; i< GetT().Length; i++)
            {
                if (GetT()[i]%2==0)
                {
                    lst.Add(i);
                }
            }
            return lst;
        }
        public List<int> szetvalogatas_paritas(out List<int> ptlnlist ){
            List<int> pslist = new List<int>();
            ptlnlist =new List<int>();
            for (int i=0; i< GetT().Length; i++)
            {
                if (GetT()[i]%2==0)
                {
                    pslist.Add(i);
                }else{
                    ptlnlist.Add(i);
                }
            }
            return pslist;
        }

    }
}