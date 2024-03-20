namespace FlaglerApp2024
{
    partial class JobOffer
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
            label1 = new Label();
            txtStudentName = new TextBox();
            txtCompany = new TextBox();
            label2 = new Label();
            txtSalary = new TextBox();
            label3 = new Label();
            btnCreateChart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 82);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(327, 86);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(342, 39);
            txtStudentName.TabIndex = 1;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(327, 184);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(342, 39);
            txtCompany.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 180);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 2;
            label2.Text = "Company Name:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(327, 305);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(342, 39);
            txtSalary.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 301);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 4;
            label3.Text = "Salary:";
            // 
            // btnCreateChart
            // 
            btnCreateChart.Location = new Point(327, 442);
            btnCreateChart.Name = "btnCreateChart";
            btnCreateChart.Size = new Size(281, 46);
            btnCreateChart.TabIndex = 6;
            btnCreateChart.Text = "Create Chart";
            btnCreateChart.UseVisualStyleBackColor = true;
            btnCreateChart.Click += btnCreateChart_Click;
            // 
            // JobOffer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 804);
            Controls.Add(btnCreateChart);
            Controls.Add(txtSalary);
            Controls.Add(label3);
            Controls.Add(txtCompany);
            Controls.Add(label2);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            Name = "JobOffer";
            Text = "JobOffer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentName;
        private TextBox txtCompany;
        private Label label2;
        private TextBox txtSalary;
        private Label label3;
        private Button btnCreateChart;
    }
}