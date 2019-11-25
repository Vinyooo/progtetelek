using System;

namespace conseq
{
    public class Sequence
    {
        int[] t;
        public Sequence( uint cnt, int a, int b)
        {
            Random rnd = new Random();
            t=new int[cnt];
            for (int i=0;i<t.Length;i++)        {
                t[i] = rnd.Next(a,b+1);
            }
        }
        public Sequence(uint cnt) : this(cnt, -100, 100) {}
        public Sequence() : this(20) {}
        public int Osszegkepzes()
        {
            int sum = 0;
            for(int i=0;i<t.Length;i++)
                    sum += t[i];
            return sum;
        }
        public void Show(){
            for(int i=0;i<t.Length;i++)
                    System.Console.Write($"{i}. elem: {t[i]},\t");
            System.Console.WriteLine( );
        }
    }
}