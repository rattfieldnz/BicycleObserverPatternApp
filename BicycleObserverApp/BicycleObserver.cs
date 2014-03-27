using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleObserverApp
{
    /// <summary>
    /// This is an abstract class which will be the 
    /// parent class of any implemented observers.
    /// </summary>
    public abstract class BicycleObserver:IObserver
    {
        /// <summary>
        /// Declare datafields necessary for the observer
        /// to perform it's functions - the current RPM, 
        /// the updated computed value, the label to 
        /// display the computed value, and the subject 
        /// which pushes information to the observers.
        /// </summary>
        protected int currentRPM;
        protected double currentComputedValue;
        protected Label displayLabel;
        protected ISubject bikeSubject;

        /// <summary>
        /// Constructor - initialises the label responsible for displaying 
        /// computed results, and the subject which will push information
        /// to the observers.
        /// </summary>
        /// <param name="displayLabel">The label to display computed results.</param>
        /// <param name="bikeSubject">The subject to push notifications to it's observers.</param>
        public BicycleObserver(Label displayLabel, ISubject bikeSubject)
        {
            this.displayLabel = displayLabel;
            this.bikeSubject = bikeSubject;

            currentRPM = 0;
            currentComputedValue = 0.0;

            ///<summary>
            ///Ensuring that the observer is added to the subject
            ///on creation.
            ///</summary>
            bikeSubject.AddObserver(this);
        }

        /// <summary>
        /// An abstract method which will perform unique computations
        /// for each given subject.
        /// </summary>
        /// <param name="data"></param>
        public abstract void Update(int data);

        /// <summary>
        /// A method to display the computed results to the form interface.
        /// </summary>
        public void Display()
        {
            displayLabel.Text = string.Format("{0:0.00}", currentComputedValue);
        }
    }
}
