using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleObserverApp
{
    /// <summary>
    /// This is the interface responsible for an 
    /// observer's behaviour - updating and 
    /// displaying computed data.
    /// </summary>
    public interface IObserver
    {
        void Update(int data);
        void Display();
    }
}
