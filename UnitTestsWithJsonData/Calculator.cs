public class Calculator
{
    public double ComputeAverage(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("Numbers cannot be null or empty", nameof(numbers));
        }

        double sum = numbers.Sum();
        return sum / numbers.Count;
    }

    public int PerformAddition(int firstOperand, int secondOperand)
    {
        return firstOperand + secondOperand;
    }
}