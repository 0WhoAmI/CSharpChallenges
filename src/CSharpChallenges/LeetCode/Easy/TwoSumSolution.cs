namespace CSharpChallenges.LeetCode.Easy
{
    /// <summary>
    /// Task: Two Sum (LeetCode #1)
    /// URL: https://leetcode.com/problems/two-sum/
    /// Complexity: Time O(n), Space O(n)
    /// </summary>
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Słownik przechowujący wartość liczby i jej indeks
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // Jeśli znaleźliśmy brakującą liczbę w słowniku, zwracamy oba indeksy
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }

                // W przeciwnym razie dodajemy obecną liczbę do słownika
                dict[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}
