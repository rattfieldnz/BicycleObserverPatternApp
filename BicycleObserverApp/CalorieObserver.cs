using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleObserverApp
{
    class CalorieObserver:BicycleObserver
    {
        public CalorieObserver(Label displayLabel, ISubject bikeSubject) :
            base(displayLabel, bikeSubject)
        {
        }


        public override void Update(int data_RPM)
        {
            currentComputedValue = ((Constants.CALORIES_PER_MINUTE * data_RPM) * Constants.MINUTES_IN_HOUR) / (Constants.MINUTES_IN_HOUR * Constants.INT_DIV_BY_INT_DBL);
            this.Display();
        }
    }
}
