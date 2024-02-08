namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {11,45,80,8,91,19,14,7,17,9 }; 

            int index = 2;
            switch (index)
            {
                case 0: Context.ExecuteAlgorithm(new BubbleSort(),ref array); break;
                case 1: Context.ExecuteAlgorithm(new QuickSort(), ref array); break;
                case 2: Context.ExecuteAlgorithm(new SelectionSort(), ref array); break;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
