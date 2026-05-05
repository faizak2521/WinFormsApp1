using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BillingForm : Form

    {

        private decimal subtotalDecimal, totalDecimal, grandTotalDecimal;
        private int customerCountInteger;

        private const decimal TAX_RATE_Decimal = 0.08m;
        private const decimal CAPPUCCINO_PRICE_Decimal = 2.00m;
        private const decimal ESPRESSO_PRICE_Decimal = 2.25m;
        private const decimal LATTE_PRICE_Decimal = 1.75m;
        private const decimal ICED_LATTE_PRICE_Decimal = 2.50m;
        private const decimal ICED_CAPPUCCINO_PRICE_Decimal = 2.75m;

        public BillingForm()
        {
            InitializeComponent();

            CalculateButton.Click += CalculateButton_Click;
            ClearButton.Click += ClearButton_Click;

            calculateSelectionToolStripMenuItem.Click += CalculateButton_Click;
            clearItemToolStripMenuItem.Click += ClearButton_Click;
            newOrderToolStripMenuItem.Click += newOrderToolStripMenuItem_Click;
            summaryToolStripMenuItem.Click += summaryToolStripMenuItem_Click;
            exitToolStripMenuItem2.Click += exitToolStripMenuItem2_Click;
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;

        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal priceDecimal = 0m;

            if (CappuccinoRadioButton.Checked)
                priceDecimal = CAPPUCCINO_PRICE_Decimal;
            else if (EspressoRadioButton.Checked)
                priceDecimal = ESPRESSO_PRICE_Decimal;
            else if (LatteRadioButton.Checked)
                priceDecimal = LATTE_PRICE_Decimal;
            else if (IcedLatteRadioButton.Checked)
                priceDecimal = ICED_LATTE_PRICE_Decimal;
            else if (IcedCappuccinoRadioButton.Checked)
                priceDecimal = ICED_CAPPUCCINO_PRICE_Decimal;

            try
            {
                int quantityInteger = int.Parse(QuantityTextBox.Text);

                decimal itemAmountDecimal = priceDecimal * quantityInteger;
                subtotalDecimal += itemAmountDecimal;

                decimal taxDecimal = TaxCheckBox.Checked ? FindTax(subtotalDecimal) : 0m;
                totalDecimal = subtotalDecimal + taxDecimal;

                ItemAmountTextBox.Text = itemAmountDecimal.ToString("c");
                SubTotalTextBox.Text = subtotalDecimal.ToString("c");
                TaxTextBox.Text = taxDecimal.ToString("c");
                TotalTextBox.Text = totalDecimal.ToString("c");

                TaxCheckBox.Enabled = false;
                ClearButton.Enabled = true;
                clearItemToolStripMenuItem.Enabled = true;
                newOrderToolStripMenuItem.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Quantity must be numeric.",
                    "Data Entry Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                QuantityTextBox.Focus();
                QuantityTextBox.SelectAll();
            }
        }

        private decimal FindTax(decimal amountDecimal)
        {
            return amountDecimal * TAX_RATE_Decimal;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CappuccinoRadioButton.Checked = true;
            ItemAmountTextBox.Clear();
            QuantityTextBox.Clear();
            QuantityTextBox.Focus();
        }

        private void newOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Clear the current order figures?",
                "Clear Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                ClearButton_Click(sender, e);

                SubTotalTextBox.Clear();
                TaxTextBox.Clear();
                TotalTextBox.Clear();

                if (subtotalDecimal != 0m)
                {
                    grandTotalDecimal += totalDecimal;
                    customerCountInteger++;

                    subtotalDecimal = 0m;
                    totalDecimal = 0m;
                }

                TaxCheckBox.Enabled = true;
                TaxCheckBox.Checked = false;

                ClearButton.Enabled = false;
                clearItemToolStripMenuItem.Enabled = false;
                newOrderToolStripMenuItem.Enabled = false;
            }
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // finalize current order properly using your existing logic
            if (totalDecimal != 0m)
                newOrderToolStripMenuItem_Click(sender, e);

            if (customerCountInteger > 0)
            {
                SummaryForm summaryForm = new SummaryForm(
                    grandTotalDecimal,
                    customerCountInteger
                );

                summaryForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No sales data to summarize.",
                    "Coffee Sales Summary",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog1.Font = SubTotalTextBox.Font;

            if (FontDialog1.ShowDialog() == DialogResult.OK)
            {
                SubTotalTextBox.Font = FontDialog1.Font;
                TaxTextBox.Font = FontDialog1.Font;
                TotalTextBox.Font = FontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog1.Color = SubTotalTextBox.ForeColor;

            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                SubTotalTextBox.ForeColor = ColorDialog1.Color;
                TaxTextBox.ForeColor = ColorDialog1.Color;
                TotalTextBox.ForeColor = ColorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void LatteRadioButton_CheckedChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void fontDialog1_Apply(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void fIleToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void IcedCappuccinoRadioButton_CheckedChanged(object sender, EventArgs e) { }
    }
}