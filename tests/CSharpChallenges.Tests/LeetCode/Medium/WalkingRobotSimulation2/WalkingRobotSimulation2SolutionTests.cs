using CSharpChallenges.LeetCode.Medium.WalkingRobotSimulation2;

namespace CSharpChallenges.Tests.LeetCode.Medium.WalkingRobotSimulation2
{
    public class WalkingRobotSimulation2SolutionTests
    {
        [Fact]
        public void Robot_ShouldFollowLeetCodeExample()
        {
            // Arrange
            var robot = new Robot(6, 3);

            // Act & Assert
            robot.Step(2);
            Assert.Equal([2, 0], robot.GetPos());
            Assert.Equal("East", robot.GetDir());

            robot.Step(2);
            Assert.Equal([4, 0], robot.GetPos());
            Assert.Equal("East", robot.GetDir());

            robot.Step(2);
            Assert.Equal([5, 1], robot.GetPos());
            Assert.Equal("North", robot.GetDir());

            robot.Step(1);
            Assert.Equal([5, 2], robot.GetPos());
            Assert.Equal("North", robot.GetDir());

            robot.Step(4);
            Assert.Equal([1, 2], robot.GetPos());
            Assert.Equal("West", robot.GetDir());
        }
    }
}
