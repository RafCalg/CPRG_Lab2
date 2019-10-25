namespace CPRG_Lab2
{
    partial class CustomerBill
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
            this.accountNoLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.usageLabel = new System.Windows.Forms.Label();
            this.usageTextBox = new System.Windows.Forms.TextBox();
            this.offPeakUsageLabel = new System.Windows.Forms.Label();
            this.offPeakUsageTextBox = new System.Windows.Forms.TextBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.calculateBillButton = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.ListBox();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.totalCustomersLabel = new System.Windows.Forms.Label();
            this.totalCustomersTextBox = new System.Windows.Forms.TextBox();
            this.chargesResidentialLabel = new System.Windows.Forms.Label();
            this.chargesResidentialTextBox = new System.Windows.Forms.TextBox();
            this.chargesCommercialLabel = new System.Windows.Forms.Label();
            this.chargesCommercialTextBox = new System.Windows.Forms.TextBox();
            this.chargesIndustrialLabel = new System.Windows.Forms.Label();
            this.chargesIndustrialTextBox = new System.Windows.Forms.TextBox();
            this.statisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.chargesAllCustomersTextBox = new System.Windows.Forms.TextBox();
            this.chargesAllCustomersTypesLabel = new System.Windows.Forms.Label();
            this.newBillGroupBox = new System.Windows.Forms.GroupBox();
            this.statisticsGroupBox.SuspendLayout();
            this.newBillGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNoLabel
            // 
            this.accountNoLabel.AutoSize = true;
            this.accountNoLabel.Location = new System.Drawing.Point(19, 22);
            this.accountNoLabel.Name = "accountNoLabel";
            this.accountNoLabel.Size = new System.Drawing.Size(87, 13);
            this.accountNoLabel.TabIndex = 0;
            this.accountNoLabel.Text = "Account Number";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(139, 19);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(17, 64);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(139, 61);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Location = new System.Drawing.Point(17, 142);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(67, 13);
            this.usageLabel.TabIndex = 0;
            this.usageLabel.Text = "Usage (kwh)";
            // 
            // usageTextBox
            // 
            this.usageTextBox.Location = new System.Drawing.Point(139, 139);
            this.usageTextBox.Name = "usageTextBox";
            this.usageTextBox.Size = new System.Drawing.Size(121, 20);
            this.usageTextBox.TabIndex = 1;
            // 
            // offPeakUsageLabel
            // 
            this.offPeakUsageLabel.AutoSize = true;
            this.offPeakUsageLabel.Location = new System.Drawing.Point(17, 185);
            this.offPeakUsageLabel.Name = "offPeakUsageLabel";
            this.offPeakUsageLabel.Size = new System.Drawing.Size(115, 13);
            this.offPeakUsageLabel.TabIndex = 0;
            this.offPeakUsageLabel.Text = "Off Peak Usage (kWh)";
            this.offPeakUsageLabel.Visible = false;
            // 
            // offPeakUsageTextBox
            // 
            this.offPeakUsageTextBox.Location = new System.Drawing.Point(139, 182);
            this.offPeakUsageTextBox.Name = "offPeakUsageTextBox";
            this.offPeakUsageTextBox.Size = new System.Drawing.Size(121, 20);
            this.offPeakUsageTextBox.TabIndex = 1;
            this.offPeakUsageTextBox.Visible = false;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(32, 260);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 3;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // calculateBillButton
            // 
            this.calculateBillButton.Location = new System.Drawing.Point(151, 260);
            this.calculateBillButton.Name = "calculateBillButton";
            this.calculateBillButton.Size = new System.Drawing.Size(121, 23);
            this.calculateBillButton.TabIndex = 3;
            this.calculateBillButton.Text = "Add Customer";
            this.calculateBillButton.UseVisualStyleBackColor = true;
            this.calculateBillButton.Click += new System.EventHandler(this.calculateBillButton_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerListBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(296, 13);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerListBox.Size = new System.Drawing.Size(514, 225);
            this.customerListBox.TabIndex = 4;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(505, 497);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(95, 23);
            this.saveFileButton.TabIndex = 7;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Type";
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(139, 103);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.customerTypeComboBox.TabIndex = 2;
            this.customerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.customerTypeComboBox_SelectedIndexChanged);
            // 
            // totalCustomersLabel
            // 
            this.totalCustomersLabel.AutoSize = true;
            this.totalCustomersLabel.Location = new System.Drawing.Point(49, 16);
            this.totalCustomersLabel.Name = "totalCustomersLabel";
            this.totalCustomersLabel.Size = new System.Drawing.Size(137, 13);
            this.totalCustomersLabel.TabIndex = 8;
            this.totalCustomersLabel.Text = "Total Number Of Customers";
            // 
            // totalCustomersTextBox
            // 
            this.totalCustomersTextBox.Location = new System.Drawing.Point(257, 13);
            this.totalCustomersTextBox.Name = "totalCustomersTextBox";
            this.totalCustomersTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalCustomersTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalCustomersTextBox.TabIndex = 9;
            // 
            // chargesResidentialLabel
            // 
            this.chargesResidentialLabel.AutoSize = true;
            this.chargesResidentialLabel.Location = new System.Drawing.Point(52, 42);
            this.chargesResidentialLabel.Name = "chargesResidentialLabel";
            this.chargesResidentialLabel.Size = new System.Drawing.Size(143, 13);
            this.chargesResidentialLabel.TabIndex = 10;
            this.chargesResidentialLabel.Text = "Sum of Charges - Residential";
            // 
            // chargesResidentialTextBox
            // 
            this.chargesResidentialTextBox.Location = new System.Drawing.Point(257, 39);
            this.chargesResidentialTextBox.Name = "chargesResidentialTextBox";
            this.chargesResidentialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesResidentialTextBox.Size = new System.Drawing.Size(100, 20);
            this.chargesResidentialTextBox.TabIndex = 11;
            // 
            // chargesCommercialLabel
            // 
            this.chargesCommercialLabel.AutoSize = true;
            this.chargesCommercialLabel.Location = new System.Drawing.Point(52, 67);
            this.chargesCommercialLabel.Name = "chargesCommercialLabel";
            this.chargesCommercialLabel.Size = new System.Drawing.Size(145, 13);
            this.chargesCommercialLabel.TabIndex = 10;
            this.chargesCommercialLabel.Text = "Sum of Charges - Commercial";
            // 
            // chargesCommercialTextBox
            // 
            this.chargesCommercialTextBox.Location = new System.Drawing.Point(257, 64);
            this.chargesCommercialTextBox.Name = "chargesCommercialTextBox";
            this.chargesCommercialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesCommercialTextBox.Size = new System.Drawing.Size(100, 20);
            this.chargesCommercialTextBox.TabIndex = 11;
            // 
            // chargesIndustrialLabel
            // 
            this.chargesIndustrialLabel.AutoSize = true;
            this.chargesIndustrialLabel.Location = new System.Drawing.Point(52, 93);
            this.chargesIndustrialLabel.Name = "chargesIndustrialLabel";
            this.chargesIndustrialLabel.Size = new System.Drawing.Size(133, 13);
            this.chargesIndustrialLabel.TabIndex = 10;
            this.chargesIndustrialLabel.Text = "Sum of Charges - Industrial";
            // 
            // chargesIndustrialTextBox
            // 
            this.chargesIndustrialTextBox.Location = new System.Drawing.Point(257, 90);
            this.chargesIndustrialTextBox.Name = "chargesIndustrialTextBox";
            this.chargesIndustrialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesIndustrialTextBox.Size = new System.Drawing.Size(100, 20);
            this.chargesIndustrialTextBox.TabIndex = 11;
            // 
            // statisticsGroupBox
            // 
            this.statisticsGroupBox.Controls.Add(this.totalCustomersLabel);
            this.statisticsGroupBox.Controls.Add(this.chargesAllCustomersTextBox);
            this.statisticsGroupBox.Controls.Add(this.chargesIndustrialTextBox);
            this.statisticsGroupBox.Controls.Add(this.chargesAllCustomersTypesLabel);
            this.statisticsGroupBox.Controls.Add(this.totalCustomersTextBox);
            this.statisticsGroupBox.Controls.Add(this.chargesIndustrialLabel);
            this.statisticsGroupBox.Controls.Add(this.chargesResidentialLabel);
            this.statisticsGroupBox.Controls.Add(this.chargesCommercialTextBox);
            this.statisticsGroupBox.Controls.Add(this.chargesResidentialTextBox);
            this.statisticsGroupBox.Controls.Add(this.chargesCommercialLabel);
            this.statisticsGroupBox.Location = new System.Drawing.Point(353, 260);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Size = new System.Drawing.Size(414, 143);
            this.statisticsGroupBox.TabIndex = 12;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statistics";
            // 
            // chargesAllCustomersTextBox
            // 
            this.chargesAllCustomersTextBox.Location = new System.Drawing.Point(257, 116);
            this.chargesAllCustomersTextBox.Name = "chargesAllCustomersTextBox";
            this.chargesAllCustomersTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesAllCustomersTextBox.Size = new System.Drawing.Size(100, 20);
            this.chargesAllCustomersTextBox.TabIndex = 11;
            // 
            // chargesAllCustomersTypesLabel
            // 
            this.chargesAllCustomersTypesLabel.AutoSize = true;
            this.chargesAllCustomersTypesLabel.Location = new System.Drawing.Point(52, 119);
            this.chargesAllCustomersTypesLabel.Name = "chargesAllCustomersTypesLabel";
            this.chargesAllCustomersTypesLabel.Size = new System.Drawing.Size(186, 13);
            this.chargesAllCustomersTypesLabel.TabIndex = 10;
            this.chargesAllCustomersTypesLabel.Text = "Sum of Charges - All Customers Types";
            // 
            // newBillGroupBox
            // 
            this.newBillGroupBox.Controls.Add(this.customerTypeComboBox);
            this.newBillGroupBox.Controls.Add(this.offPeakUsageTextBox);
            this.newBillGroupBox.Controls.Add(this.offPeakUsageLabel);
            this.newBillGroupBox.Controls.Add(this.usageTextBox);
            this.newBillGroupBox.Controls.Add(this.usageLabel);
            this.newBillGroupBox.Controls.Add(this.label1);
            this.newBillGroupBox.Controls.Add(this.customerNameTextBox);
            this.newBillGroupBox.Controls.Add(this.customerNameLabel);
            this.newBillGroupBox.Controls.Add(this.accountNoLabel);
            this.newBillGroupBox.Controls.Add(this.accountNumberTextBox);
            this.newBillGroupBox.Location = new System.Drawing.Point(12, 12);
            this.newBillGroupBox.Name = "newBillGroupBox";
            this.newBillGroupBox.Size = new System.Drawing.Size(266, 226);
            this.newBillGroupBox.TabIndex = 13;
            this.newBillGroupBox.TabStop = false;
            this.newBillGroupBox.Text = "New Bill Data";
            // 
            // CustomerBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 415);
            this.Controls.Add(this.newBillGroupBox);
            this.Controls.Add(this.statisticsGroupBox);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.calculateBillButton);
            this.Controls.Add(this.clearAllButton);
            this.Name = "CustomerBill";
            this.Text = "Customer Bill";
            this.Load += new System.EventHandler(this.CustomerBill_Load);
            this.statisticsGroupBox.ResumeLayout(false);
            this.statisticsGroupBox.PerformLayout();
            this.newBillGroupBox.ResumeLayout(false);
            this.newBillGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label accountNoLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label usageLabel;
        private System.Windows.Forms.TextBox usageTextBox;
        private System.Windows.Forms.Label offPeakUsageLabel;
        private System.Windows.Forms.TextBox offPeakUsageTextBox;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button calculateBillButton;
        private System.Windows.Forms.ListBox customerListBox;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Label totalCustomersLabel;
        private System.Windows.Forms.TextBox totalCustomersTextBox;
        private System.Windows.Forms.Label chargesResidentialLabel;
        private System.Windows.Forms.TextBox chargesResidentialTextBox;
        private System.Windows.Forms.Label chargesCommercialLabel;
        private System.Windows.Forms.TextBox chargesCommercialTextBox;
        private System.Windows.Forms.Label chargesIndustrialLabel;
        private System.Windows.Forms.TextBox chargesIndustrialTextBox;
        private System.Windows.Forms.GroupBox statisticsGroupBox;
        private System.Windows.Forms.TextBox chargesAllCustomersTextBox;
        private System.Windows.Forms.Label chargesAllCustomersTypesLabel;
        private System.Windows.Forms.GroupBox newBillGroupBox;
    }
}

