namespace SortNumbers
{
    class MergeSort : Algorithm
    {
        private int[] unSortedArray;

        public MergeSort(int[] unSortedArray) : base(unSortedArray)
        {
            this.unSortedArray = unSortedArray;
        }


        private int [] mergeSort(int[] arr)
        {
            if(arr.Length<2){
                return arr;
            }
            int middle = arr.Length/2;
            
            int [] leftArray = new int [middle];
            int [] rightArray = new int [arr.Length-middle];

            for (int i = 0; i < middle; i++)
            {
                leftArray[i]=arr[i];
            }

            for (int i = middle; i < arr.Length; i++)
            {
                rightArray[i-middle]=arr[i];
            }

            int [] leftSide = mergeSort(leftArray);
            int [] rightSide = mergeSort(rightArray);

            int [] result = merge(leftSide,rightSide);
            return result;
        }

        private int [] merge(int[] leftSide, int[] rightSide)
        {
            int [] result=new int [leftSide.Length+rightSide.Length];
            int i=0,j=0,index=0;

            while (i<leftSide.Length && j<rightSide.Length)
            {
                 if(leftSide[i]<rightSide[j]){
                     result[index]=leftSide[i];
                     i++;
                 }
                 else{
                     result[index]=rightSide[j];
                     j++;
                 }
                 index++;
            }

            while (i<leftSide.Length)
            {
                 result[index]=leftSide[i];
                 i++;
                 index++;
            }

            while (j<rightSide.Length)
            {
                 result[index]=rightSide[j];
                 j++;
                 index++;
            }
            return result;
        }

        public override void sort()
        {
            var result = mergeSort(arr);
            base.arr=result;
        }
    }
}