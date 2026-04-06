using CSharpChallenges.LeetCode.Medium;

namespace CSharpChallenges.Tests.LeetCode.Medium
{
    public class WalkingRobotSimulationSolutionTests
    {
        public static IEnumerable<object[]> GetRobotSimData()
        {
            // Używam Array.Empty<int[]>(), co jest bardziej optymalne niż new int[][] { }
            yield return new object[] { new int[] { 4, -1, 3 }, Array.Empty<int[]>(), 25 };
            yield return new object[] { new int[] { 4, -1, 4, -2, 4 }, new int[][] { new int[] { 2, 4 } }, 65 };
            yield return new object[] { new int[] { 6, -1, -1, 6 }, new int[][] { new int[] { 0, 0 } }, 36 };
        }

        [Theory]
        [MemberData(nameof(GetRobotSimData))]
        public void RobotSim_ShouldReturnMaximumSquaredEuclideanDistance(int[] commands, int[][] obstacles, int maxDistance)
        {
            // Arrange
            var solution = new WalkingRobotSimulationSolution();

            // Act
            var result = solution.RobotSim(commands, obstacles);

            // Assert
            Assert.Equal(maxDistance, result);
        }
    }
}
