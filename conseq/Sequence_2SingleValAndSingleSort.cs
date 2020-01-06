namespace conseq
{
    public class Sequence_2SingleValAndSingleSort: Sequence_2SingleVal
    { // Jelenleg csak a default konstruktor létezik.
      public void bubbleSort ()
      { // Csökkenő sorrendbe rendezi
         int i, j;
         int N = GetT().Length;

         for (j=N-1; j>0; j--) {
            for (i=0; i<j; i++) {
               if (GetT()[i] < GetT()[i + 1])
                  exchange (GetT(), i, i + 1);
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
         int N = GetT().Length;

         for (i=0; i < N-1; i++) {
            int k = Min (GetT(), i);
            if (i != k)
               exchange (GetT(), i, k);
         }
      }
      ///
      /// Insertion Sort
      /// 
      public void insertionSort() 
      { 
        int n = GetT().Length; 
        for (int i = 1; i < n; ++i) { 
            int key = GetT()[i];
            int j = i - 1;
            // A rendezetlen tartomány alsó határán (i. pozícióban) lévő elemet átmásoljuk a
            // key változóba, majd a T[0..i-1] elemek között az index tartományban lefele 
            // haladva, eggyel feljebb mozgatjuk az elemeket amíg nagyobb mint a key. 
            // A "megürült" helyre pedig beszúrjuk a key elemet. 
            while (j >= 0 && GetT()[j] > key) {
                    GetT()[j + 1] = GetT()[j]; 
                j = j - 1; 
            }
                GetT()[j + 1] = key; 
        } 
      } 

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}