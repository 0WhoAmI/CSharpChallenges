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
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[nums[0]] = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dict.TryGetValue(complement, out int value))
                {
                    return new int[] { value, i };
                }

                dict[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}
