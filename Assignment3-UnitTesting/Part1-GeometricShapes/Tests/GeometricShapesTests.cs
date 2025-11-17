using Assignment3_UnitTesting.Part1_GeometricShapes.GeometricShapes;

namespace Assignment3_UnitTesting.Part1_GeometricShapes.Tests;

public class GeometricShapesTests
{
        [Test]
        public void TestSphereCalculateArea()
        {
            IShape sphere = new Sphere(5);
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            IShape sphere = new Sphere(5);
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }

        [Test]
        public void TestSphereWithRadiusOne()
        {
            IShape sphere = new Sphere(1);
            Assert.That(sphere.CalculateArea(), Is.EqualTo(12.566).Within(0.001));
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(4.189).Within(0.001));
        }

        [Test]
        public void TestSphereWithZeroRadius()
        {
            IShape sphere = new Sphere(0);
            Assert.That(sphere.CalculateArea(), Is.EqualTo(0));
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestSphereWithLargeRadius()
        {
            IShape sphere = new Sphere(100);
            Assert.That(sphere.CalculateArea(), Is.EqualTo(125663.706).Within(0.001));
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(4188790.205).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateArea()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
        }

        [Test]
        public void TestCylinderCalculateVolume()
        {
            IShape cylinder = new Cylinder(3, 7);
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
        }

        [Test]
        public void TestCylinderWithRadiusAndHeightOne()
        {
            IShape cylinder = new Cylinder(1, 1);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(12.566).Within(0.001));
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(3.142).Within(0.001));
        }

        [Test]
        public void TestCylinderWithZeroHeight()
        {
            IShape cylinder = new Cylinder(5, 0);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(157.080).Within(0.001));
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinderWithZeroRadius()
        {
            IShape cylinder = new Cylinder(0, 10);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(0));
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCylinderWithLargeValues()
        {
            IShape cylinder = new Cylinder(50, 100);
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(47123.890).Within(0.001));
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(785398.163).Within(0.001));
        }

        [Test]
        public void TestRectangleCalculateArea()
        {
            IShape rectangle = new Rectangle(4, 8);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32));
        }

        [Test]
        public void TestRectangleCalculateVolume()
        {
            IShape rectangle = new Rectangle(4, 8);
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangleSquare()
        {
            IShape rectangle = new Rectangle(5, 5);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(25));
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangleWithOneSideOne()
        {
            IShape rectangle = new Rectangle(1, 10);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(10));
        }

        [Test]
        public void TestRectangleWithZeroLength()
        {
            IShape rectangle = new Rectangle(0, 8);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangleWithZeroWidth()
        {
            IShape rectangle = new Rectangle(10, 0);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(0));
        }

        [Test]
        public void TestRectangleWithDecimalValues()
        {
            IShape rectangle = new Rectangle(3.5, 7.2);
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(25.2).Within(0.001));
        }

        [Test]
        public void TestCubeCalculateArea()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateArea(), Is.EqualTo(96));
        }

        [Test]
        public void TestCubeCalculateVolume()
        {
            IShape cube = new Cube(4);
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64));
        }

        [Test]
        public void TestCubeWithSideOne()
        {
            IShape cube = new Cube(1);
            Assert.That(cube.CalculateArea(), Is.EqualTo(6));
            Assert.That(cube.CalculateVolume(), Is.EqualTo(1));
        }

        [Test]
        public void TestCubeWithZeroSide()
        {
            IShape cube = new Cube(0);
            Assert.That(cube.CalculateArea(), Is.EqualTo(0));
            Assert.That(cube.CalculateVolume(), Is.EqualTo(0));
        }

        [Test]
        public void TestCubeWithDecimalSide()
        {
            IShape cube = new Cube(2.5);
            Assert.That(cube.CalculateArea(), Is.EqualTo(37.5).Within(0.001));
            Assert.That(cube.CalculateVolume(), Is.EqualTo(15.625).Within(0.001));
        }

        [Test]
        public void TestCubeWithLargeSide()
        {
            IShape cube = new Cube(10);
            Assert.That(cube.CalculateArea(), Is.EqualTo(600));
            Assert.That(cube.CalculateVolume(), Is.EqualTo(1000));
        }
}