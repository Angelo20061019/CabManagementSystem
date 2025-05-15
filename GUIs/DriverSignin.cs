using CAB_1st.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAB_1st.GUIs
{
    public partial class DriverSignin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
        );

        public DriverSignin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = pictureBox1.Text;
            string name = textBox1.Text;
            string password = textBox8.Text;
            string age = textBox7.Text;
            string gender = textBox6.Text;
            string nic = textBox2.Text;
            string tp = textBox3.Text;
            string email = textBox4.Text;
            string address = textBox5.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(gender)
                || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(tp) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Driver driver = new Driver(id, name, password, age, gender, nic, tp, email, address);
            Driver.driverSignIn(driver);

            this.Hide();
            DriverLogin driverLogin = new DriverLogin();
            driverLogin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverLogin driverLogin = new DriverLogin();
            driverLogin.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void DriverSignin_Load(object sender, EventArgs e)
        {

        }
    }
}
