namespace CSC240_06_03_CarDealer_TM
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            carclipartPictureBox.MouseEnter += CarclipartPictureBox_MouseEnter;
            carclipartPictureBox.MouseLeave += CarclipartPictureBox_MouseLeave;
            truckclipartPictureBox.MouseEnter += TruckclipartPictureBox_MouseEnter;
            truckclipartPictureBox.MouseLeave += TruckclipartPictureBox_MouseLeave;
            minivanclipartPictureBox.MouseEnter += MinivanclipartPictureBox_MouseEnter;
            minivanclipartPictureBox.MouseLeave += MinivanclipartPictureBox_MouseLeave;
        }

        private void CarclipartPictureBox_MouseEnter(object sender, EventArgs e)
        {
            carclipartPictureBox.BackColor = SystemColors.Highlight;
            carclipartPictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void CarclipartPictureBox_MouseLeave(object sender, EventArgs e)
        {
            carclipartPictureBox.BackColor = Color.Wheat;
            carclipartPictureBox.BorderStyle = BorderStyle.None;
        }

        private void TruckclipartPictureBox_MouseEnter(Object sender, EventArgs e)
        {
            truckclipartPictureBox.BackColor = SystemColors.Highlight;
            truckclipartPictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TruckclipartPictureBox_MouseLeave(Object sender, EventArgs e)
        {
            truckclipartPictureBox.BackColor = Color.Wheat;
            truckclipartPictureBox.BorderStyle = BorderStyle.None;
        }

        private void MinivanclipartPictureBox_MouseEnter(object sender, EventArgs e)
        {
            minivanclipartPictureBox.BackColor = SystemColors.Highlight;
            minivanclipartPictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void MinivanclipartPictureBox_MouseLeave(object sender, EventArgs e)
        {
            minivanclipartPictureBox.BackColor = Color.Wheat;
            minivanclipartPictureBox.BorderStyle = BorderStyle.None;
        }

        private void MckeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void CarclipartPictureBox_Click(object sender, EventArgs e)
        {
            carForm carForm = new carForm();
            carForm.ShowDialog();
        }

        private void TruckclipartPictureBox_Click(object sender, EventArgs e)
        {
            truckForm truckForm = new truckForm();
            truckForm.ShowDialog();
        }

        private void MinivanclipartPictureBox_Click(object sender, EventArgs e)
        {
            minivanForm minivanForm = new minivanForm();
            minivanForm.ShowDialog();
        }
    }
}