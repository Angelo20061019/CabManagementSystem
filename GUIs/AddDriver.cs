using CAB_1st.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAB_1st.GUIs
{
    public partial class AddDriver : Form
    {
        public AddDriver()
        {
            InitializeComponent();
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
            string driveravailability  = textBox9.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(gender)
                || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(tp) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address)|| string.IsNullOrEmpty(driveravailability))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            Driver driver = new Driver(id, name, password, age, gender, nic, tp, email, address, driveravailability);
            Driver.driverSignIn(driver);

            this.Hide();
            ManageDriver manageDriver = new ManageDriver();
            manageDriver.Show();
        }
    }
}
