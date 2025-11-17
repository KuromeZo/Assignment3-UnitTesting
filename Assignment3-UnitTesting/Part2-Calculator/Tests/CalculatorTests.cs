namespace Assignment3_UnitTesting.Part2_Calculator.Tests;

public class CalculatorTests
    {
        [Test]
        public void TestAdditionPositiveNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(15));
        }

        [Test]
        public void TestAdditionNegativeNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(-10, -5, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(-15));
        }

        [Test]
        public void TestAdditionMixedNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, -5, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(5));
        }

        [Test]
        public void TestAdditionWithZero()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 0, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(10));
        }

        [Test]
        public void TestAdditionDecimalNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(3.5, 2.7, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(6.2).Within(0.001));
        }

        [Test]
        public void TestSubtractionPositiveNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(5));
        }

        [Test]
        public void TestSubtractionNegativeNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(-10, -5, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(-5));
        }

        [Test]
        public void TestSubtractionResultingNegative()
        {
            Calculator.Calculator calc = new Calculator.Calculator(5, 10, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(-5));
        }

        [Test]
        public void TestSubtractionWithZero()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 0, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(10));
        }

        [Test]
        public void TestSubtractionDecimalNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(5.8, 2.3, "-");
            Assert.That(calc.Calculate(), Is.EqualTo(3.5).Within(0.001));
        }

        [Test]
        public void TestMultiplicationPositiveNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(50));
        }

        [Test]
        public void TestMultiplicationNegativeNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(-10, -5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(50));
        }

        [Test]
        public void TestMultiplicationMixedNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, -5, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(-50));
        }

        [Test]
        public void TestMultiplicationByZero()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 0, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }

        [Test]
        public void TestMultiplicationByOne()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 1, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(10));
        }

        [Test]
        public void TestMultiplicationDecimalNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(3.5, 2.0, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(7.0).Within(0.001));
        }

        [Test]
        public void TestMultiplicationLargeNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(1000, 2000, "*");
            Assert.That(calc.Calculate(), Is.EqualTo(2000000));
        }

        [Test]
        public void TestDivisionPositiveNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void TestDivisionNegativeNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(-10, -5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(2));
        }

        [Test]
        public void TestDivisionMixedNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, -5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(-2));
        }

        [Test]
        public void TestDivisionByOne()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 1, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(10));
        }

        [Test]
        public void TestDivisionResultingDecimal()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 4, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(2.5).Within(0.001));
        }

        [Test]
        public void TestDivisionZeroByNumber()
        {
            Calculator.Calculator calc = new Calculator.Calculator(0, 5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(0));
        }

        [Test]
        public void TestDivisionDecimalNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(7.5, 2.5, "/");
            Assert.That(calc.Calculate(), Is.EqualTo(3.0).Within(0.001));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 0, "/");
            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperation()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "%");
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperationWithSymbol()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "^");
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }

        [Test]
        public void TestInvalidOperationWithWord()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "plus");
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }

        [Test]
        public void TestEmptyOperation()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "");
            Assert.Throws<InvalidOperationException>(() => calc.Calculate());
        }

        [Test]
        public void TestVeryLargeNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(1000000, 1000000, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(2000000));
        }

        [Test]
        public void TestVerySmallNumbers()
        {
            Calculator.Calculator calc = new Calculator.Calculator(0.0001, 0.0002, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(0.0003).Within(0.00001));
        }

        [Test]
        public void TestMaxDoubleValue()
        {
            Calculator.Calculator calc = new Calculator.Calculator(double.MaxValue, 0, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(double.MaxValue));
        }

        [Test]
        public void TestMinDoubleValue()
        {
            Calculator.Calculator calc = new Calculator.Calculator(double.MinValue, 0, "+");
            Assert.That(calc.Calculate(), Is.EqualTo(double.MinValue));
        }

        [Test]
        public void TestToStringValidOperation()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 5, "+");
            string result = calc.ToString();
            Assert.That(result, Does.Contain("10"));
            Assert.That(result, Does.Contain("5"));
            Assert.That(result, Does.Contain("15"));
        }

        [Test]
        public void TestToStringDivisionByZero()
        {
            Calculator.Calculator calc = new Calculator.Calculator(10, 0, "/");
            string result = calc.ToString();
            Assert.That(result, Does.Contain("Error"));
        }
    }