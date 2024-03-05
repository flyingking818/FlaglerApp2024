using System.Data.SqlTypes;

namespace FlaglerApp2024
{
    public partial class Bookstore : Form
    {
        const double FL_RATE = 7.0;
        const double OH_RATE = 6.5;
        const double NY_RATE = 8.0;



        public Bookstore()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hi there");

            //Declare variables
            double salesAmount = 0;
            double taxRate = 0;
            double taxAmount = 0;
            double balance = 0;

            //set the tax rate based on user input - we don't do this here.
            //instead, we'll use another event based the radio button!


            //Get user inputs, leveraging the properties of UI classes.
            //It's always a good idea to handle data validation before processing.
            if (!Double.TryParse(txtSalesAmount.Text, out salesAmount))
            {
                MessageBox.Show("Please enter a valid sales amount!");
                txtSalesAmount.Focus();
                return;
            }
            else if (!Double.TryParse(txtTaxRate.Text, out taxRate))
            {

                MessageBox.Show("Please enter a valid sales amount!");
                txtTaxRate.Focus();
                return;
            }

            //Processing
            lblTaxAmount.Visible = true;
            lblBalance.Visible = true;





            taxAmount = salesAmount * taxRate / 100;
            balance = salesAmount + taxAmount;

            //Output
            lblTaxAmount.Text = taxAmount.ToString("C");
            lblBalance.Text = balance.ToString("C");


        }

        private void rdoFL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFL.Checked)
            {
                txtTaxRate.Text = FL_RATE.ToString();
            }
        }

        private void rdoOH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOH.Checked)
            {
                txtTaxRate.Text = OH_RATE.ToString();
            }
        }

        private void rdoNY_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNY.Checked)
            {
                txtTaxRate.Text = NY_RATE.ToString();
            }
        }

        private void rdoYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoYes.Checked)
            {
                txtTaxRate.Text = "0";
            }
        }

        private void cblCampusCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This is called");
        }
    }




}

