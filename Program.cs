namespace ListsDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] arr = { 54, 43, 41, 87, 65, 45, 3, 2, 1, 90, 43, 43};

            List<int> arr1 = arr.Append(2).ToList ();

            string[] arrString = { "Hello", "World", "Hi" };

            arr1.Add(2);
            PrintArray(arr);
            PrintArray(arrString);
            PrintArray(arr1.Where(x => x == 43).ToArray());

        }
        public static void PrintArray<T>(T[] arr)
        {
            foreach(T i in arr)
            { 
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
