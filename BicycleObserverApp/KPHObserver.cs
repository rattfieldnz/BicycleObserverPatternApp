using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleObserverApp
{
    class KPHObserver:BicycleObserver
    {
        public KPHObserver(Label displayLabel, ISubject bikeSubject) :
            base(displayLabel, bikeSubject)
        {
        }
        public override void Update(int data_RPM)
        {
            currentComputedValue = ((data_RPM * Constants.MINUTES_IN_HOUR) * Constants.WHEEL_CIRCUMFERENCE) / (Constants.CM_IN_KM * Constants.INT_DIV_BY_INT_DBL);
            this.Display();
        }
    }
}
