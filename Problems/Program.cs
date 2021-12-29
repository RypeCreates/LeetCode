using System;

namespace Problems
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //RomanToIntDriver();
            SortedArrayToBinarySearchDriver();
        }

        public static void RomanToIntDriver()
        {
            var testStr = "IX";

            var result = RomanToInteger.RomanToInt(testStr);

            Console.WriteLine($"Result: {result}");
        }

        public static void SortedArrayToBinarySearchDriver()
        {
            var input = new int[] { -10, -3, 0, 5, 9 };

            var sortedArrayToBinarySearch = new SortedArraytoBinarySearch();
            var result = sortedArrayToBinarySearch.SortedArrayToBST(input);

            Console.WriteLine($"Result: {result}");
        }
    }
}
