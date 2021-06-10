using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInterface
{
    public partial class FormOverwiev : Form
    {
        public FormOverwiev()
        {
            InitializeComponent();
            km2Miles();
            closeDoor();
        }

        private void closeDoor()
        {
            int metersSpeed = Convert.ToInt32(MetersSpeed.Text);
            if (metersSpeed >= 10)
                Lock.BackColor = Color.FromArgb(189, 183, 107);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void milesSpeed_Click(object sender, EventArgs e)
        {

        }

        private void km2Miles()
        {
            int metersSpeed = Convert.ToInt32(MetersSpeed.Text);
            int milesSpeed = (int)(metersSpeed / 1.609344);
            MilesSpeed.Text = Convert.ToString(milesSpeed);
        }

        private void Light_Click(object sender, EventArgs e)
        {
            if (Light.BackColor == Color.FromArgb(16, 0, 143))
                Light.BackColor = Color.FromArgb(16, 21, 43);
            else
                Light.BackColor = Color.FromArgb(16, 0, 143);
        }

        private void Brake_Click(object sender, EventArgs e)
        {
            if(Brake.BackColor == Color.FromArgb(116, 0, 0))
                Brake.BackColor = Color.FromArgb(16, 21, 43);
            else
                Brake.BackColor = Color.FromArgb(116, 0, 0);
        }

        private void Lock_Click(object sender, EventArgs e)
        {
            if(Lock.BackColor == Color.FromArgb(189, 183, 107))
                Lock.BackColor = Color.FromArgb(16, 21, 43);
            else
                Lock.BackColor = Color.FromArgb(189, 183, 107);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            rpm();
        }

        private void rpm()
        {
            double actualSpeed = Convert.ToDouble(MetersSpeed.Text);
            double destinySpeed = trackBar1.Value * 15;
            double acceleration = 2;
            int speed;
            int gear = trackBar1.Value;
            Gear.Text = Convert.ToString(gear);

            while (acceleration > 0)
            {
                if(destinySpeed > actualSpeed)
                {
                    actualSpeed += acceleration;
                }
                else
                {
                    actualSpeed -= acceleration;
                }

                speed = (int)actualSpeed;

                acceleration -= 0.1;
                
                MetersSpeed.Text = Convert.ToString(speed);
                if (speed > 0 && gear > 0)
                    RotationPerMinute.Text = Convert.ToString(speed / gear);
                else
                    RotationPerMinute.Text = "1";

                Thread.Sleep(100);
            }
        }
    }
}
