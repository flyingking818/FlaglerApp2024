namespace FlaglerApp2024
{
    partial class SalaryChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            SalaryColumnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalaryColumnChart).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(38, 29);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1683, 880);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SalaryColumnChart);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1667, 826);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Column Chart";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // SalaryColumnChart
            // 
            chartArea2.Name = "ChartArea1";
            SalaryColumnChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            SalaryColumnChart.Legends.Add(legend2);
            SalaryColumnChart.Location = new Point(48, 48);
            SalaryColumnChart.Name = "SalaryColumnChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            SalaryColumnChart.Series.Add(series2);
            SalaryColumnChart.Size = new Size(1536, 740);
            SalaryColumnChart.TabIndex = 0;
            SalaryColumnChart.Text = "chart1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1667, 826);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bar Chart";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SalaryChart
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1791, 961);
            Controls.Add(tabControl1);
            Name = "SalaryChart";
            Text = "SalaryChart";
            Load += SalaryChart_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SalaryColumnChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalaryColumnChart;
        private TabPage tabPage2;
    }
}