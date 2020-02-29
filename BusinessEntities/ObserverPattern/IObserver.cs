using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.ObserverPattern
{
   public interface IObserver
    {
        void Update(ISubject subject);
    }
}
