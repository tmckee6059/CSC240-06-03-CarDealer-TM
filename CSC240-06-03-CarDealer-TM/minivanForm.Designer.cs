namespace CSC240_06_03_CarDealer_TM
{
    partial class minivanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(minivanForm));
            minivanPictureBox = new PictureBox();
            minivandetailsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)minivanPictureBox).BeginInit();
            SuspendLayout();
            // 
            // minivanPictureBox
            // 
            minivanPictureBox.Image = (Image)resources.GetObject("minivanPictureBox.Image");
            minivanPictureBox.Location = new Point(3, 2);
            minivanPictureBox.Name = "minivanPictureBox";
            minivanPictureBox.Size = new Size(413, 445);
            minivanPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            minivanPictureBox.TabIndex = 0;
            minivanPictureBox.TabStop = false;
            // 
            // minivandetailsLabel
            // 
            minivandetailsLabel.AutoSize = true;
            minivandetailsLabel.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            minivandetailsLabel.Location = new Point(426, 184);
            minivandetailsLabel.Name = "minivandetailsLabel";
            minivandetailsLabel.Size = new Size(442, 63);
            minivandetailsLabel.TabIndex = 1;
            minivandetailsLabel.Text = "Unfortunately, this is all we have in inventory\r\nfor minivans. It will at least get you to where you\r\nneed to go; just don't take corners too fast.";
            // 
            // minivanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(871, 450);
            Controls.Add(minivandetailsLabel);
            Controls.Add(minivanPictureBox);
            Name = "minivanForm";
            Text = "minivanForm";
            ((System.ComponentModel.ISupportInitialize)minivanPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox minivanPictureBox;
        private Label minivandetailsLabel;
    }
}