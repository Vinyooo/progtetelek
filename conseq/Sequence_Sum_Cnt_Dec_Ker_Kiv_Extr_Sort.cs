namespace conseq
{
    public class Sequence_Sum_Cnt_Dec_Ker_Kiv_Extr_Sort: Sequence_Sum_Cnt_Dec_Ker_Kiv_Extr
    { // Jelenleg csak a default konstruktor létezik.
      public void bubbleSort ()
      { // Csökkenő sorrendbe rendezi
         int i, j;
         int N = T.Length;

         for (j=N-1; j>0; j--) {
            for (i=0; i<j; i++) {
               if (T [i] < T [i + 1])
                  exchange (T, i, i + 1);
            }
         }
      }
      void exchange (int [] seq, int i1, int i2 ){
            var tmp = seq[i1];
            seq[i1] = seq[i2];
            seq[i2]=tmp;
      }
      /// <summary>
      /// SelectionSort and InsertionSort
      /// </summary>
      int Min (int[] data, int start)
      {
         int minPos = start; 
         for (int pos=start+1; pos < data.Length; pos++)
            if (data [pos] < data [minPos])
               minPos = pos;
         return minPos; 
      }
      //Selection Sort
      public void selectionSort ()
      { // Növekvő sorrendbe rendezi
         int i;
         int N = T.Length;

         for (i=0; i < N-1; i++) {
            int k = Min (T, i);
            if (i != k)
               exchange (T, i, k);
         }
      }
      ///
      /// Insertion Sort
      /// 
      public void insertionSort ()
      { // Növekvő sorrendbe rendezi
         int i, j;
         int N = T.Length;

         for (j=1; j<N; j++) {
            for (i=j; i>0 && T[i] < T[i-1]; i--) {
               exchange (T, i, i - 1);
            }
         }
      }

    }
}