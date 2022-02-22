using System.Linq;

namespace SortNumbers
{
    public class RadixSort : Algorithm
    {
        private int[] unsortedArray;

        public RadixSort(int[] unsortedArray) : base(unsortedArray)
        {
            this.unsortedArray = unsortedArray;
        }

        private bool checkNegativeNumber(int[] arr) => arr.Any(p => p < 0);

        private int minimumNumber(int[] arr) => arr.Min();
        private int maximumNumber(int[] arr) => arr.Max();



        private void countingSort(int[] arr, int number)
        {
            int[] count = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                int index = (arr[i] / number) % 10;

                count[index]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            int[] output = new int[arr.Length];

            for (int i = arr.Length-1; i >= 0; i--)
            {
                int index = (arr[i] / number) % 10;
                output[--count[index]] = arr[i];
            }

            output.CopyTo(arr, 0);
        }

        public sealed override void sort()
        {
            bool chkNegativeNumber = checkNegativeNumber(arr);
            int minNumber = minimumNumber(arr);

            if (chkNegativeNumber)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] -= minNumber;
                }
            }
            int maxNumber = maximumNumber(arr);

            for (int i = 1; maxNumber / i > 0; i *= 10)
            {
                countingSort(arr, i);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += minNumber;
            }
        }


    }
}