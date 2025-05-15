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
    public partial class Driveravailableriders : Form
    {
        public Driveravailableriders()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Drivervieworders drivervieworders = new Drivervieworders();
            drivervieworders.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Driveravailablecars driveravailablecars = new Driveravailablecars();
            driveravailablecars.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DriverDashBoard driverDashBoard = new DriverDashBoard();
            driverDashBoard.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Driveravailableriders_Load(object sender, EventArgs e)
        {
            LoadDrivers();
        }
        private void LoadDrivers()
        {
            dataGridView1.DataSource = Driver.displayDrivers();
        }
    }
}
