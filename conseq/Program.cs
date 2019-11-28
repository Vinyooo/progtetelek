using System;

namespace conseq
{
    class Program
    {
        static void Main(string[] args)
        {
            Sequence_Sum_Cnt_Dec_Ker_Kiv_Extr_Sort seq = new Sequence_Sum_Cnt_Dec_Ker_Kiv_Extr_Sort ();
            //Overloading: egy osztályon belül, azonos névvel, de eltérő "paraméter strukrúrával"
            // több metódust is definiálhatunk.
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
            int i=seq.kivalasztas(80);
            // Kiválasztás:
            Console.WriteLine($"Az első 80-nál nagyobb elem, a(z) {i}.");
            // LinKer:
            if ( i<seq.megszamlalas())Console.WriteLine($"Van benne 80-nál nagyobb elem, a(z): {i}.");
            else Console.WriteLine("Nincs benne ilyen elem");
            // MaxKer:
            i=seq.maxi(2, 1);
            if ( i<seq.megszamlalas())Console.WriteLine($"A páratlan számok közül, a legnagyobbnak az indexe: {i}.");
            else Console.WriteLine("Nincs benne páratlan szám.");
            // A sorozat elemei:
            seq.show();
            // selectionSort
            Console.WriteLine("selectionSort - növekvő");
            seq.selectionSort ();
            seq.show();
            // bubbleSort
            Console.WriteLine("bubbleSort - csökkenő");
            seq.bubbleSort ();
            seq.show();
            // insertionSort
            Console.WriteLine("insertionSort - növekvő");
            seq.insertionSort ();
            seq.show();
        }
    }
}
