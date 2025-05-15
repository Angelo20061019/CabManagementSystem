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
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder();
            viewOrder.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RiderDashBoard riderDashBoard = new RiderDashBoard();
            riderDashBoard.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string carID = textBox1.Text; 
            string driverID = textBox2.Text;
            string currentlocation = textBox4.Text;
            string destination = textBox3.Text;


            if (string.IsNullOrEmpty(carID) || string.IsNullOrEmpty(driverID)|| string.IsNullOrEmpty(currentlocation)|| string.IsNullOrEmpty(destination))
            {
                MessageBox.Show("Please fill in Car ID and Driver ID.");
                return;
            }

            Order.PlaceOrder(carID, driverID, currentlocation, destination);
        }
    }
}
