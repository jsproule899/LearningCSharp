namespace Algorithims
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] list = [2, 5, 4, 9,-1, 0, 4, -5, 1, 8, 56];

            Algorithims.BubbleSort(list);
            Console.WriteLine("sorted list: " +string.Join(", ", list));
        }
    }

}