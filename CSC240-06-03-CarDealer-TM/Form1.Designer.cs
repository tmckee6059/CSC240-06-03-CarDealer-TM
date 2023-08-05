namespace CSC240_06_03_CarDealer_TM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mckeeLabel = new TextBox();
            carsLabel = new TextBox();
            trucksLabel = new TextBox();
            minivansLabel = new TextBox();
            carclipartPictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)carclipartPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mckeeLabel
            // 
            mckeeLabel.BackColor = Color.Wheat;
            mckeeLabel.Font = new Font("Viner Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            mckeeLabel.Location = new Point(131, 86);
            mckeeLabel.Name = "mckeeLabel";
            mckeeLabel.Size = new Size(375, 72);
            mckeeLabel.TabIndex = 0;
            mckeeLabel.Text = "McKee Automotive";
            // 
            // carsLabel
            // 
            carsLabel.Anchor = AnchorStyles.None;
            carsLabel.BackColor = Color.Wheat;
            carsLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            carsLabel.Location = new Point(87, 216);
            carsLabel.Name = "carsLabel";
            carsLabel.Size = new Size(138, 26);
            carsLabel.TabIndex = 1;
            carsLabel.Text = "Cars";
            carsLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // trucksLabel
            // 
            trucksLabel.BackColor = Color.Wheat;
            trucksLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trucksLabel.Location = new Point(248, 216);
            trucksLabel.Name = "trucksLabel";
            trucksLabel.Size = new Size(145, 26);
            trucksLabel.TabIndex = 2;
            trucksLabel.Text = "Trucks";
            trucksLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // minivansLabel
            // 
            minivansLabel.BackColor = Color.Wheat;
            minivansLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            minivansLabel.Location = new Point(416, 216);
            minivansLabel.Name = "minivansLabel";
            minivansLabel.Size = new Size(139, 26);
            minivansLabel.TabIndex = 3;
            minivansLabel.Text = "Minivans";
            minivansLabel.TextAlign = HorizontalAlignment.Center;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(646, 449);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(carclipartPictureBox);
            Controls.Add(minivansLabel);
            Controls.Add(trucksLabel);
            Controls.Add(carsLabel);
            Controls.Add(mckeeLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)carclipartPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mckeeLabel;
        private TextBox carsLabel;
        private TextBox trucksLabel;
        private TextBox minivansLabel;
        private PictureBox carclipartPictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}