namespace SortNumbers
{
    public class ShellSort : Algorithm
    {
        private int [] unsortedArray=null!;

        public ShellSort(int[] unsortedArray) : base(unsortedArray)
        {
            this.unsortedArray = unsortedArray;
        }


        public override void sort(){
            for (int gap = arr.Length/2; gap >0; gap/=2)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int j=i;
                    while (j>=gap && arr[j] < arr[j-gap])
                    {
                         swap(ref arr[j],ref arr[j-gap]);
                         j-=gap;
                    }
                }
            }
        }
    }
}