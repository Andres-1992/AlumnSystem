namespace BusinessLayer
{
    public interface IServices
    {
        IAlumnService AlumnServices { get; }
        IBusinessManager BusinessManager { get; }
        IEmployeeService EmployeeServices { get; }
        ILogInService LogInServices { get; }
    }
}