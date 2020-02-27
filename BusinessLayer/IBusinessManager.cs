using BusinessEntities.Models;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IBusinessManager
    {
        public string Encrypt(string value);
        IEnumerable<Event> GetEvent();
    }
}