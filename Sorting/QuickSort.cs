namespace Sorting
{
    public class QuickSort : ISort
    {
        public void Sort(ref int[] array)
        {
            int low = 0;
            int high = array.Length - 1;

            Algoritm(ref array, low, high);
        }

        private void Algoritm(ref int[] array, int low, int high)
        {            
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);
                Algoritm(ref array, low, partitionIndex - 1);
                Algoritm(ref array, partitionIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }
    }
}
