using MainProject.Classes;

namespace MainProject.Tests
{
    public class Tests
    {
        [Test]
        public void CalculatorAdditional_MustReturnRightValue()
        { 
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(3, 5) == 8);
        }

        [Test]
        public void CalculatorSubstraction_MustReturnRightValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(5, 3) == 2);
        }

        [Test]
        public void CalculatorMiltiplication_MustReturnRightValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(5, 3) == 15);
        }

        [Test]
        public void CalculatorDivision_MustReturnRightValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(15, 3) == 5);
        }

        [Test]
        public void CalculatorDivision_MustReturnDivisionByZeroException()
        {
            Calculator calculator = new Calculator();
            Assert.Catch<DivideByZeroException>(() => calculator.Division(5, 0));
        }
    }
}