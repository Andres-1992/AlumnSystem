using BusinessEntities.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IBusinessManager
    {
        IEnumerable<Event> GetEvent();
    }
}