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
            this.exitButton = new System.Windows.Forms.Button();
            this.statisticsGroupBox.SuspendLayout();
            this.newBillGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountNoLabel
            // 
            this.accountNoLabel.AutoSize = true;
            this.accountNoLabel.Location = new System.Drawing.Point(25, 27);
            this.accountNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.accountNoLabel.Name = "accountNoLabel";
            this.accountNoLabel.Size = new System.Drawing.Size(113, 17);
            this.accountNoLabel.TabIndex = 0;
            this.accountNoLabel.Text = "Account Number";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(185, 23);
            this.accountNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(160, 22);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(23, 79);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(109, 17);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(185, 75);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Location = new System.Drawing.Point(23, 175);
            this.usageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(87, 17);
            this.usageLabel.TabIndex = 0;
            this.usageLabel.Text = "Usage (kwh)";
            // 
            // usageTextBox
            // 
            this.usageTextBox.Location = new System.Drawing.Point(185, 171);
            this.usageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usageTextBox.Name = "usageTextBox";
            this.usageTextBox.Size = new System.Drawing.Size(160, 22);
            this.usageTextBox.TabIndex = 1;
            // 
            // offPeakUsageLabel
            // 
            this.offPeakUsageLabel.AutoSize = true;
            this.offPeakUsageLabel.Location = new System.Drawing.Point(23, 228);
            this.offPeakUsageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.offPeakUsageLabel.Name = "offPeakUsageLabel";
            this.offPeakUsageLabel.Size = new System.Drawing.Size(150, 17);
            this.offPeakUsageLabel.TabIndex = 0;
            this.offPeakUsageLabel.Text = "Off Peak Usage (kWh)";
            this.offPeakUsageLabel.Visible = false;
            // 
            // offPeakUsageTextBox
            // 
            this.offPeakUsageTextBox.Location = new System.Drawing.Point(185, 224);
            this.offPeakUsageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offPeakUsageTextBox.Name = "offPeakUsageTextBox";
            this.offPeakUsageTextBox.Size = new System.Drawing.Size(160, 22);
            this.offPeakUsageTextBox.TabIndex = 1;
            this.offPeakUsageTextBox.Visible = false;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(43, 320);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(100, 28);
            this.clearAllButton.TabIndex = 3;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // calculateBillButton
            // 
            this.calculateBillButton.Location = new System.Drawing.Point(201, 320);
            this.calculateBillButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateBillButton.Name = "calculateBillButton";
            this.calculateBillButton.Size = new System.Drawing.Size(161, 28);
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
            this.customerListBox.ItemHeight = 17;
            this.customerListBox.Location = new System.Drawing.Point(395, 16);
            this.customerListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerListBox.Size = new System.Drawing.Size(684, 276);
            this.customerListBox.TabIndex = 4;
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(673, 612);
            this.saveFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(127, 28);
            this.saveFileButton.TabIndex = 7;
            this.saveFileButton.Text = "Save File";
            this.saveFileButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
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
            this.customerTypeComboBox.Location = new System.Drawing.Point(185, 127);
            this.customerTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.customerTypeComboBox.TabIndex = 2;
            this.customerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.customerTypeComboBox_SelectedIndexChanged);
            // 
            // totalCustomersLabel
            // 
            this.totalCustomersLabel.AutoSize = true;
            this.totalCustomersLabel.Location = new System.Drawing.Point(65, 20);
            this.totalCustomersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCustomersLabel.Name = "totalCustomersLabel";
            this.totalCustomersLabel.Size = new System.Drawing.Size(184, 17);
            this.totalCustomersLabel.TabIndex = 8;
            this.totalCustomersLabel.Text = "Total Number Of Customers";
            // 
            // totalCustomersTextBox
            // 
            this.totalCustomersTextBox.Location = new System.Drawing.Point(343, 16);
            this.totalCustomersTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalCustomersTextBox.Name = "totalCustomersTextBox";
            this.totalCustomersTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalCustomersTextBox.Size = new System.Drawing.Size(132, 22);
            this.totalCustomersTextBox.TabIndex = 9;
            // 
            // chargesResidentialLabel
            // 
            this.chargesResidentialLabel.AutoSize = true;
            this.chargesResidentialLabel.Location = new System.Drawing.Point(69, 52);
            this.chargesResidentialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chargesResidentialLabel.Name = "chargesResidentialLabel";
            this.chargesResidentialLabel.Size = new System.Drawing.Size(192, 17);
            this.chargesResidentialLabel.TabIndex = 10;
            this.chargesResidentialLabel.Text = "Sum of Charges - Residential";
            // 
            // chargesResidentialTextBox
            // 
            this.chargesResidentialTextBox.Location = new System.Drawing.Point(343, 48);
            this.chargesResidentialTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chargesResidentialTextBox.Name = "chargesResidentialTextBox";
            this.chargesResidentialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesResidentialTextBox.Size = new System.Drawing.Size(132, 22);
            this.chargesResidentialTextBox.TabIndex = 11;
            // 
            // chargesCommercialLabel
            // 
            this.chargesCommercialLabel.AutoSize = true;
            this.chargesCommercialLabel.Location = new System.Drawing.Point(69, 82);
            this.chargesCommercialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chargesCommercialLabel.Name = "chargesCommercialLabel";
            this.chargesCommercialLabel.Size = new System.Drawing.Size(195, 17);
            this.chargesCommercialLabel.TabIndex = 10;
            this.chargesCommercialLabel.Text = "Sum of Charges - Commercial";
            // 
            // chargesCommercialTextBox
            // 
            this.chargesCommercialTextBox.Location = new System.Drawing.Point(343, 79);
            this.chargesCommercialTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chargesCommercialTextBox.Name = "chargesCommercialTextBox";
            this.chargesCommercialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesCommercialTextBox.Size = new System.Drawing.Size(132, 22);
            this.chargesCommercialTextBox.TabIndex = 11;
            // 
            // chargesIndustrialLabel
            // 
            this.chargesIndustrialLabel.AutoSize = true;
            this.chargesIndustrialLabel.Location = new System.Drawing.Point(69, 114);
            this.chargesIndustrialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chargesIndustrialLabel.Name = "chargesIndustrialLabel";
            this.chargesIndustrialLabel.Size = new System.Drawing.Size(179, 17);
            this.chargesIndustrialLabel.TabIndex = 10;
            this.chargesIndustrialLabel.Text = "Sum of Charges - Industrial";
            // 
            // chargesIndustrialTextBox
            // 
            this.chargesIndustrialTextBox.Location = new System.Drawing.Point(343, 111);
            this.chargesIndustrialTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chargesIndustrialTextBox.Name = "chargesIndustrialTextBox";
            this.chargesIndustrialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesIndustrialTextBox.Size = new System.Drawing.Size(132, 22);
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
            this.statisticsGroupBox.Location = new System.Drawing.Point(471, 320);
            this.statisticsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statisticsGroupBox.Name = "statisticsGroupBox";
            this.statisticsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statisticsGroupBox.Size = new System.Drawing.Size(552, 176);
            this.statisticsGroupBox.TabIndex = 12;
            this.statisticsGroupBox.TabStop = false;
            this.statisticsGroupBox.Text = "Statistics";
            // 
            // chargesAllCustomersTextBox
            // 
            this.chargesAllCustomersTextBox.Location = new System.Drawing.Point(343, 143);
            this.chargesAllCustomersTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chargesAllCustomersTextBox.Name = "chargesAllCustomersTextBox";
            this.chargesAllCustomersTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chargesAllCustomersTextBox.Size = new System.Drawing.Size(132, 22);
            this.chargesAllCustomersTextBox.TabIndex = 11;
            // 
            // chargesAllCustomersTypesLabel
            // 
            this.chargesAllCustomersTypesLabel.AutoSize = true;
            this.chargesAllCustomersTypesLabel.Location = new System.Drawing.Point(69, 146);
            this.chargesAllCustomersTypesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chargesAllCustomersTypesLabel.Name = "chargesAllCustomersTypesLabel";
            this.chargesAllCustomersTypesLabel.Size = new System.Drawing.Size(251, 17);
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
            this.newBillGroupBox.Location = new System.Drawing.Point(16, 15);
            this.newBillGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newBillGroupBox.Name = "newBillGroupBox";
            this.newBillGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newBillGroupBox.Size = new System.Drawing.Size(355, 278);
            this.newBillGroupBox.TabIndex = 13;
            this.newBillGroupBox.TabStop = false;
            this.newBillGroupBox.Text = "New Bill Data";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(236, 396);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exiit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CustomerBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 511);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newBillGroupBox);
            this.Controls.Add(this.statisticsGroupBox);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.calculateBillButton);
            this.Controls.Add(this.clearAllButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button exitButton;
    }
}

