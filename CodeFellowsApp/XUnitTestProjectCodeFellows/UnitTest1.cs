using System;
using Xunit;
using CodeFellowsApp.Classes;

namespace XUnitTestProjectCodeFellows
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5000, 10000, 50, 401, "Luay")]
        [InlineData(2400, 6000, 40, 901, "Amanda")]
        public void ReturnDiscountedCourseFromDotNet(int exptectedPrice, int coursePrice, int discount, int code, string studentName)
        {
            // Arrange
            Instructor instructor = new Instructor
            {
                Name = "Amanda",
                FavoriteProgrammingLanguage = "Csharp",
                Location = "Downtown, Seattle"
            };

            DotNet dotNet = new DotNet(code, studentName, instructor);
            dotNet.CoursePrice = coursePrice;

            // Act
            int actualPrice = dotNet.Discount(discount);

            // Assert
            Assert.Equal(exptectedPrice, actualPrice);
        }
    }
}
