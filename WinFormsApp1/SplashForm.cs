using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SplashForm : Form
    {
        private System.Windows.Forms.Timer splashTimer = new System.Windows.Forms.Timer();

        public SplashForm()
        {
            InitializeComponent();

            splashTimer.Interval = 2000; // 2 seconds
            splashTimer.Tick += SplashTimer_Tick;
            splashTimer.Start();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Stop();

            BillingForm mainForm = new BillingForm();
            mainForm.FormClosed += (s, args) => this.Close();
            mainForm.Show();

            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}