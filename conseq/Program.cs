﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conseq
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence_2SingleValAndSort seq = new Sequence_2SingleValAndSort ();
            // Overloading: egy osztályon belül, azonos névvel, de eltérő "paraméter strukrúrával"
            // több metódust is definiálhatunk.
            // -----------------
            // Összeg:
            Console.WriteLine($"Sum: {seq.osszegKepzes()}");
            Console.WriteLine($"Sum: {seq.osszegKepzes(2)}");
            Console.WriteLine($"Sum: {seq.osszegKepzes(2,0)}");
            // Megszámlálás:
            Console.WriteLine($"Count: {seq.megszamlalas()}");
            Console.WriteLine($"Count: {seq.megszamlalas(70)}");
            Console.WriteLine($"Count: {seq.megszamlalas(70, 101)}");
            // "Eldöntés 1":
            Console.WriteLine($"Létezik 80-nál nagyobb elem: {seq.Eldontes(80) }");
            // "Eldöntés 2":
            Console.WriteLine($"Minden elem 80-nál nagyobb: {seq.Eldontes2(80) }");
            int i=seq.kivalasztas_gt(80);
            // Kiválasztás:
            Console.WriteLine($"Kiválasztás: Az első 80-nál nagyobb elem, a(z) {i}. Ha nem 0..19 tartományba esik, akk \"elhasalt\" a program!!");
            // LinKer:
            if ( i<seq.megszamlalas())Console.WriteLine($"LinKer: Van benne 80-nál nagyobb elem, a(z): {i}.");
            else Console.WriteLine("LinKer: Nincs benne 80-nál nagyobb elem");
            // MaxKer:
            i=seq.maxi(2, 1);
            if ( i<seq.megszamlalas()) Console.WriteLine($"MAXI: A páratlan számok közül, a legnagyobbnak az indexe: {i}.");
            else Console.WriteLine("MAXI: Nincs benne páratlan szám.");
            // A sorozat elemei:
            seq.show();
            // selectionSort
            Console.WriteLine("selectionSort - növekvő");
            seq.selectionSort ();
            seq.show();
            // binKer:
            for(int j=80; j<=100; j++) {
              i=seq.BinarySearch(j);
              if ( i>=0)Console.WriteLine($"BinKer: Van benne {j} értékű elem, a(z): {i} indexű.");
              else Console.WriteLine($"BinKer: Nincs benne {j} értékű elem elem");
            }
            // bubbleSort
            Console.WriteLine("bubbleSort - csökkenő");
            seq.bubbleSort ();
            seq.show();
            // insertionSort
            Console.WriteLine("insertionSort - növekvő");
            seq.insertionSort ();
            seq.show();
            // mergeSort - Desc
            Console.WriteLine("mergeSort - csökkenő");
            seq.MergeSort(0,seq.megszamlalas()-1);
            seq.show();
            // Quick_Sort
            Console.WriteLine("quickSort - növekvő");
            seq.Quick_Sort(0,seq.megszamlalas()-1);
            seq.show();
            Console.WriteLine("quickSort - növekvő");
            Sec2OtherSec s2s= new Sec2OtherSec();
            Console.WriteLine("Lista:");
            s2s.show();
            List<int> lista = s2s.metszet(arr2: new int[] {-10, -20, -30, -40, -50, 10, 20, 30, 40, 50 });
            Console.WriteLine("Metszetlista:");
            Console.WriteLine(string.Join(", ",lista.ToArray()) );
            lista = s2s.unio(arr2: new int[] {-10, -20, -30, -40, -50, 10, 20, 30, 40, 50 });
            Console.WriteLine("Uniolista:");
            Console.WriteLine(string.Join(", ",lista.ToArray()) );
            ///-------------------------
            lista = s2s.kivalogatas_paritas();
            Console.WriteLine("Kiválogatás:");
            //StringBuilder builder = new StringBuilder();
            foreach (int idx in lista)
            {
                Console.Write($"{idx.ToString()}. > {s2s.GetT()[idx].ToString()},\t ");
            }
            Console.WriteLine();
            ///-------------------------
            List<int> lst;
            lista = s2s.szetvalogatas_paritas(out lst);
            Console.WriteLine("Szétválogatás (páros):");
            //StringBuilder később.
            foreach (int idx in lista)
            {
                Console.Write($"{idx.ToString()}. > {s2s.GetT()[idx].ToString()},\t ");
            }
            Console.WriteLine();
            Console.WriteLine("Szétválogatás (páratlan):");
            foreach (int idx in lst)
            {
                Console.Write($"{idx.ToString()}. > {s2s.GetT()[idx].ToString()},\t ");
            }
            Console.WriteLine();
        }
    }
}
