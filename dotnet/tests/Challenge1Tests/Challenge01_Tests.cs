using ds_challenge_01.Controllers;

namespace Challenge1Tests;

public class Challenge01_Tests
{
     [Fact]
        public async Task Get_CalculateAndPrintStatistics()
        {
            // Arrange
            var controller = new CalculateAndPrintStatisticsController();

            // Act
            var result = controller.calculateandprintstatistics([10,20,30]);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(result.ToString(), "Average: 20 | Maximum: 30 | Minimum: 10");
        }


        public async Task Get_CurrentDate()
        {
            // Arrange
            var controller = new DateController();

            // Act
           
            // Assert
            
                //     void testHelloEndpoint() {
                //     given()
                //   .when().get("/api/currentdate")
                //   .then()
                //      .statusCode(200)
                //      .body(is("Current Date=["+LocalDate.now()+"]"));

        }
}