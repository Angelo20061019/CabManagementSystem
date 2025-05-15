namespace CAB_1st.GUIs
{
    partial class ManageCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCars));
            button4 = new Button();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(91, 30, 30);
            button4.Location = new Point(0, 213);
            button4.Name = "button4";
            button4.Size = new Size(451, 68);
            button4.TabIndex = 9;
            button4.Text = "Drivers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(24, 247);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 1036);
            panel1.TabIndex = 16;
            // 
            // button7
            // 
            button7.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.FromArgb(91, 30, 30);
            button7.Location = new Point(0, 435);
            button7.Name = "button7";
            button7.Size = new Size(451, 68);
            button7.TabIndex = 12;
            button7.Text = "Orders";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.FromArgb(91, 30, 30);
            button6.Location = new Point(-3, 361);
            button6.Name = "button6";
            button6.Size = new Size(451, 68);
            button6.TabIndex = 11;
            button6.Text = "Coustomers";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(91, 30, 30);
            button5.Location = new Point(-3, 918);
            button5.Name = "button5";
            button5.Size = new Size(451, 68);
            button5.TabIndex = 10;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(91, 30, 30);
            button3.Location = new Point(0, 287);
            button3.Name = "button3";
            button3.Size = new Size(451, 68);
            button3.TabIndex = 8;
            button3.Text = "Cars";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(91, 30, 30);
            button2.Location = new Point(0, 139);
            button2.Name = "button2";
            button2.Size = new Size(451, 68);
            button2.TabIndex = 7;
            button2.Text = "Admins";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(91, 30, 30);
            button1.Location = new Point(0, 65);
            button1.Name = "button1";
            button1.Size = new Size(451, 68);
            button1.TabIndex = 6;
            button1.Text = "Dash Board";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.FromArgb(91, 30, 30);
            button9.Location = new Point(1347, 1153);
            button9.Name = "button9";
            button9.Size = new Size(291, 68);
            button9.TabIndex = 19;
            button9.Text = "Remove";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.FromArgb(91, 30, 30);
            button8.Location = new Point(1676, 1153);
            button8.Name = "button8";
            button8.Size = new Size(291, 68);
            button8.TabIndex = 18;
            button8.Text = "Add";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(520, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1447, 973);
            dataGridView1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, -55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // ManageCars
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1974, 1229);
            Controls.Add(panel1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ManageCars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCars";
            Load += ManageCars_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Panel panel1;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button9;
        private Button button8;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
    }
}