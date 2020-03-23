using DataLayer;
using DataLayer.Contexts;

namespace BusinessLayer
{
    public class Services : IServices
    {


        public Services(AppDbContext appDbContext, UnitOfWork unitOfWork)
        {
            GetServices = new GetService(appDbContext, unitOfWork);
            GetCollectionServices = new GetCollectionService(appDbContext, unitOfWork);
            UpdateServices = new UpdateService(appDbContext, unitOfWork);
            DeleteServices = new DeleteService(appDbContext, unitOfWork);
            AddServices = new AddService(appDbContext, unitOfWork);
            LogInServices = new LogInService(appDbContext, unitOfWork);
        }


        public ILogInService LogInServices { get; private set; }
        public IGetService GetServices { get; private set; }
        public IGetCollectionService GetCollectionServices { get; private set; }
        public IUpdateService UpdateServices { get; private set; }
        public IDeleteService DeleteServices { get; private set; }
        public IAddService AddServices { get; private set; }
    }
}
