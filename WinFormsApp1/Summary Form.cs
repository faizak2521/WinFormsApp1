using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SummaryForm : Form
    {
        private decimal totalSalesDecimal;
        private int customerCountInteger;

        // 👇 THIS is the constructor your other form is calling
        public SummaryForm(decimal totalSales, int customerCount)
        {
            InitializeComponent();

            totalSalesDecimal = totalSales;
            customerCountInteger = customerCount;

            CloseButton.Click += CloseButton_Click;
        }

        private void Summary_Form_Load(object sender, EventArgs e)
        {
            decimal averageSalesDecimal = totalSalesDecimal / customerCountInteger;

            TotalSalesTextBox.Text = totalSalesDecimal.ToString("c");
            AverageSalesTextBox.Text = averageSalesDecimal.ToString("c");
            NumberCustomersTextBox.Text = customerCountInteger.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}