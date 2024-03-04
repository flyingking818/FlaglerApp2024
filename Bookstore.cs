namespace FlaglerApp2024
{
    public partial class Bookstore : Form
    {
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

            //Get user inputs, leveraging the properties of UI classes.
            //It's always a good idea to handle data validation before processing.
            if (!Double.TryParse(txtSalesAmount.Text, out salesAmount))
            {
                MessageBox.Show("Please enter a valid sales amount!");
                txtSalesAmount.Focus();
                return; }
            else if (!Double.TryParse(txtTaxRate.Text, out taxRate))
                MessageBox.Show("Please enter a valid sales amount!");
                txtTaxRate.Focus();
                return;
            }
    }
}
