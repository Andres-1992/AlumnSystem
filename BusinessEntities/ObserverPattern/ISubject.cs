using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.ObserverPattern
{
  public interface ISubject
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify();
    }
}
