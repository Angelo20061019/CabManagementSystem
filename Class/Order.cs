using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CAB_1st.Class
{
    internal class Order : Rider
    {
        private string driverid;
        private string carid;

        public string DriverID
        {
            get { return driverid; }
            set { driverid = value; }
        }

        public string CarID
        {
            get { return carid; }
            set { carid = value; }
        }
       

        public Order (string id , string name, string password, string nic, string tp, string address, string carid, string driverid,string currentlocation, string destination)
            :base(id, name, password, nic, tp, address, currentlocation, destination)
        {
            this.driverid = driverid;
            this.carid = carid;
            this.CurrentLocation = currentlocation;
            this.Destination = destination;
        }

        //create data base connection
        private static string connectionString = "server=localhost;database=cabms;user=root;password=;";

        public static void PlaceOrder(string carID, string driverID, string currentlocation, string destination)
        {
            string userID = Rider.CurrentUserID;

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("Error: No user is logged in.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if Car ID exists
                    string carQuery = "SELECT COUNT(*) FROM cars WHERE carid = @carid";
                    using (MySqlCommand carCmd = new MySqlCommand(carQuery, conn))
                    {
                        carCmd.Parameters.AddWithValue("@carid", carID);
                        int carExists = Convert.ToInt32(carCmd.ExecuteScalar());
                        if (carExists == 0)
                        {
                            MessageBox.Show("Car ID does not exist.");
                            return;
                        }
                    }
                    string checkAvailabilityQuery = "SELECT availability FROM cars WHERE carid = @carid";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkAvailabilityQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@carid", carID);
                        int Available = Convert.ToInt32(checkCmd.ExecuteScalar());

                        // If no tickets are available, show message and stop the booking
                        if (Available <= 0)
                        {
                            MessageBox.Show("All the cars are booked already!");
                            return;
                        }
                    }

                    // Check if Driver ID exists
                    string driverQuery = "SELECT COUNT(*) FROM driver WHERE id = @id";
                    using (MySqlCommand driverCmd = new MySqlCommand(driverQuery, conn))
                    {
                        driverCmd.Parameters.AddWithValue("@id", driverID);
                        int driverExists = Convert.ToInt32(driverCmd.ExecuteScalar());
                        if (driverExists == 0)
                        {
                            MessageBox.Show("Driver ID does not exist.");
                            return;
                        }
                    }
                    string checkDriverAvailabilityQuery = "SELECT driveravailability FROM driver WHERE id = @id";
                    using (MySqlCommand checkDriverCmd = new MySqlCommand(checkDriverAvailabilityQuery, conn))
                    {
                        checkDriverCmd.Parameters.AddWithValue("@id", driverID);
                        int driverAvailable = Convert.ToInt32(checkDriverCmd.ExecuteScalar());

                        // If no tickets are available, show message and stop the booking
                        if (driverAvailable <= 0)
                        {
                            MessageBox.Show("All the cars are booked already!");
                            return;
                        }
                    }




                    // Insert order into database
                    string insertQuery = "INSERT INTO order_table (userid, driverid, carid,currentlocation, destination) VALUES (@userid, @driverid, @carid,@currentlocation, @destination)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@userid", userID);
                        insertCmd.Parameters.AddWithValue("@driverid", driverID);
                        insertCmd.Parameters.AddWithValue("@carid", carID);
                        insertCmd.Parameters.AddWithValue("@currentlocation", currentlocation);
                        insertCmd.Parameters.AddWithValue("@destination", destination);
                        insertCmd.ExecuteNonQuery();
                    }

                    string updateQuery = "UPDATE cars SET availability = availability - 1 WHERE carid  = @carid ";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@carid", carID);
                        updateCmd.ExecuteNonQuery();
                    }
                    string updateDriverQuery = "UPDATE driver SET driveravailability = driveravailability - 1 WHERE id  = @id ";
                    using (MySqlCommand updateCmd = new MySqlCommand(updateDriverQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@id", driverID);
                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order placed successfully!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message + conn.DataSource);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static DataTable displayOrders()
        {
            DataTable orderTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM order_table";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(orderTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching coustomers: " + ex.Message);
                }
            }

            return orderTable;
        }

        public static void LoadUserOrders(DataGridView dataGridView)
        {
            // Get the current logged-in user's ID
            string userID = Rider.CurrentUserID;

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("Error: No user is logged in.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch only the logged-in user's orders
                    string query = "SELECT carid, driverid, currentlocation, destination FROM order_table WHERE userid = @userid";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userid", userID);

                        // Load the data into a DataTable
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the data to the DataGridView
                        dataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void LoadDriverOrders(DataGridView dataGridView)
        {
            // Get the current logged-in user's ID
            string driverID = Driver.CurrentDriverID;

            if (string.IsNullOrEmpty(driverID))
            {
                MessageBox.Show("Error: No driver is logged in.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to fetch only the logged-in user's orders
                    string query = "SELECT carid,userid,currentlocation , destination FROM order_table WHERE driverid = @driverid";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@driverid", driverID);

                        // Load the data into a DataTable
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the data to the DataGridView
                        dataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static bool removeOrder(int orderid)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"DELETE FROM order_table WHERE orderid = @orderid";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderid", orderid);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error removing coustomer: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
