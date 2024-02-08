namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new(new BubbleSort());
            int[] array = {11,45,80,8,91,19,14,7,17,9 }; 

            int index = 2;
            switch (index)
            {
                case 0: context.ExecuteAlgorithm(ref array); break;
                case 1:
                    context.ContextSort = new QuickSort();
                    context.ExecuteAlgorithm(ref array); break;
                case 2:
                    context.ContextSort = new SelectionSort();
                    context.ExecuteAlgorithm(ref array); break;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
