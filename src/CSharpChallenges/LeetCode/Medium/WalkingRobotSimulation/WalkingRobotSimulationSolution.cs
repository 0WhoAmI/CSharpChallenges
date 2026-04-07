namespace CSharpChallenges.LeetCode.Medium.WalkingRobotSimulation
{
    /// <summary>
    /// Task: Walking Robot Simulation (LeetCode #874)
    /// URL: https://leetcode.com/problems/walking-robot-simulation/description/?envType=daily-question&envId=2026-04-06
    /// Complexity: Time O(N + K), Space O(K) (where N = commands, K = obstacles)
    /// </summary>
    public class WalkingRobotSimulationSolution
    {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            HashSet<(int, int)> obstacleSet = new HashSet<(int, int)>();
            foreach (var obs in obstacles)
            {
                obstacleSet.Add((obs[0], obs[1]));
            }

            // Tablice kierunków
            // [0] Północ: Y + 1 (Idziemy w górę)
            // [1] Wschód: X + 1 (Idziemy w prawo)
            // [2] Południe: Y - 1 (Idziemy w dół)
            // [3] Zachód: X - 1 (Idziemy w lewo)
            int[] dirX = [0, 1, 0, -1];
            int[] dirY = [1, 0, -1, 0];

            int x = 0;
            int y = 0;
            int direction = 0;
            int maxDistanceSquared = 0;

            foreach (int command in commands)
            {
                if (command == -2) // Skręt w lewo
                {
                    direction = (direction + 3) % 4;
                }
                else if (command == -1) // Skręt w prawo
                {
                    direction = (direction + 1) % 4;
                }
                else
                {
                    for (int step = 0; step < command; step++)
                    {
                        int nextX = x + dirX[direction];
                        int nextY = y + dirY[direction];

                        // Sprawdzamy czy na nowej pozycji jest przeszkoda
                        if (obstacleSet.Contains((nextX, nextY)))
                        {
                            break;
                        }

                        x = nextX;
                        y = nextY;

                        // x * x jest szybsze procesorowo niż Math.Pow(x, 2)
                        maxDistanceSquared = Math.Max(maxDistanceSquared, x * x + y * y);
                    }
                }
            }

            return maxDistanceSquared;
        }
    }
}
