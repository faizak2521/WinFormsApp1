namespace WinFormsApp1
{
    partial class BillingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrderInformation = new GroupBox();
            QuantityTextBox = new TextBox();
            CoffeeSelections = new GroupBox();
            IcedCappuccinoRadioButton = new RadioButton();
            IcedLatteRadioButton = new RadioButton();
            LatteRadioButton = new RadioButton();
            EspressoRadioButton = new RadioButton();
            CappuccinoRadioButton = new RadioButton();
            groupBox2 = new GroupBox();
            label1 = new Label();
            TaxCheckBox = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ItemAmountTextBox = new TextBox();
            SubTotalTextBox = new TextBox();
            TaxTextBox = new TextBox();
            TotalTextBox = new TextBox();
            CalculateButton = new Button();
            ClearButton = new Button();
            MenuStrip1 = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            newOrderToolStripMenuItem = new ToolStripMenuItem();
            summaryToolStripMenuItem = new ToolStripMenuItem();
            calculateSelectionToolStripMenuItem = new ToolStripMenuItem();
            clearItemToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            fontToolStripMenuItem = new ToolStripMenuItem();
            ColorDialog1 = new ColorDialog();
            colorToolStripMenuItem = new ToolStripMenuItem();
            FontDialog1 = new FontDialog();
            exitToolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem2 = new ToolStripMenuItem();
            OrderInformation.SuspendLayout();
            CoffeeSelections.SuspendLayout();
            groupBox2.SuspendLayout();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // OrderInformation
            // 
            OrderInformation.Controls.Add(ClearButton);
            OrderInformation.Controls.Add(CalculateButton);
            OrderInformation.Controls.Add(ItemAmountTextBox);
            OrderInformation.Controls.Add(label2);
            OrderInformation.Controls.Add(TaxCheckBox);
            OrderInformation.Controls.Add(label1);
            OrderInformation.Controls.Add(QuantityTextBox);
            OrderInformation.Controls.Add(CoffeeSelections);
            OrderInformation.Location = new Point(12, 51);
            OrderInformation.Name = "OrderInformation";
            OrderInformation.Size = new Size(776, 232);
            OrderInformation.TabIndex = 0;
            OrderInformation.TabStop = false;
            OrderInformation.Text = "Order Information";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(84, 24);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(77, 23);
            QuantityTextBox.TabIndex = 1;
            // 
            // CoffeeSelections
            // 
            CoffeeSelections.Controls.Add(IcedCappuccinoRadioButton);
            CoffeeSelections.Controls.Add(IcedLatteRadioButton);
            CoffeeSelections.Controls.Add(LatteRadioButton);
            CoffeeSelections.Controls.Add(EspressoRadioButton);
            CoffeeSelections.Controls.Add(CappuccinoRadioButton);
            CoffeeSelections.Location = new Point(388, 24);
            CoffeeSelections.Name = "CoffeeSelections";
            CoffeeSelections.Size = new Size(374, 187);
            CoffeeSelections.TabIndex = 0;
            CoffeeSelections.TabStop = false;
            CoffeeSelections.Text = "Coffee Selections";
            // 
            // IcedCappuccinoRadioButton
            // 
            IcedCappuccinoRadioButton.AutoSize = true;
            IcedCappuccinoRadioButton.Location = new Point(16, 128);
            IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton";
            IcedCappuccinoRadioButton.Size = new Size(114, 19);
            IcedCappuccinoRadioButton.TabIndex = 6;
            IcedCappuccinoRadioButton.Text = "Iced Ca&ppuccino";
            IcedCappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // IcedLatteRadioButton
            // 
            IcedLatteRadioButton.AutoSize = true;
            IcedLatteRadioButton.Location = new Point(16, 103);
            IcedLatteRadioButton.Name = "IcedLatteRadioButton";
            IcedLatteRadioButton.Size = new Size(76, 19);
            IcedLatteRadioButton.TabIndex = 5;
            IcedLatteRadioButton.Text = "&Iced Latte";
            IcedLatteRadioButton.UseVisualStyleBackColor = true;
            // 
            // LatteRadioButton
            // 
            LatteRadioButton.AutoSize = true;
            LatteRadioButton.Location = new Point(16, 78);
            LatteRadioButton.Name = "LatteRadioButton";
            LatteRadioButton.Size = new Size(51, 19);
            LatteRadioButton.TabIndex = 2;
            LatteRadioButton.Text = "La&tte";
            LatteRadioButton.UseVisualStyleBackColor = true;
            //LatteRadioButton.CheckedChanged += LatteRadioButton_CheckedChanged;
            // 
            // EspressoRadioButton
            // 
            EspressoRadioButton.AutoSize = true;
            EspressoRadioButton.Location = new Point(16, 53);
            EspressoRadioButton.Name = "EspressoRadioButton";
            EspressoRadioButton.Size = new Size(70, 19);
            EspressoRadioButton.TabIndex = 1;
            EspressoRadioButton.Text = "Espress&o";
            EspressoRadioButton.UseVisualStyleBackColor = true;
            // 
            // CappuccinoRadioButton
            // 
            CappuccinoRadioButton.AutoSize = true;
            CappuccinoRadioButton.Checked = true;
            CappuccinoRadioButton.Location = new Point(16, 28);
            CappuccinoRadioButton.Name = "CappuccinoRadioButton";
            CappuccinoRadioButton.Size = new Size(89, 19);
            CappuccinoRadioButton.TabIndex = 0;
            CappuccinoRadioButton.TabStop = true;
            CappuccinoRadioButton.Text = "C&appuccino";
            CappuccinoRadioButton.UseVisualStyleBackColor = true;
            CappuccinoRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TotalTextBox);
            groupBox2.Controls.Add(TaxTextBox);
            groupBox2.Controls.Add(SubTotalTextBox);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 309);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "&Quantity";
            // 
            // TaxCheckBox
            // 
            TaxCheckBox.AutoSize = true;
            TaxCheckBox.Location = new Point(25, 63);
            TaxCheckBox.Name = "TaxCheckBox";
            TaxCheckBox.Size = new Size(73, 19);
            TaxCheckBox.TabIndex = 4;
            TaxCheckBox.Text = "Ta&keout?";
            TaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 196);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "Item Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 27);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Subtotal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 62);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 7;
            label4.Text = "Tax (if Takeout)";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 99);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Total Due";
            // 
            // ItemAmountTextBox
            // 
            ItemAmountTextBox.Location = new Point(109, 188);
            ItemAmountTextBox.Name = "ItemAmountTextBox";
            ItemAmountTextBox.ReadOnly = true;
            ItemAmountTextBox.Size = new Size(100, 23);
            ItemAmountTextBox.TabIndex = 6;
            ItemAmountTextBox.TabStop = false;
            // 
            // SubTotalTextBox
            // 
            SubTotalTextBox.Location = new Point(82, 19);
            SubTotalTextBox.Name = "SubTotalTextBox";
            SubTotalTextBox.ReadOnly = true;
            SubTotalTextBox.Size = new Size(100, 23);
            SubTotalTextBox.TabIndex = 9;
            SubTotalTextBox.TabStop = false;
            // 
            // TaxTextBox
            // 
            TaxTextBox.Location = new Point(118, 59);
            TaxTextBox.Name = "TaxTextBox";
            TaxTextBox.ReadOnly = true;
            TaxTextBox.Size = new Size(100, 23);
            TaxTextBox.TabIndex = 10;
            TaxTextBox.TabStop = false;
            // 
            // TotalTextBox
            // 
            TotalTextBox.Location = new Point(84, 96);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.ReadOnly = true;
            TotalTextBox.Size = new Size(100, 23);
            TotalTextBox.TabIndex = 11;
            TotalTextBox.TabStop = false;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(38, 114);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(87, 44);
            CalculateButton.TabIndex = 7;
            CalculateButton.Text = "&Calculate Selection";
            CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Enabled = false;
            ClearButton.Location = new Point(131, 114);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(87, 44);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "C&lear for Next Item";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // MenuStrip1
            // 
            MenuStrip1.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, exitToolStripMenuItem, helpToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(800, 24);
            MenuStrip1.TabIndex = 2;
            MenuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newOrderToolStripMenuItem, summaryToolStripMenuItem, exitToolStripMenuItem1, exitToolStripMenuItem2 });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(37, 20);
            fIleToolStripMenuItem.Text = "&FIle";
            fIleToolStripMenuItem.Click += fIleToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculateSelectionToolStripMenuItem, clearItemToolStripMenuItem, toolStripSeparator1, fontToolStripMenuItem, colorToolStripMenuItem });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(39, 20);
            exitToolStripMenuItem.Text = "E&dit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // newOrderToolStripMenuItem
            // 
            newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            newOrderToolStripMenuItem.Size = new Size(180, 22);
            newOrderToolStripMenuItem.Text = "&New Order";
            // 
            // summaryToolStripMenuItem
            // 
            summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            summaryToolStripMenuItem.Size = new Size(180, 22);
            summaryToolStripMenuItem.Text = "&Summary";
            // 
            // calculateSelectionToolStripMenuItem
            // 
            calculateSelectionToolStripMenuItem.Name = "calculateSelectionToolStripMenuItem";
            calculateSelectionToolStripMenuItem.Size = new Size(180, 22);
            calculateSelectionToolStripMenuItem.Text = "&Calculate Selection";
            // 
            // clearItemToolStripMenuItem
            // 
            clearItemToolStripMenuItem.Name = "clearItemToolStripMenuItem";
            clearItemToolStripMenuItem.Size = new Size(180, 22);
            clearItemToolStripMenuItem.Text = "Clear &Item";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "&Font...";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(180, 22);
            colorToolStripMenuItem.Text = "C&olor...";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(177, 6);
            //exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem2
            // 
            exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            exitToolStripMenuItem2.Size = new Size(180, 22);
            exitToolStripMenuItem2.Text = "E&xit";
            // 
            // BillingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 447);
            Controls.Add(groupBox2);
            Controls.Add(OrderInformation);
            Controls.Add(MenuStrip1);
            MainMenuStrip = MenuStrip1;
            Name = "BillingForm";
            Text = "Billing Form";
            Load += Form1_Load;
            OrderInformation.ResumeLayout(false);
            OrderInformation.PerformLayout();
            CoffeeSelections.ResumeLayout(false);
            CoffeeSelections.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox OrderInformation;
        private GroupBox CoffeeSelections;
        private GroupBox groupBox2;
        private RadioButton LatteRadioButton;
        private RadioButton EspressoRadioButton;
        private RadioButton CappuccinoRadioButton;
        private RadioButton IcedCappuccinoRadioButton;
        private RadioButton IcedLatteRadioButton;
        private TextBox QuantityTextBox;
        private CheckBox TaxCheckBox;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox ItemAmountTextBox;
        private TextBox TotalTextBox;
        private TextBox TaxTextBox;
        private TextBox SubTotalTextBox;
        private Button ClearButton;
        private Button CalculateButton;
        private MenuStrip MenuStrip1;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem newOrderToolStripMenuItem;
        private ToolStripMenuItem summaryToolStripMenuItem;
        private ToolStripMenuItem calculateSelectionToolStripMenuItem;
        private ToolStripMenuItem clearItemToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog ColorDialog1;
        private FontDialog FontDialog1;
        private ToolStripSeparator exitToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem2;
    }
}
