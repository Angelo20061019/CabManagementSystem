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
    public partial class AvailableCars : Form
    {
        public AvailableCars()
        {
            InitializeComponent();
        }

        private void AvailableCars_Load(object sender, EventArgs e)
        {
            LoadCar();
        }
        private void LoadCar()
        {
            dataGridView1.DataSource = Cars.displayCars();
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

        private void button6_Click(object sender, EventArgs e)
        {
            RiderDashBoard dashBoard = new RiderDashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
