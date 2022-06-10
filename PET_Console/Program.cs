using System.Collections.Generic;
using System.Linq;

namespace PET_Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = {1, 2, 6, 7, 8, 4, 1, 9, -3};
            var result = SortOddEven(numbers);
            
            List<int> SortOddEven(int[] nums)
            {
                List<int> oddEven = new List<int>();
                List<int> sortedList = new List<int>();
                
                foreach (var num in nums)
                {
                    oddEven.Add(num);
                }
                    
                oddEven.Sort();
                return sortedList;
            }
        }
    }
}