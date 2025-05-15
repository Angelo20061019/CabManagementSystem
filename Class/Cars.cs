using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB_1st.Class
{
    internal class Cars
    {
        private string carid;
        private string model;
        private string platenumber;
        private string availability;

        public string CarID
        {
            get { return carid; }
            set { carid = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string PlateNumber
        {
            get { return platenumber; }
            set { platenumber = value; }
        }
        public string Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        // Constructor
        public Cars(string carid, string model, string platenumber, string availability)
        {
            this.carid = carid;
            this.model = model;
            this.platenumber = platenumber;
            this.availability = availability;
        }

        // Database connection string
        private static string connectionString = "server=localhost;database=cabms;user=root;password=;";

        // Method to add a car
        public static void addCar(Cars car)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check car count
                    string countQuery = "SELECT COUNT(*) FROM cars";
                    using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                    {
                        int carCount = Convert.ToInt32(countCmd.ExecuteScalar());

                        if (carCount >= 300)
                        {
                            MessageBox.Show("The car limit of 300 has been reached. No more cars can be added.");
                            return;
                        }
                    }

                    // Insert car into the database
                    string query = "INSERT INTO cars (carid, model, platenumber, availability) VALUES (@carid, @model, @platenumber, @availability)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@carid", car.CarID);
                        cmd.Parameters.AddWithValue("@model", car.Model);
                        cmd.Parameters.AddWithValue("@platenumber", car.PlateNumber);
                        cmd.Parameters.AddWithValue("@availability", car.Availability);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Car has been added!");
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
        public static bool removeCars(int carid, string car)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"DELETE FROM cars WHERE carid = @carid";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@carid", carid);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error removing car: " + ex.Message);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static DataTable displayCars()
        {
            DataTable carTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM cars";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(carTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching admins: " + ex.Message);
                }
            }

            return carTable;
        }
    }
}
