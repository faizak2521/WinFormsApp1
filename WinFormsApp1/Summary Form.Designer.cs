namespace WinFormsApp1
{
    partial class SummaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CloseButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TotalSalesTextBox = new TextBox();
            AverageSalesTextBox = new TextBox();
            NumberCustomersTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(423, 306);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 0;
            CloseButton.Text = "&Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 136);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Total Sales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 181);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Average Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 225);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 3;
            label3.Text = "Number of Customers";
            // 
            // TotalSalesTextBox
            // 
            TotalSalesTextBox.Location = new Point(297, 128);
            TotalSalesTextBox.Name = "TotalSalesTextBox";
            TotalSalesTextBox.ReadOnly = true;
            TotalSalesTextBox.Size = new Size(100, 23);
            TotalSalesTextBox.TabIndex = 4;
            TotalSalesTextBox.TabStop = false;
            // 
            // AverageSalesTextBox
            // 
            AverageSalesTextBox.Location = new Point(297, 173);
            AverageSalesTextBox.Name = "AverageSalesTextBox";
            AverageSalesTextBox.ReadOnly = true;
            AverageSalesTextBox.Size = new Size(100, 23);
            AverageSalesTextBox.TabIndex = 8;
            AverageSalesTextBox.TabStop = false;
            // 
            // NumberCustomersTextBox
            // 
            NumberCustomersTextBox.Location = new Point(297, 217);
            NumberCustomersTextBox.Name = "NumberCustomersTextBox";
            NumberCustomersTextBox.ReadOnly = true;
            NumberCustomersTextBox.Size = new Size(100, 23);
            NumberCustomersTextBox.TabIndex = 9;
            NumberCustomersTextBox.TabStop = false;
            // 
            // label4
            // 
            label4.Location = new Point(136, 52);
            label4.Name = "label4";
            label4.Size = new Size(324, 42);
            label4.TabIndex = 10;
            label4.Text = "R'n R for Reading and Refreshment";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // SummaryForm
            // 
            AcceptButton = CloseButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(label4);
            Controls.Add(NumberCustomersTextBox);
            Controls.Add(AverageSalesTextBox);
            Controls.Add(TotalSalesTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CloseButton);
            Name = "SummaryForm";
            Text = "R'n R for Reading and Refreshment";
            Load += Summary_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TotalSalesTextBox;
        private TextBox AverageSalesTextBox;
        private TextBox NumberCustomersTextBox;
        private Label label4;
    }
}