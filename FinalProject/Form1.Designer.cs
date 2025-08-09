namespace FinalProject
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
            btnDoor1 = new Button();
            btnDoor2 = new Button();
            btnDoor3 = new Button();
            lblMessage = new Label();
            btnRestart = new Button();
            prizePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)prizePictureBox).BeginInit();
            SuspendLayout();
            // 
            // btnDoor1
            // 
            btnDoor1.BackColor = Color.DarkGoldenrod;
            btnDoor1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnDoor1.FlatAppearance.BorderSize = 2;
            btnDoor1.FlatStyle = FlatStyle.Flat;
            btnDoor1.Font = new Font("AniMe Matrix - MB_EN", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDoor1.Location = new Point(12, 128);
            btnDoor1.Name = "btnDoor1";
            btnDoor1.Size = new Size(144, 226);
            btnDoor1.TabIndex = 0;
            btnDoor1.Text = "Door #1";
            btnDoor1.UseVisualStyleBackColor = false;
            btnDoor1.Click += btnDoor1_Click;
            // 
            // btnDoor2
            // 
            btnDoor2.BackColor = Color.DarkGoldenrod;
            btnDoor2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnDoor2.FlatAppearance.BorderSize = 2;
            btnDoor2.FlatStyle = FlatStyle.Flat;
            btnDoor2.Font = new Font("AniMe Matrix - MB_EN", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDoor2.Location = new Point(401, 126);
            btnDoor2.Name = "btnDoor2";
            btnDoor2.Size = new Size(152, 228);
            btnDoor2.TabIndex = 1;
            btnDoor2.Text = "Door #2";
            btnDoor2.UseVisualStyleBackColor = false;
            btnDoor2.Click += btnDoor2_Click;
            // 
            // btnDoor3
            // 
            btnDoor3.BackColor = Color.DarkGoldenrod;
            btnDoor3.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnDoor3.FlatAppearance.BorderSize = 2;
            btnDoor3.FlatStyle = FlatStyle.Flat;
            btnDoor3.Font = new Font("AniMe Matrix - MB_EN", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDoor3.Location = new Point(816, 127);
            btnDoor3.Name = "btnDoor3";
            btnDoor3.Size = new Size(142, 228);
            btnDoor3.TabIndex = 2;
            btnDoor3.Text = "Door #3";
            btnDoor3.UseVisualStyleBackColor = false;
            btnDoor3.Click += btnDoor3_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(343, 76);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(52, 18);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "label1";
            lblMessage.Click += lblMessage_Click;
            // 
            // btnRestart
            // 
            btnRestart.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(836, 570);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(90, 51);
            btnRestart.TabIndex = 4;
            btnRestart.Text = "Play Again";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // prizePictureBox
            // 
            prizePictureBox.BackColor = Color.Transparent;
            prizePictureBox.Location = new Point(333, 357);
            prizePictureBox.Name = "prizePictureBox";
            prizePictureBox.Size = new Size(62, 52);
            prizePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            prizePictureBox.TabIndex = 5;
            prizePictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(970, 633);
            Controls.Add(prizePictureBox);
            Controls.Add(btnRestart);
            Controls.Add(lblMessage);
            Controls.Add(btnDoor3);
            Controls.Add(btnDoor2);
            Controls.Add(btnDoor1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)prizePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDoor1;
        private Button btnDoor2;
        private Button btnDoor3;
        private Label lblMessage;
        private Button btnRestart;
        private PictureBox prizePictureBox;
    }
}
