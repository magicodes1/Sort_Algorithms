
using SortNumbers;

void arrangeItemOfArray(ref int[] arr, int length)
{
    for (int i = 0; i < length; i++)
    {
        arr[i] = (int)new Random().NextInt64(-100, 100);
    }
}

void printArray(int[] arr)
{

    foreach (var item in arr)
    {
        System.Console.Write($"{item} \t");
    }
}

void main()
{

    int option = 0;
    Algorithm algorithm = null!;
    const int LENGTH = 9;
    int[] unSortedArray = new int[LENGTH];

    do
    {
        System.Console.WriteLine();

        if (option == 0)
        {
            arrangeItemOfArray(ref unSortedArray, LENGTH);
            System.Console.Write("unsorted array: ");
            printArray(unSortedArray);
        }

        if (option == 9)
        {
            arrangeItemOfArray(ref unSortedArray, LENGTH);
            System.Console.Write("New unsorted array: ");
            printArray(unSortedArray);
        }

        System.Console.WriteLine("\n");

        Console.WriteLine("Please input your optional.");
        Console.WriteLine("0.Selection sort");
        Console.WriteLine("1.Insert sort");
        Console.WriteLine("2.Bubble sort");
        Console.WriteLine("3.Quick sort");
        Console.WriteLine("4.Merge sort");
        Console.WriteLine("5.Max heap sort");
        Console.WriteLine("6.Shell sort");
        Console.WriteLine("7.Counting sort");
        Console.WriteLine("8.Radix sort");
        Console.WriteLine("9.Continue with new unsorted array.");
        Console.WriteLine("10.Quit");



        option = int.Parse(System.Console.ReadLine()!);


        switch (option)
        {
            case 0:
                algorithm = new SelectionSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 1:
                algorithm = new InsertSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 2:
                algorithm = new BubbleSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 3:
                algorithm = new QuickSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 4:
                algorithm = new MergeSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 5:
                algorithm = new MaxHeapSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 6:
                algorithm = new ShellSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 7:
                algorithm = new CountingSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 8:
                algorithm = new RadixSort(unSortedArray);
                algorithm.sort();
                algorithm.print();
                break;
            case 9:
                continue;
            case 10:
                break;
            default:
                break;
        }


    } while (option != 10);

    Console.ReadLine();
}

main();
