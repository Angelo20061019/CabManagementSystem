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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageAdmin manageAdmin = new ManageAdmin();
            manageAdmin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminDashBoard adminDashBoard = new AdminDashBoard();
            adminDashBoard.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageDriver manageDriver = new ManageDriver();
            manageDriver.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageRiders manageRiders = new ManageRiders();
            manageRiders.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageCars manageCars = new ManageCars();
            manageCars.Show();
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

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            LoaOrders();
        }

        private void LoaOrders()
        {
            dataGridView1.DataSource = Order.displayOrders();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["orderid"].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this order?",
                                                             "Confirm Delete",
                                                             MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    bool isDeleted = Order.removeOrder(selectedId);

                    if (isDeleted)
                    {
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        MessageBox.Show("Order removed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove the Order. Please try again.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }
    }
}
