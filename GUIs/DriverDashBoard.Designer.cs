namespace CAB_1st.GUIs
{
    partial class DriverDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverDashBoard));
            button1 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(91, 30, 30);
            button1.Location = new Point(0, 817);
            button1.Name = "button1";
            button1.Size = new Size(451, 68);
            button1.TabIndex = 5;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(-1, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 917);
            panel1.TabIndex = 15;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(91, 30, 30);
            button6.Location = new Point(0, 54);
            button6.Name = "button6";
            button6.Size = new Size(451, 68);
            button6.TabIndex = 13;
            button6.Text = "Dash Board";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(91, 30, 30);
            button3.Location = new Point(0, 276);
            button3.Name = "button3";
            button3.Size = new Size(451, 68);
            button3.TabIndex = 8;
            button3.Text = "Orders ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(91, 30, 30);
            button2.Location = new Point(0, 202);
            button2.Name = "button2";
            button2.Size = new Size(451, 68);
            button2.TabIndex = 7;
            button2.Text = "Available riders ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(91, 30, 30);
            button4.Location = new Point(0, 128);
            button4.Name = "button4";
            button4.Size = new Size(451, 68);
            button4.TabIndex = 6;
            button4.Text = "Available cars ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-18, -25);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(468, 316);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(49, 62, 86);
            label1.Location = new Point(506, 228);
            label1.Name = "label1";
            label1.Size = new Size(302, 32);
            label1.TabIndex = 25;
            label1.Text = "riders, cars, and orders.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(49, 62, 86);
            label10.Location = new Point(577, 382);
            label10.Name = "label10";
            label10.Size = new Size(567, 32);
            label10.TabIndex = 24;
            label10.Text = "2.View Available Riders – See assigned riders.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(49, 62, 86);
            label9.Location = new Point(577, 324);
            label9.Name = "label9";
            label9.Size = new Size(602, 32);
            label9.TabIndex = 23;
            label9.Text = "1. View Available Cars – Check assigned vehicles.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(49, 62, 86);
            label8.Location = new Point(577, 275);
            label8.Name = "label8";
            label8.Size = new Size(254, 32);
            label8.TabIndex = 22;
            label8.Text = "As a driver, you can:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(49, 62, 86);
            label7.Location = new Point(506, 196);
            label7.Name = "label7";
            label7.Size = new Size(1163, 32);
            label7.TabIndex = 21;
            label7.Text = "Welcome to our Cab Management System! Simplify your driving experience with easy access to";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria Math", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(91, 30, 30);
            label6.Location = new Point(429, -68);
            label6.Name = "label6";
            label6.Size = new Size(731, 296);
            label6.TabIndex = 20;
            label6.Text = "Welcome to the DRIVE ON!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(795, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1167, 1244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(49, 62, 86);
            label2.Location = new Point(577, 425);
            label2.Name = "label2";
            label2.Size = new Size(651, 32);
            label2.TabIndex = 26;
            label2.Text = "3.View Orders – Track ongoing and completed rides.";
            // 
            // DriverDashBoard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1924, 1174);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DriverDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DriverDashBoard";
            Load += DriverDashBoard_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button4;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label2;
    }
}