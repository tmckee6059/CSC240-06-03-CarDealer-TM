namespace CSC240_06_03_CarDealer_TM
{
    partial class truckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(truckForm));
            truckPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)truckPictureBox).BeginInit();
            SuspendLayout();
            // 
            // truckPictureBox
            // 
            truckPictureBox.Image = (Image)resources.GetObject("truckPictureBox.Image");
            truckPictureBox.Location = new Point(4, 2);
            truckPictureBox.Name = "truckPictureBox";
            truckPictureBox.Size = new Size(441, 447);
            truckPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            truckPictureBox.TabIndex = 0;
            truckPictureBox.TabStop = false;
            // 
            // truckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(truckPictureBox);
            Name = "truckForm";
            Text = "truckForm";
            ((System.ComponentModel.ISupportInitialize)truckPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox truckPictureBox;
    }
}