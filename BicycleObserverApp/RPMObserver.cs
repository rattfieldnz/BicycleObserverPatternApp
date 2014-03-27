using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleObserverApp
{
    class RPMObserver:BicycleObserver
    {
        public RPMObserver(Label displayLabel, ISubject bikeSubject) :
            base(displayLabel, bikeSubject)
        {
        }

        public override void Update(int data_RPM)
        {
            currentRPM = data_RPM;
            displayLabel.Text = currentRPM.ToString("F2");
        }
    }
}
