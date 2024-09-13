namespace ArraySpaceVC
{
    partial class WelcomeScreen
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
            welcomePictureBox = new PictureBox();
            lblTitle = new Label();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).BeginInit();
            SuspendLayout();
            // 
            // welcomePictureBox
            // 
            welcomePictureBox.Location = new Point(0, -5);
            welcomePictureBox.Name = "welcomePictureBox";
            welcomePictureBox.Size = new Size(804, 460);
            welcomePictureBox.TabIndex = 0;
            welcomePictureBox.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(138, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(533, 43);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Welcome to Array Space VC!";
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ActiveCaption;
            btnStart.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(310, 160);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(161, 57);
            btnStart.TabIndex = 2;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(lblTitle);
            Controls.Add(welcomePictureBox);
            Name = "WelcomeScreen";
            Text = "ArraySpaceVC";
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox welcomePictureBox;
        private Label lblTitle;
        private Button btnStart;
    }
}
