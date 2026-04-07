using CSharpChallenges.LeetCode.Easy.RobotReturnToOrigin;

namespace CSharpChallenges.Tests.LeetCode.Easy.RobotReturnToOrigin
{
    public class RobotReturnToOriginSolutionTests
    {
        [Theory]
        [InlineData("UD", true)]
        [InlineData("LL", false)]
        public void JudgeCircle_ShouldReturnStartingPosition(string moves, bool expected)
        {
            // Arrange
            var solution = new RobotReturnToOriginSolution();

            // Act
            var result = solution.JudgeCircle(moves);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
