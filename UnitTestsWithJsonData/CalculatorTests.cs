using UnitTestsWithJsonData.Addition;
using UnitTestsWithJsonData.Average;

namespace UnitTestsWithJsonData
{
    public class CalculatorTests
    {
        [Theory]
        [ClassData(typeof(AdditionOperationClassData))]
        public void PerformAddition_ReturnsMatchingOutput(AdditionOperationTestSet entry)
        {
            var calculator = new Calculator();

            var result = calculator.PerformAddition(entry.FirstOperand, entry.SecondOperand);

            Assert.Equal(result, entry.ExpectedResult);
        }

        [Theory]
        [ClassData(typeof(AverageOperationClassData))]
        public void ComputeAverage_ReturnsMatchingOutput(AverageOperationTestSet entry)
        {
            var calculator = new Calculator();

            var result = calculator.ComputeAverage(entry.Numbers);

            Assert.Equal(result, entry.ExpectedAverage);
        }
    }
}