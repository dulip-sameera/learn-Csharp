namespace WeekPayCalc
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtNoOfWorkHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int workHours = Int32.Parse(txtNoOfWorkHours.Text);
            int payRate = Int32.Parse(txtPayRate.Text);


        }
    }
}
