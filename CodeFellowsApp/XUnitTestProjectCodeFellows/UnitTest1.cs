using System;
using Xunit;
using CodeFellowsApp.Classes;

namespace XUnitTestProjectCodeFellows
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5000, 10000, 50, 401, "Csharp")]
        [InlineData(2400, 6000, 40, 901, "C#7.0")]
        public void ReturnDiscountedCourseFromDotNet(int exptectedPrice, int coursePrice, int discount, int code, string languageName)
        {
            // Arrange
            Instructor instructor = new Instructor
            {
                Name = "Amanda",
                FavoriteProgrammingLanguage = "Csharp",
                Location = "Downtown, Seattle"
            };

            DotNet dotNet = new DotNet(code, languageName, instructor);
            dotNet.CoursePrice = coursePrice;

            // Act
            int actualPrice = dotNet.Discount(discount);

            // Assert
            Assert.Equal(exptectedPrice, actualPrice);
        }

        [Fact]
        public void CheckIfThereIsClassAtCertainDay()
        {
            // Arrange
            JavaScript js = new JavaScript();
            js.ClassDays = new[] {"Thursday", "Friday"};

            // Act
            bool result = js.CheckDayIfThereIsClass("Sunday");

            // Assert
            Assert.False(result);
        }
    }
}
