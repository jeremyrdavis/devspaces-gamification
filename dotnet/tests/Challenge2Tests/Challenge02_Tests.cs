using ds_challenge_02.Controllers;

namespace Challenge2Tests;

public class Challenge02_Tests
{
     [Fact]
        public async Task Get_GreetChallengeAttendees()
        {
            // Arrange
            var controller = new DsChallenge02Controller();

            // Act
            var result = controller.GreetChallengeAttendees();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Any());
        }
}