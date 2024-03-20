using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaglerApp2024
{
    public partial class SalaryChart : Form
    {
        public SalaryChart()
        {
            InitializeComponent();
        }

        private void SalaryChart_Load(object sender, EventArgs e)
        {
            //Trigger the column chart method
            DisplayColumnChart();

            //Trigger the bar chart method
        }

        private void DisplayColumnChart()
        {
            //Clear the current chart elements first
            SalaryColumnChart.Series.Clear();

            //Let's add the columns (data series)
            SalaryColumnChart.Series.Add("Ariana");
            SalaryColumnChart.Series["Ariana"].Points.AddXY("Salary", 70000);

            SalaryColumnChart.Series.Add("Amy");
            SalaryColumnChart.Series["Amy"].Points.AddXY("Salary", "80000");

            //Add a few more... if you want to

            //Use the dot notation to access the values from the previous form
            SalaryColumnChart.Series.Add(JobOffer.StudentName);
            SalaryColumnChart.Series[JobOffer.StudentName].Points.AddXY("Salary", JobOffer.Salary);


        }
    }
}
