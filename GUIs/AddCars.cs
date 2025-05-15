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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAB_1st.GUIs
{
    public partial class AddCars : Form
    {
        public AddCars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carid = pictureBox1.Text;
            string model = textBox1.Text;
            string platenumber = textBox6.Text;
            string availability = textBox2.Text;

            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(platenumber) || string.IsNullOrEmpty(availability) )
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            Cars cars = new Cars(carid, model, platenumber, availability);
            Cars.addCar(cars);

            this.Hide();
            ManageCars manageCars = new ManageCars();
            manageCars.Show();
        }
    }
}
