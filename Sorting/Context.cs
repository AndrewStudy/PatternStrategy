namespace Sorting
{
    public static class Context
    {
        private static ISort ContextSort { get; set; }

        public static void ExecuteAlgorithm(ISort _sort, ref int[] array)
        {
            ContextSort = _sort;
            ContextSort.Sort(ref array);
        }
    }
}
