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
            /*
            double salesAmount = 0;
            double taxRate = 0;
            double taxAmount = 0;
            double balance = 0;
            */

            double salesAmount = 0, taxRate = 0, taxAmount = 0,
                campusCredit = 0, donation = 0, balance = 0;


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

            //For campusCredit and donation, TryParse is not neccessary as the inputs are controlled by us.
            campusCredit = Double.Parse(txtCampusCredit.Text); //for windows app, web app
            donation = Convert.ToDouble(txtDonation.Text);  //console app

            //Processing
            lblTaxAmount.Visible = true;
            lblBalance.Visible = true;


            taxAmount = salesAmount * taxRate / 100;
            balance = salesAmount + taxAmount - campusCredit + donation;

            //Output
            lblTaxAmount.Text = taxAmount.ToString("C");
            lblBalance.Text = balance.ToString("C");


        }

        private void rdoFL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFL.Checked && rdoYes.Checked != true)
            {
                txtTaxRate.Text = FL_RATE.ToString();
            }
        }

        private void rdoOH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOH.Checked && rdoYes.Checked != true)
            {
                txtTaxRate.Text = OH_RATE.ToString();
            }
        }

        private void rdoNY_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNY.Checked && rdoYes.Checked != true)
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

        private void rdoNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFL.Checked)
            {
                txtTaxRate.Text = FL_RATE.ToString();
            }
            else if (rdoNY.Checked)
            {
                txtTaxRate.Text = NY_RATE.ToString();
            }
            else if (rdoOH.Checked)
            {
                txtTaxRate.Text = OH_RATE.ToString();
            }
            else
            {
                txtTaxRate.Text = "0";
            }
        }

        private void lstCampusCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstCampusCredit.SelectedIndex)
            {
                case 0:
                    txtCampusCredit.Text = "20";
                    break;
                case 1:
                    txtCampusCredit.Text = "15";
                    break;
                case 2:
                    txtCampusCredit.Text = "10";
                    break;
                default:
                    break;
            }
        }

        private void cboCampusCredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCampusCredit.SelectedIndex)
            {
                case 0:
                    txtCampusCredit.Text = "20";
                    break;
                case 1:
                    txtCampusCredit.Text = "15";
                    break;
                case 2:
                    txtCampusCredit.Text = "10";
                    break;
                default:
                    break;
            }
        }

        private void cblDonation_SelectedIndexChanged(object sender, EventArgs e)
        {
            double donationTotal = 0;
            for (int i = 0; i < cblDonation.Items.Count; i++)
            {
                if (cblDonation.GetItemChecked(i))
                {
                    switch (i)
                    {
                        case 0:
                            donationTotal += 1;
                            break;
                        case 1:
                            donationTotal += 2;
                            break;
                        case 2:
                            donationTotal += 3;
                            break;
                        default:
                            txtDonation.Text = "Error!";
                            break;
                    }
                }

            }
            txtDonation.Text = donationTotal.ToString();
        }

        private void txtSalesAmount_MouseHover(object sender, EventArgs e)
        {
            lblMessage.Text = "Please enter the sales amount!";
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scholarshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scholarship scholarshipFrm = new Scholarship();
            scholarshipFrm.Show();
        }

        private void jobOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobOffer frmJobOffer = new JobOffer();  
            frmJobOffer.Show();
        }
    }




}

