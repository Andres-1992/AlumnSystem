using BusinessEntities.Models;

namespace BusinessLayer
{
    public interface IEmployeeService
    {
        void AddEvent(Event events);
        void UpdateEmployee(Employee employee);
        void UpdateEvent(Event events);
    }
}