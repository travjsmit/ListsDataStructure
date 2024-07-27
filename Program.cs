namespace ListsDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr = { 54, 41, 87, 65, 45, 3, 2, 1, 90, 43};

            IEnumerable<int> arr1 = arr.Append(2);

            string[] arrString = { "Hello", "World", "Hi" };

            arr1.Append(2);
            PrintArray(arr);
            PrintArray(arrString);
            PrintArray(arr1.ToArray());

        }
        public static void PrintArray<T>(T[] arr)
        {
            foreach(T i in arr)
            { 
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
        }
    }
}
