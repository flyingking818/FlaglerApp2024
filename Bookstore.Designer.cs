namespace FlaglerApp2024
{
    partial class Bookstore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookstore));
            label1 = new Label();
            txtSalesAmount = new TextBox();
            txtTaxRate = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            btnCalculate = new Button();
            btnReset = new Button();
            lblTaxAmount = new Label();
            lblBalance = new Label();
            groupBox1 = new GroupBox();
            rdoOH = new RadioButton();
            rdoFL = new RadioButton();
            rdoNY = new RadioButton();
            groupBox2 = new GroupBox();
            rdoYes = new RadioButton();
            rdoNo = new RadioButton();
            lstCampusCredit = new ListBox();
            txtCampusCredit = new TextBox();
            label5 = new Label();
            cboCampusCredit = new ComboBox();
            txtDonation = new TextBox();
            label7 = new Label();
            cblDonation = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 215);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 0;
            label1.Text = "Sales Amount:";
            // 
            // txtSalesAmount
            // 
            txtSalesAmount.Location = new Point(322, 215);
            txtSalesAmount.Name = "txtSalesAmount";
            txtSalesAmount.Size = new Size(401, 39);
            txtSalesAmount.TabIndex = 1;
            // 
            // txtTaxRate
            // 
            txtTaxRate.BackColor = SystemColors.ButtonFace;
            txtTaxRate.Location = new Point(322, 304);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.ReadOnly = true;
            txtTaxRate.Size = new Size(98, 39);
            txtTaxRate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 304);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 2;
            label2.Text = "Tax Rate:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(364, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(914, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 606);
            label3.Name = "label3";
            label3.Size = new Size(145, 32);
            label3.TabIndex = 5;
            label3.Text = "Tax Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 307);
            label4.Name = "label4";
            label4.Size = new Size(34, 32);
            label4.TabIndex = 6;
            label4.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 694);
            label6.Name = "label6";
            label6.Size = new Size(152, 32);
            label6.TabIndex = 8;
            label6.Text = "Balance Due:";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Firebrick;
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(113, 804);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(183, 69);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Firebrick;
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(326, 804);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(183, 69);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // lblTaxAmount
            // 
            lblTaxAmount.AutoSize = true;
            lblTaxAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTaxAmount.ForeColor = Color.FromArgb(192, 0, 0);
            lblTaxAmount.Location = new Point(332, 606);
            lblTaxAmount.Name = "lblTaxAmount";
            lblTaxAmount.Size = new Size(202, 45);
            lblTaxAmount.TabIndex = 13;
            lblTaxAmount.Text = "Tax Amount";
            lblTaxAmount.Visible = false;
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.FromArgb(192, 0, 0);
            lblBalance.Location = new Point(332, 694);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(135, 45);
            lblBalance.TabIndex = 14;
            lblBalance.Text = "Balance";
            lblBalance.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoOH);
            groupBox1.Controls.Add(rdoFL);
            groupBox1.Controls.Add(rdoNY);
            groupBox1.Location = new Point(782, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 233);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "State";
            // 
            // rdoOH
            // 
            rdoOH.AutoSize = true;
            rdoOH.Location = new Point(25, 96);
            rdoOH.Name = "rdoOH";
            rdoOH.Size = new Size(97, 36);
            rdoOH.TabIndex = 16;
            rdoOH.TabStop = true;
            rdoOH.Text = "Ohio";
            rdoOH.UseVisualStyleBackColor = true;
            rdoOH.CheckedChanged += rdoOH_CheckedChanged;
            // 
            // rdoFL
            // 
            rdoFL.AutoSize = true;
            rdoFL.Location = new Point(25, 42);
            rdoFL.Name = "rdoFL";
            rdoFL.Size = new Size(117, 36);
            rdoFL.TabIndex = 15;
            rdoFL.TabStop = true;
            rdoFL.Text = "Florida";
            rdoFL.UseVisualStyleBackColor = true;
            rdoFL.CheckedChanged += rdoFL_CheckedChanged;
            // 
            // rdoNY
            // 
            rdoNY.AutoSize = true;
            rdoNY.Location = new Point(25, 153);
            rdoNY.Name = "rdoNY";
            rdoNY.Size = new Size(145, 36);
            rdoNY.TabIndex = 17;
            rdoNY.TabStop = true;
            rdoNY.Text = "New York";
            rdoNY.UseVisualStyleBackColor = true;
            rdoNY.CheckedChanged += rdoNY_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoYes);
            groupBox2.Controls.Add(rdoNo);
            groupBox2.Location = new Point(1230, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 200);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Is tax exempt?";
            // 
            // rdoYes
            // 
            rdoYes.AutoSize = true;
            rdoYes.Location = new Point(28, 51);
            rdoYes.Name = "rdoYes";
            rdoYes.Size = new Size(79, 36);
            rdoYes.TabIndex = 18;
            rdoYes.TabStop = true;
            rdoYes.Text = "Yes";
            rdoYes.UseVisualStyleBackColor = true;
            rdoYes.CheckedChanged += rdoYes_CheckedChanged;
            // 
            // rdoNo
            // 
            rdoNo.AutoSize = true;
            rdoNo.Location = new Point(28, 105);
            rdoNo.Name = "rdoNo";
            rdoNo.Size = new Size(77, 36);
            rdoNo.TabIndex = 19;
            rdoNo.TabStop = true;
            rdoNo.Text = "No";
            rdoNo.UseVisualStyleBackColor = true;
            rdoNo.CheckedChanged += rdoNo_CheckedChanged;
            // 
            // lstCampusCredit
            // 
            lstCampusCredit.FormattingEnabled = true;
            lstCampusCredit.Items.AddRange(new object[] { "Student Credit ($20)", "Faculty Credit ($15)", "Staff Credit ($10)" });
            lstCampusCredit.Location = new Point(807, 475);
            lstCampusCredit.Name = "lstCampusCredit";
            lstCampusCredit.Size = new Size(255, 100);
            lstCampusCredit.TabIndex = 22;
            lstCampusCredit.SelectedIndexChanged += lstCampusCredit_SelectedIndexChanged;
            // 
            // txtCampusCredit
            // 
            txtCampusCredit.BackColor = SystemColors.ButtonFace;
            txtCampusCredit.Location = new Point(322, 396);
            txtCampusCredit.Name = "txtCampusCredit";
            txtCampusCredit.ReadOnly = true;
            txtCampusCredit.Size = new Size(98, 39);
            txtCampusCredit.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 396);
            label5.Name = "label5";
            label5.Size = new Size(176, 32);
            label5.TabIndex = 23;
            label5.Text = "Campus Credit:";
            // 
            // cboCampusCredit
            // 
            cboCampusCredit.FormattingEnabled = true;
            cboCampusCredit.Items.AddRange(new object[] { "Student Credit ($20)", "Faculty Credit ($15)", "Staff Credit ($10)" });
            cboCampusCredit.Location = new Point(1215, 481);
            cboCampusCredit.Name = "cboCampusCredit";
            cboCampusCredit.Size = new Size(242, 40);
            cboCampusCredit.TabIndex = 25;
            cboCampusCredit.Text = "---Please Select---";
            cboCampusCredit.SelectedIndexChanged += cboCampusCredit_SelectedIndexChanged;
            // 
            // txtDonation
            // 
            txtDonation.BackColor = SystemColors.ButtonFace;
            txtDonation.Location = new Point(326, 489);
            txtDonation.Name = "txtDonation";
            txtDonation.ReadOnly = true;
            txtDonation.Size = new Size(98, 39);
            txtDonation.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 489);
            label7.Name = "label7";
            label7.Size = new Size(118, 32);
            label7.TabIndex = 26;
            label7.Text = "Donation:";
            // 
            // cblDonation
            // 
            cblDonation.FormattingEnabled = true;
            cblDonation.Items.AddRange(new object[] { "Scholarship ($1)", "Saints Pantry ($2)", "Infrastructure ($3)" });
            cblDonation.Location = new Point(803, 672);
            cblDonation.Name = "cblDonation";
            cblDonation.Size = new Size(243, 112);
            cblDonation.TabIndex = 28;
            cblDonation.SelectedIndexChanged += cblDonation_SelectedIndexChanged;
            // 
            // Bookstore
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1678, 959);
            Controls.Add(cblDonation);
            Controls.Add(txtDonation);
            Controls.Add(label7);
            Controls.Add(cboCampusCredit);
            Controls.Add(txtCampusCredit);
            Controls.Add(label5);
            Controls.Add(lstCampusCredit);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblBalance);
            Controls.Add(lblTaxAmount);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(txtTaxRate);
            Controls.Add(label2);
            Controls.Add(txtSalesAmount);
            Controls.Add(label1);
            Name = "Bookstore";
            Text = "Bookstore";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalesAmount;
        private TextBox txtTaxRate;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button btnCalculate;
        private Button btnReset;
        private Label lblTaxAmount;
        private Label lblBalance;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rdoOH;
        private RadioButton rdoFL;
        private RadioButton rdoNY;
        private RadioButton rdoYes;
        private RadioButton rdoNo;
        private ListBox lstCampusCredit;
        private TextBox txtCampusCredit;
        private Label label5;
        private ComboBox cboCampusCredit;
        private TextBox txtDonation;
        private Label label7;
        private CheckedListBox cblDonation;
    }
}
