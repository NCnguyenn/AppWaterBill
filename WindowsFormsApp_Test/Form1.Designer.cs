namespace WindowsFormsApp_Test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lbTypeOfCustomer = new System.Windows.Forms.Label();
            this.cboTypeOfCustomer = new System.Windows.Forms.ComboBox();
            this.lbNumberOfPeople = new System.Windows.Forms.Label();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.lbLastMonthWaterMeter = new System.Windows.Forms.Label();
            this.txtLastMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.lbThisMonthWaterMeter = new System.Windows.Forms.Label();
            this.txtThisMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.btnCaculator = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbCalculatethewaterbill = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lvWaterBill = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(314, 536);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(165, 126);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(126, 20);
            this.lbCustomerName.TabIndex = 1;
            this.lbCustomerName.Text = "Customer name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(169, 148);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(263, 26);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lbTypeOfCustomer
            // 
            this.lbTypeOfCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTypeOfCustomer.AutoSize = true;
            this.lbTypeOfCustomer.Location = new System.Drawing.Point(169, 209);
            this.lbTypeOfCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTypeOfCustomer.Name = "lbTypeOfCustomer";
            this.lbTypeOfCustomer.Size = new System.Drawing.Size(141, 20);
            this.lbTypeOfCustomer.TabIndex = 3;
            this.lbTypeOfCustomer.Text = "Type Of Customer:";
            // 
            // cboTypeOfCustomer
            // 
            this.cboTypeOfCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeOfCustomer.FormattingEnabled = true;
            this.cboTypeOfCustomer.Location = new System.Drawing.Point(169, 230);
            this.cboTypeOfCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            this.cboTypeOfCustomer.Size = new System.Drawing.Size(258, 28);
            this.cboTypeOfCustomer.TabIndex = 4;
            this.cboTypeOfCustomer.SelectedIndexChanged += new System.EventHandler(this.cboTypeOfCustomer_SelectedIndexChanged);
            // 
            // lbNumberOfPeople
            // 
            this.lbNumberOfPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumberOfPeople.AutoSize = true;
            this.lbNumberOfPeople.Location = new System.Drawing.Point(165, 298);
            this.lbNumberOfPeople.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumberOfPeople.Name = "lbNumberOfPeople";
            this.lbNumberOfPeople.Size = new System.Drawing.Size(139, 20);
            this.lbNumberOfPeople.TabIndex = 5;
            this.lbNumberOfPeople.Text = "Number Of People";
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Location = new System.Drawing.Point(169, 320);
            this.txtNumberOfPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(263, 26);
            this.txtNumberOfPeople.TabIndex = 6;
            // 
            // lbLastMonthWaterMeter
            // 
            this.lbLastMonthWaterMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLastMonthWaterMeter.AutoSize = true;
            this.lbLastMonthWaterMeter.Location = new System.Drawing.Point(170, 389);
            this.lbLastMonthWaterMeter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLastMonthWaterMeter.Name = "lbLastMonthWaterMeter";
            this.lbLastMonthWaterMeter.Size = new System.Drawing.Size(196, 20);
            this.lbLastMonthWaterMeter.TabIndex = 7;
            this.lbLastMonthWaterMeter.Text = "Last Month\'s Water Meter:";
            // 
            // txtLastMonthWaterMeter
            // 
            this.txtLastMonthWaterMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastMonthWaterMeter.Location = new System.Drawing.Point(169, 411);
            this.txtLastMonthWaterMeter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            this.txtLastMonthWaterMeter.Size = new System.Drawing.Size(258, 26);
            this.txtLastMonthWaterMeter.TabIndex = 8;
            // 
            // lbThisMonthWaterMeter
            // 
            this.lbThisMonthWaterMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThisMonthWaterMeter.AutoSize = true;
            this.lbThisMonthWaterMeter.Location = new System.Drawing.Point(169, 453);
            this.lbThisMonthWaterMeter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThisMonthWaterMeter.Name = "lbThisMonthWaterMeter";
            this.lbThisMonthWaterMeter.Size = new System.Drawing.Size(194, 20);
            this.lbThisMonthWaterMeter.TabIndex = 9;
            this.lbThisMonthWaterMeter.Text = "This Month\'s Water Meter:";
            // 
            // txtThisMonthWaterMeter
            // 
            this.txtThisMonthWaterMeter.Location = new System.Drawing.Point(173, 475);
            this.txtThisMonthWaterMeter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            this.txtThisMonthWaterMeter.Size = new System.Drawing.Size(258, 26);
            this.txtThisMonthWaterMeter.TabIndex = 10;
            // 
            // btnCaculator
            // 
            this.btnCaculator.Location = new System.Drawing.Point(169, 536);
            this.btnCaculator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaculator.Name = "btnCaculator";
            this.btnCaculator.Size = new System.Drawing.Size(119, 30);
            this.btnCaculator.TabIndex = 11;
            this.btnCaculator.Text = "Caculator";
            this.btnCaculator.UseVisualStyleBackColor = true;
            this.btnCaculator.Click += new System.EventHandler(this.btnCaculator_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbCalculatethewaterbill
            // 
            this.lbCalculatethewaterbill.AutoSize = true;
            this.lbCalculatethewaterbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculatethewaterbill.ForeColor = System.Drawing.Color.Blue;
            this.lbCalculatethewaterbill.Location = new System.Drawing.Point(588, 24);
            this.lbCalculatethewaterbill.Name = "lbCalculatethewaterbill";
            this.lbCalculatethewaterbill.Size = new System.Drawing.Size(338, 37);
            this.lbCalculatethewaterbill.TabIndex = 12;
            this.lbCalculatethewaterbill.Text = "Calculate the water bill";
            this.lbCalculatethewaterbill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1339, 532);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 30);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // lvWaterBill
            // 
            this.lvWaterBill.HideSelection = false;
            this.lvWaterBill.Location = new System.Drawing.Point(506, 148);
            this.lvWaterBill.Name = "lvWaterBill";
            this.lvWaterBill.Size = new System.Drawing.Size(1134, 353);
            this.lvWaterBill.TabIndex = 14;
            this.lvWaterBill.UseCompatibleStateImageBehavior = false;
            this.lvWaterBill.SelectedIndexChanged += new System.EventHandler(this.lvWaterBill_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(506, 116);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 26);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1850, 878);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvWaterBill);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbCalculatethewaterbill);
            this.Controls.Add(this.btnCaculator);
            this.Controls.Add(this.txtThisMonthWaterMeter);
            this.Controls.Add(this.lbThisMonthWaterMeter);
            this.Controls.Add(this.txtLastMonthWaterMeter);
            this.Controls.Add(this.lbLastMonthWaterMeter);
            this.Controls.Add(this.txtNumberOfPeople);
            this.Controls.Add(this.lbNumberOfPeople);
            this.Controls.Add(this.cboTypeOfCustomer);
            this.Controls.Add(this.lbTypeOfCustomer);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Bill";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lbTypeOfCustomer;
        private System.Windows.Forms.ComboBox cboTypeOfCustomer;
        private System.Windows.Forms.Label lbNumberOfPeople;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.Label lbLastMonthWaterMeter;
        private System.Windows.Forms.TextBox txtLastMonthWaterMeter;
        private System.Windows.Forms.Label lbThisMonthWaterMeter;
        private System.Windows.Forms.TextBox txtThisMonthWaterMeter;
        private System.Windows.Forms.Button btnCaculator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbCalculatethewaterbill;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView lvWaterBill;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

