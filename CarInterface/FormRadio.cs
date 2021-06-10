using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarInterface
{
    public partial class FormRadio : Form
    {
        private string station1 = "96,45";
        private string station2 = "99,85";
        private string station3 = "102,8";
        private string station4 = "105,2";
        private bool save = false;

        public FormRadio()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
    
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            double wave = Convert.ToDouble(Wave.Text);
            wave += 0.05;

            if (wave >= 108.1)
                wave = 94.9;

            Wave.Text = Convert.ToString(wave);  
        }

        private void Next_Click(object sender, EventArgs e)
        {
            double wave = Convert.ToDouble(Wave.Text);
            wave -= 0.05;

            if (wave <= 95)
                wave = 108.0;

            Wave.Text = Convert.ToString(wave);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Play.Visible = false;
            Pause.Visible = true;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Play.Visible = true;
            Pause.Visible = false;
        }

        private void Station1_Click(object sender, EventArgs e)
        {
            if (save)
            {
                station1 = Wave.Text;
                save = false;
            }

            Wave.Text = station1;
        }

        private void Station2_Click(object sender, EventArgs e)
        {
            if (save)
            {
                station2 = Wave.Text;
                save = false;
            }
                

            Wave.Text = station2;
        }

        private void Station3_Click(object sender, EventArgs e)
        {
            if (save)
            {
                station3 = Wave.Text;
                save = false;
            }

            Wave.Text = station3;
        }

        private void Station4_Click(object sender, EventArgs e)
        {
            if (save)
            {
                station4 = Wave.Text;
                save = false;
            }

            Wave.Text = station4;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            save = true;
        }
    }
}
