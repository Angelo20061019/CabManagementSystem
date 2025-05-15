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
    public partial class RiderDashBoard : Form
    {
        public RiderDashBoard()
        {
            InitializeComponent();
        }

        private void RiderDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to log out?",
                                                             "Confirm",
                                                             MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvailableCars availableCars = new AvailableCars();
            availableCars.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvailableDrivers availableDrivers = new AvailableDrivers();
            availableDrivers.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlaceOrder placeOrder = new PlaceOrder();
            placeOrder.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder();
            viewOrder.Show();
            this.Hide();
        }
    }
}
