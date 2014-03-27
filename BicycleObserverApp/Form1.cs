using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BicycleObserverApp
{
    public partial class Form1 : Form
    {
        ISubject bicycleSubject;
        IObserver kphObserver;
        IObserver rpmObserver;
        IObserver calorieObserver;
        public Form1()
        {
            InitializeComponent();
        }

        private void changeSpeedBTN_Click(object sender, EventArgs e)
        {
            int speed;
            if (int.TryParse(speedTB.Text, out speed) == true && speedTB.Text.Length > 0)
            {

                if (int.Parse(speedTB.Text) > Constants.MAX_RPM)
                {
                    MessageBox.Show("Maximum allowable RPM is " + Constants.MAX_RPM + ".");
                }
                else
                {
                    bicycleSubject = new BicycleSubject(speed);
                    kphObserver = new KPHObserver(kphLBL, bicycleSubject);
                    rpmObserver = new RPMObserver(rpmDisplayLBL, bicycleSubject);
                    calorieObserver = new CalorieObserver(caloriesPerHourLBL, bicycleSubject);
                    bicycleSubject.NotifyObserver();
                }
            }
            else
            {
                MessageBox.Show("The input you tried to enter must be a valid integer greater than 0, e.g. 60.");
            }
        }
    }
}
