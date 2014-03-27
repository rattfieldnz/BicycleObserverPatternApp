using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleObserverApp
{
    /// <summary>
    /// This is subject class, which is responsible for
    /// pushing information to it's subscribed observers.
    /// </summary>
    class BicycleSubject:ISubject
    {
        /// <summary>
        /// Declaring a list of observers.
        /// </summary>
        private List<IObserver> bicycleObservers;

        /// <summary>
        /// Declaring the value to hold RPM data.
        /// </summary>
        private int data_RPM;

        /// <summary>
        /// Constructor - initilise the subject 
        /// with data for the RPM.
        /// </summary>
        /// <param name="data_RPM">Data to push to observers.</param>
        public BicycleSubject(int data_RPM)
        {
            //Initialise
            this.data_RPM = data_RPM;
            this.bicycleObservers = new List<IObserver>();
        }

        /// <summary>
        /// This method adds an observer to the subject's observer list.
        /// </summary>
        /// <param name="observer">The observer to add.</param>
        public void AddObserver(IObserver observer)
        {
            bicycleObservers.Add(observer);
        }

        /// <summary>
        /// This method removes an observer to the subject's observer list.
        /// </summary>
        /// <param name="observer">The observer to remove.</param>
        public void RemoveObserver(IObserver observer)
        {
            if (bicycleObservers.Count > 0)
            {
                bicycleObservers.Remove(observer);
            }
            else
            {
                MessageBox.Show("There are no observers in the observer list.");
            }
        }

        public void NotifyObserver()
        {
            foreach (BicycleObserver currentObserver in bicycleObservers)
            {
                currentObserver.Update(data_RPM);
            }
        }
    }
}
