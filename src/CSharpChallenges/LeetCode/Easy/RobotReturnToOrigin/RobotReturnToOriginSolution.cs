namespace CSharpChallenges.LeetCode.Easy.RobotReturnToOrigin
{
    /// <summary>
    /// Task: Robot Return to Origin (LeetCode #657)
    /// URL: https://leetcode.com/problems/robot-return-to-origin/description/?envType=daily-question&envId=2026-04-05
    /// Complexity: Time O(n), Space O(1)
    /// </summary>
    public class RobotReturnToOriginSolution
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            foreach (char move in moves)
            {
                switch (move)
                {
                    case 'U': x++; break;
                    case 'D': x--; break;
                    case 'R': y++; break;
                    case 'L': y--; break;
                }
            }
            return x == 0 && y == 0;
        }
    }
}
