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
    public partial class Driveravailablecars : Form
    {
        public Driveravailablecars()
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

        private void button3_Click(object sender, EventArgs e)
        {
            Drivervieworders drivervieworders = new Drivervieworders();
            drivervieworders.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Driveravailableriders driveravailableriders = new Driveravailableriders();
            driveravailableriders.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DriverDashBoard driverdashboards = new DriverDashBoard();
            driverdashboards.Show();
            this.Hide();
        }

        private void Driveravailablecars_Load(object sender, EventArgs e)
        {
            Loadcars();
        }
        private void Loadcars()
        {
            dataGridView1.DataSource = Cars.displayCars();
        }
    }
}
