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
    public partial class AddRiders : Form
    {
        public AddRiders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = pictureBox1.Text;
            string name = textBox1.Text;
            string password = textBox6.Text;
            string nic = textBox2.Text;
            string tp = textBox3.Text;
            string address = textBox5.Text;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nic)|| string.IsNullOrEmpty(tp)|| string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Rider rider = new Rider(id, name, password, nic, tp, address);
            Rider.riderSignin(rider);

            this.Hide();
            ManageRiders manageRiders = new ManageRiders();
            manageRiders.Show();
        }
    }
}
