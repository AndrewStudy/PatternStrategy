namespace Sorting
{
    public class Context
    {
        public ISort ContextSort { get; set; }

        public Context(ISort _sort)
        {
            ContextSort = _sort;
        }

        public void ExecuteAlgorithm(ref int[] array)
        {
            ContextSort.Sort(ref array);
        }
    }
}
