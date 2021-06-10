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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void BtnOverwiev_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Program?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {

                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
                else
                    list.Add(c);
            }

            return list;
        }

        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        private void ChangeFont_Click(object sender, EventArgs e)
        {
            List<Control> allControls = GetAllControls(Form1.project);
            allControls.ForEach(k => k.Font = new System.Drawing.Font("Nirmala UI", TextTrackBar.Value));
            Singleton.textSize = TextTrackBar.Value;
        }

        private void TextTrackBar_Scroll(object sender, EventArgs e)
        {
            TextSize.Text = TextTrackBar.Value.ToString();
        }

        private void ThemeChange_Click(object sender, EventArgs e)
        {
            List<Control> allControls = GetAllControls(Form1.project);
            allControls.ForEach(k => k.Font = new System.Drawing.Font("Nirmala UI", TextTrackBar.Value, FontStyle.Bold));
            allControls.ForEach(k => k.ForeColor = Color.FromArgb(255, 255, 255));

            Singleton.textSize = TextTrackBar.Value;
            Singleton.bgColor = Color.FromArgb(255, 255, 255);
        }
    }
}
