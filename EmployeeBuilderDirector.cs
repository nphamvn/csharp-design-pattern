public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
{
    public static EmployeeBuilderDirector NewEmployee()
    {
        return new EmployeeBuilderDirector();
    }
}