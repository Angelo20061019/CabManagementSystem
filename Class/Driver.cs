using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB_1st.Class
{
    internal class Driver : Person
    {
        private string age;
        private string gender;
        private string email;
        private string address;
        private string driveravailability; 

        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Driveravailability
        {
            get { return driveravailability; }
            set { driveravailability = value; }
        }
        public static string CurrentDriverID { get; set; }

        public Driver(string id, string name, string password, string age, string gender, string email, string address, string nic, string tp)
            : base(id, name, password, nic, tp)
        {
            Age = age;
            Gender = gender;
            Email = email;
        }
        public Driver(string id, string name, string password, string age, string gender, string email, string address, string nic, string tp, string driveravailability)
            : base(id, name, password, nic, tp)
        {
            Age = age;
            Gender = gender;
            Email = email;
            Address = address;
            Driveravailability=driveravailability;
        }

        //create data base connection
        private static string connectionString = "server=localhost;database=cabms;user=root;password=;";

        public static void driverSignIn(Person person)
        {
            if(person is Driver driver)
            {
                using(MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        //CHECK DRIVER COUNT 
                        string countQuery = "SELECT COUNT(*) FROM driver";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int driverCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            if (driverCount >= 300)
                            {
                                MessageBox.Show("The driver limit of 300 has been reached. No more drivers can be added.");
                                return;
                            }
                        }

                        string query = "INSERT INTO driver (id, name, password, age, gender,  nic, tp, email, address,driveravailability) VALUES (@id, @name, @password, @age, @gender, @nic, @tp, @email, @address,@driveravailability)";
                        using(MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", driver.Id);
                            cmd.Parameters.AddWithValue("@name", driver.Name);
                            cmd.Parameters.AddWithValue("@password", driver.Password);
                            cmd.Parameters.AddWithValue("@age", driver.Age);
                            cmd.Parameters.AddWithValue("@gender", driver.Gender);
                            cmd.Parameters.AddWithValue("@nic", driver.Nic);
                            cmd.Parameters.AddWithValue("@tp", driver.TP);
                            cmd.Parameters.AddWithValue("@email", driver.Email);
                            cmd.Parameters.AddWithValue("@address", driver.Address);
                            cmd.Parameters.AddWithValue("@driveravailability", driver.driveravailability);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Driver has registered");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }   
            }
        }

        public static Driver driverLogin(string name, string password)
        {
            Driver driver = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM driver WHERE name = @name AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string id = reader["id"].ToString();
                                string driverName = reader["name"].ToString();
                                string driverPassword = reader["password"].ToString();
                                string age = reader["age"].ToString();
                                string gender = reader["gender"].ToString();
                                string nic = reader["nic"].ToString();
                                string tp = reader["tp"].ToString();
                                string email = reader["email"].ToString();
                                string address = reader["address"].ToString();

                                driver = new Driver(id, driverName, driverPassword, age, gender, email, address, nic, tp);

                                CurrentDriverID = id;
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
                finally 
                { 
                    conn.Close(); 
                }
                return driver;
            }
        }

        public static bool removeDriver(int id, string name)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"DELETE FROM driver WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error removing admin: " + ex.Message);
                    return false;

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static DataTable displayDrivers()
        {
            DataTable driverTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM driver";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(driverTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching admins: " + ex.Message);
                }
            }

            return driverTable;
        }

        
    }
}
