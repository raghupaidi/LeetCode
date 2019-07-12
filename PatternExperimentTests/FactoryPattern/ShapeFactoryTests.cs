using NUnit.Framework;
using PatternExperiments.FactoryPattern.Implementation;

namespace PatternExperiments.FactoryPattern.Tests
{
    [TestFixture()]
    public class ShapeFactoryTests
    {

        public ShapeFactory _ShapeFactory { get; set; }

        [OneTimeSetUp()]
        public void Setup()
        {
            _ShapeFactory = new ShapeFactory();
        }

        [Test()]
        public void GetShapeTest_Circle()
        {
            var result = _ShapeFactory.GetShape("Circle");
            Assert.True( result.GetType() == typeof(Circle),"Not a circle" );
        }
        [Test()]
        public void GetShapeTest_Rectangle()
        {
            var result = _ShapeFactory.GetShape("Rectangle");
            Assert.True(result.GetType() == typeof(Rectangle), "Not a Rectangle");
        }
        [Test()]
        public void GetShapeTest_Square()
        {
            var result = _ShapeFactory.GetShape("Square");
            Assert.True(result.GetType() == typeof(Square), "Not a Square");
        }
        [Test()]
        public void GetShapeTest_Default()
        {
            var result = _ShapeFactory.GetShape("Circle");
            Assert.True(result.GetType() == typeof(Circle), "Not a circle");
        }
    }
}