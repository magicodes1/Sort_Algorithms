namespace SortNumbers
{
    public class Algorithm
    {
        protected int [] arr;

        public Algorithm(int[] arr)
        {
            this.arr = arr;
        }


        protected  virtual void swap(ref int a,ref int b){
            int tmp = a;
            a=b;
            b=tmp;
        }

        public virtual void sort(){

        }

        public virtual void print(){
            System.Console.Write("Sorted array: ");
            foreach (var item in arr)
            {
                Console.Write($"{item} \t");
            }
            System.Console.WriteLine();
        }
    }
}