namespace DataLayer
{
    public interface IUnitOfWork
    {
        IAlumnRepository Alumns { get; }
        IEmployeeRepository Employees { get; }
        IEventRepository Events { get; }
    }
}