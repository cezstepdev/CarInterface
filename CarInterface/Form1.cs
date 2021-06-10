using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarInterface
{
    public partial class Form1 : Form
    {
        public static Form1 project;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            project = this;
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            PnlNav.Height = BtnOverwiev.Height;
            PnlNav.Top = BtnOverwiev.Top;
            PnlNav.Left = BtnOverwiev.Left;

            LblTitle.Text = "Overwiev";
            this.PnlFormLoader.Controls.Clear();
            FormOverwiev formOverwiev = new FormOverwiev()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formOverwiev.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formOverwiev);
            formOverwiev.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOverwiev_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnOverwiev.Height;
            PnlNav.Top = BtnOverwiev.Top;
            PnlNav.Left = BtnOverwiev.Left;

            LblTitle.Text = "Overwiev";
            this.PnlFormLoader.Controls.Clear();
            FormOverwiev formOverwiev = new FormOverwiev()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formOverwiev.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formOverwiev);
            formOverwiev.Show();
        }

        private void BtnAnalysis_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAnalysis.Height;
            PnlNav.Top = BtnAnalysis.Top;
            PnlNav.Left = BtnAnalysis.Left;

            LblTitle.Text = "Analysis";
            this.PnlFormLoader.Controls.Clear();
            FormAnalysis formAnalysis = new FormAnalysis()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formAnalysis.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formAnalysis);
            formAnalysis.Show();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHelp.Height;
            PnlNav.Top = BtnHelp.Top;
            PnlNav.Left = BtnHelp.Left;

            LblTitle.Text = "Help";
            this.PnlFormLoader.Controls.Clear();
            FormHelp formHelp = new FormHelp()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formHelp.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formHelp);
            formHelp.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnSettings.Height;
            PnlNav.Top = BtnSettings.Top;
            PnlNav.Left = BtnSettings.Left;

            LblTitle.Text = "Settings";
            this.PnlFormLoader.Controls.Clear();
            FormSettings formSettings = new FormSettings()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formSettings.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formSettings);
            formSettings.Show();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            LblTitle.Text = "Radio";
            this.PnlFormLoader.Controls.Clear();
            FormRadio formRadio = new FormRadio()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            formRadio.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formRadio);
            formRadio.Show();
        }
    }
}
