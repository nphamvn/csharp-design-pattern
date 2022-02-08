public abstract class EmployeeBuilder
{
    protected Employee employee;
    public EmployeeBuilder()
    {
        employee = new Employee();
    }
    public Employee Build()
    {
        return employee;
    }
}