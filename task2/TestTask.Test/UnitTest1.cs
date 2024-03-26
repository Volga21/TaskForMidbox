using Figures;
namespace TestTask.Test
{

    public class UnitTest1
    {
        [Fact]
        public void TestCorrectAnswerForCircle()
        {
            Circle figure = new Circle(2);
            Assert.Equal(Math.Pow(2,2)*Math.PI,figure.square());
        }
        [Fact]
        public void ResultNotNullForCircle()
        {
            Circle figure = new Circle(2);
            Assert.NotNull(figure.square());
        }
        [Fact]
        public void TestCorrectAnswerForTriangle()
        {
            Triangle figure = new Triangle(3,4,5);
            Assert.Equal(6, figure.square());
        }
        [Fact]
        public void ResultNotNullForTriangle()
        {
            Triangle figure = new Triangle(3, 4, 4);
            Assert.NotNull(figure.square());
        }
        [Fact]
        public void IsSquareness()
        {
            Triangle figure = new Triangle(3, 4, 5);
            Assert.True(figure.squarenessCheck());
        }
        [Fact]
        public void TestCorrectAnswerForCircleForZero()
        {
            Circle figure = new Circle(0);
            Assert.Equal(0, figure.square());
        }
    }
}
