﻿namespace FlaglerApp2024
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            txtTaxRate.Location = new Point(322, 304);
            txtTaxRate.Name = "txtTaxRate";
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
            // Bookstore
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1678, 959);
            Controls.Add(pictureBox1);
            Controls.Add(txtTaxRate);
            Controls.Add(label2);
            Controls.Add(txtSalesAmount);
            Controls.Add(label1);
            Name = "Bookstore";
            Text = "Bookstore";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSalesAmount;
        private TextBox txtTaxRate;
        private Label label2;
        private PictureBox pictureBox1;
    }
}