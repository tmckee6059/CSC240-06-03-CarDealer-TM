namespace CSC240_06_03_CarDealer_TM
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            carclipartPictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            mckeeLabel = new Label();
            carLabel = new Label();
            truckLabel = new Label();
            minivanLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)carclipartPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // carclipartPictureBox
            // 
            carclipartPictureBox.Image = (Image)resources.GetObject("carclipartPictureBox.Image");
            carclipartPictureBox.Location = new Point(87, 260);
            carclipartPictureBox.Name = "carclipartPictureBox";
            carclipartPictureBox.Size = new Size(138, 84);
            carclipartPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            carclipartPictureBox.TabIndex = 4;
            carclipartPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(248, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(416, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // mckeeLabel
            // 
            mckeeLabel.AutoSize = true;
            mckeeLabel.Font = new Font("Viner Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            mckeeLabel.Location = new Point(121, 103);
            mckeeLabel.Name = "mckeeLabel";
            mckeeLabel.Size = new Size(397, 65);
            mckeeLabel.TabIndex = 7;
            mckeeLabel.Text = "McKee Automotive";
            mckeeLabel.Click += label1_Click;
            // 
            // carLabel
            // 
            carLabel.AutoSize = true;
            carLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            carLabel.Location = new Point(134, 217);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(46, 20);
            carLabel.TabIndex = 8;
            carLabel.Text = "Cars";
            // 
            // truckLabel
            // 
            truckLabel.AutoSize = true;
            truckLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            truckLabel.Location = new Point(291, 221);
            truckLabel.Name = "truckLabel";
            truckLabel.Size = new Size(62, 20);
            truckLabel.TabIndex = 9;
            truckLabel.Text = "Trucks";
            // 
            // minivanLabel
            // 
            minivanLabel.AutoSize = true;
            minivanLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            minivanLabel.Location = new Point(449, 221);
            minivanLabel.Name = "minivanLabel";
            minivanLabel.Size = new Size(78, 20);
            minivanLabel.TabIndex = 10;
            minivanLabel.Text = "Minivans";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(646, 449);
            Controls.Add(minivanLabel);
            Controls.Add(truckLabel);
            Controls.Add(carLabel);
            Controls.Add(mckeeLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(carclipartPictureBox);
            Name = "mainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)carclipartPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox carclipartPictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label mckeeLabel;
        private Label carLabel;
        private Label truckLabel;
        private Label minivanLabel;
    }
}