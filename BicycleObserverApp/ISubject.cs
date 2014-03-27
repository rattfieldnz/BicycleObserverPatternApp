using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleObserverApp
{
    /// <summary>
    /// This is the interface responsible for the "subject's"
    /// behaviour - adding, removing, and notifying observers.
    /// </summary>
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
