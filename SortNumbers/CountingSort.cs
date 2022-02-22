namespace SortNumbers
{
    public class CountingSort : Algorithm
    {
        private int[] unsortedArray;

        public CountingSort(int[] unsortedArray) : base(unsortedArray)
        {
            this.unsortedArray = unsortedArray;
        }



        /* public override void sort()
         {
             int max = getMax(arr);

             int[] count = new int[max + 1];


             foreach(var item in arr)
             {
                 count[item]++;
             }

             for (int i = 1; i <= max; i++)
             {
                 count[i] +=count[i - 1];
             }

             int[] output = new int[arr.Length];


             for (int i = arr.Length - 1; i >= 0; i--)
             {
                 int index = arr[i];
                 output[--count[index]] = arr[i];
             }
             output.CopyTo(arr,0);
         }*/

        private int getMin(int[] arr) => arr.Min();
        private int getMax(int[] arr) => arr.Max();

        //counting sort handle negative numbers
        public sealed override void sort()
        {
            int max = getMax(arr);
            int min = getMin(arr);

            int[] count = new int[(max - min) + 1];

            foreach (var item in arr)
            {
                count[item - min]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            int[] output = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int index = arr[i] - min;
                output[--count[index]] = arr[i];
            }

            output.CopyTo(arr, 0);
        }


    }
}