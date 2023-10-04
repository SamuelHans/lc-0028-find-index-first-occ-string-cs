namespace LC_0028_FindIndexFirstOccString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Given two strings 'needle' and 'haystack', return the index of the first occurrence of 'needle' in 'haystack', or -1 if 
            'needle' is not part of 'haystack'.

            Example 1:
            
            Input: haystack = "sadbutsad", needle = "sad"
            Output: 0
            Explanation: "sad" occurs at index 0 and 6.
            The first occurrence is at index 0, so we return 0.
            
            Example 2:
            
            Input: haystack = "leetcode", needle = "leeto"
            Output: -1
            Explanation: "leeto" did not occur in "leetcode", so we return -1.
             
            
            Constraints:
            
            1 <= haystack.length, needle.length <= 104
            haystack and needle consist of only lowercase English characters.
            */

            //var haystack = "sadbutsad";
            //var needle = "sad";

            var haystack = "leetcode";
            var needle = "leeto";

            Console.WriteLine("For haystack {0} with needle {1}, the index is located at: {2}", haystack, needle, Solution.StrStr(haystack, needle));

        }

        // Method 1 - Inefficient
        public class Solution
        {
            public static int StrStr(string haystack, string needle)
            {
                // Check if 
                if (!haystack.Contains(needle))
                {
                    return -1;
                }

                int nextIndex = haystack.IndexOf(needle, 0);

                return nextIndex;
            }
        }

        // Method 2 - Use KMP next time. https://en.wikipedia.org/wiki/Knuth%E2%80%93Morris%E2%80%93Pratt_algorithm
    }
}