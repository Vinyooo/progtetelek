namespace conseq
{
    public class Sequence_2SingleValAndSort:Sequence_2SingleValAndSingleSort
    {
        #region Mergesort
    /// <summary>
    /// Merge (csökkenő):
    /// A left és right közötti részsorozat midle-lel elválasztott két
    /// szakaszának összefésülése.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="middle"></param>
    /// <param name="right"></param>
        private void Merge( int left,int middle,int right)
        {
            int[] leftArray = new int[middle - left +1];
            int[] rightArray = new int[right - middle];
            System.Array.Copy(GetT(), left,leftArray,0,middle-left+1);
            System.Array.Copy(GetT(), middle+1,rightArray,0,right-middle);
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++){
                if (i == leftArray.Length){
                    GetT()[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length){
                    GetT()[k] = leftArray[i];
                    i++;
                }else if (leftArray[i] >= rightArray[j]){ // ha == akk is a left jön.
                    GetT()[k] = leftArray[i];
                    i++;
                }else{
                    GetT()[k] = rightArray[j]; // right csak akkor jön, ha szigorúan nagyobb.
                    j++;
                }
            }
        } 
        /// <summary>
        /// Mergesort:
        /// 1. Két kb azonos hosszú szakaszra bontja
        /// 2. Meghívja önmagát mindkettőre
        /// 3. Összefésülteti a kettőt egybe.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void MergeSort(int left,int right)
        {
            if (left < right){
                int middle = (left + right) / 2; //Két kb azonos hosszú szakaszra bontja
                MergeSort( left, middle);//Rendezi az alsót
                MergeSort( middle + 1, right);//Rendezi a felsőt
                Merge( left, middle, right); //Összefésülteti a kettőt egybe.
            }
        }
        #endregion
        #region Quicksort
        /// <summary>
        /// A szakasz aljára a pivot elem elé sorolandókat helyezi,
        /// a felső részére pedig a pivot elem mögé sorolandó elemek kerülnek.
        /// A "felülre került" elemek tartományának alsó határát visszaadja.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int Partition(int left, int right){
            int pivot = GetT()[left];
            while (true) {
                while (GetT()[left] < pivot) {
                    left++;
                }
                while (GetT()[right] > pivot){
                    right--;
                }
                if (left < right) {
                    if (GetT()[left] == GetT()[right]) return right;
                    int temp = GetT()[left];
                    GetT()[left] = GetT()[right];
                    GetT()[right] = temp;
                }else {
                    return right;
                }
            }
        }
        /// <summary>
        /// Quicksort
        /// Kettévágatja a rendezendő tartományt a Partition-nel, majd mindkét részre
        /// meghívja önmagát s.í.t.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void Quick_Sort(int left, int right) {
            if (left < right){
                int pivot = Partition( left, right);
                if (pivot > 1) { // Ha alatta egynél több elem van.
                    Quick_Sort( left, pivot - 1);
                }
                if (pivot + 1 < right){ // Ha felette egynél több elem van.
                    Quick_Sort( pivot + 1, right);
                }
            }
        }
        #endregion
    }
}