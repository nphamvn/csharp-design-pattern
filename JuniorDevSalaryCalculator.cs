public class JuniorDevSalaryCalculator : ISalaryCalculator
{
    public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
    {
        return reports
        .Where(r => r.Level == DeveloperLevel.Junior)
        .Select(r => r.CalculateSalary())
        .Sum();
    }
}