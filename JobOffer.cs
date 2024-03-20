using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaglerApp2024
{
    public partial class JobOffer : Form
    {
        //Declare global variables to be used by the 2nd form
        public static string StudentName;
        public static string Company;
        public static double Salary = 0;

        public JobOffer()
        {
            InitializeComponent();
        }

        private void btnCreateChart_Click(object sender, EventArgs e)
        {
            //Assign the user inputs to these variables
            StudentName = txtStudentName.Text;
            Company = txtCompany.Text;
            Salary = Convert.ToDouble(txtSalary.Text); //Do validation here.

            //Redirect to the chart form to plot the chart.
            SalaryChart chaSalary = new SalaryChart();
            chaSalary.Show();


        }
    }
}
