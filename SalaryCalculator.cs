public class SalaryCalculator
{
    private ISalaryCalculator _salaryCalculator;
    public SalaryCalculator(ISalaryCalculator calculator)
    {
        _salaryCalculator = calculator;
    }

    public void SetCalculator(ISalaryCalculator calculator)
    {
        _salaryCalculator = calculator;
    }
    public double Calculate(IEnumerable<DeveloperReport> reports)
    {
        return _salaryCalculator.CalculateTotalSalary(reports);
    }
}