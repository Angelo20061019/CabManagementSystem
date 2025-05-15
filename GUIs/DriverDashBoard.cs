using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAB_1st.Class;

namespace CAB_1st.GUIs
{
    public partial class DriverDashBoard : Form
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

        public DriverDashBoard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void DriverDashBoard_Load(object sender, EventArgs e)
        {
            LoadCars();
        }
        private void LoadCars()
        {
            
        }
        private void RefreshGrid()
        {
            LoadCars();
            MessageBox.Show("Car list updated.");
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Driveravailablecars driveravailablecars = new Driveravailablecars();
            driveravailablecars.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Driveravailableriders driveravailableriders = new Driveravailableriders();
            driveravailableriders.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drivervieworders drivervieworders = new Drivervieworders();
            drivervieworders.Show();
            this.Hide();
        }
    }
}
