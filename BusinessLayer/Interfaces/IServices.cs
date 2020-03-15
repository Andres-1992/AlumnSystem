namespace BusinessLayer
{
    public interface IServices
    {

        ILogInService LogInServices { get; }
        IGetService GetServices { get; }
        IGetCollectionService GetCollectionServices { get; }
        IUpdateService UpdateServices { get; }
        IDeleteService DeleteServices { get; }
        IAddService AddServices { get; }

    }
}