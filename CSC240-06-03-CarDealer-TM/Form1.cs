namespace CSC240_06_03_CarDealer_TM
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MckeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CarclipartPictureBox_Click(object sender, EventArgs e)
        {
            carForm carForm = new carForm();
            carForm.ShowDialog();
        }

        private void truckclipartPictureBox_Click(object sender, EventArgs e)
        {
            truckForm truckForm = new truckForm();
            truckForm.ShowDialog();
        }

        private void minivanclipartPictureBox_Click(object sender, EventArgs e)
        {
            minivanForm minivanForm = new minivanForm();
            minivanForm.ShowDialog();
        }
    }
}