using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB_1st.Class
{
    internal class Rider : Person
    {
        private string address;

        private string currentlocation;
        private string destination;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string CurrentLocation
        {
            get { return currentlocation; }
            set { currentlocation = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public static string CurrentUserID { get; set; }


        // Constructor for Rider without location and destination (Sign-in & Login)
        public Rider(string id, string name, string password, string nic, string tp, string address)
            : base(id, name, password, nic, tp)
        {
            Address = address;
        }

        // Constructor for Rider with location and destination (For orders)
        public Rider(string id, string name, string password, string nic, string tp, string address, string currentlocation, string destination)
            : base(id, name, password, nic, tp)
        {
            Address = address;
            CurrentLocation = currentlocation;
            Destination = destination;
        }


        //create data base connection
        private static string connectionString = "server=localhost;database=cabms;user=root;password=;";

        public static void riderSignin(Person person)
        {
            if (person is Rider rider)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        //check rider count 
                        string countQuery = "SELECT COUNT(*) FROM rider";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int riderCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            if (riderCount >= 500)
                            {
                                MessageBox.Show("The rider limit of 500 has been reached. No more riders can be added.");
                                return;
                            }
                        }

                        string query = "INSERT INTO rider (id, name, password, nic, tp, address) VALUES (@id, @name, @password, @nic, @tp, @address)";
                        using (MySqlCommand Cmd = new MySqlCommand(query, conn))
                        {
                            Cmd.Parameters.AddWithValue("@id", rider.Id);
                            Cmd.Parameters.AddWithValue("@name", rider.Name);
                            Cmd.Parameters.AddWithValue("@password", rider.Password);
                            Cmd.Parameters.AddWithValue("@nic", rider.Nic);
                            Cmd.Parameters.AddWithValue("@tp", rider.TP);
                            Cmd.Parameters.AddWithValue("@address", rider.Address);
                            Cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Rider has registered!");
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
        }


        public static Rider riderLogin(string name, string password)
        {
            Rider rider = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM rider WHERE name = @name AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string id = reader["id"].ToString();
                                string riderName = reader["name"].ToString();
                                string riderPassword = reader["password"].ToString();
                                string nic = reader["nic"].ToString();
                                string tp = reader["tp"].ToString();
                                string address = reader["address"].ToString();
                                string currentlocation = reader["currentlocation"].ToString();
                                string destination = reader["destination"].ToString();

                                rider = new Rider(id, riderName, riderPassword, nic, tp, address, currentlocation, destination);
                                Rider.CurrentUserID = id;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logging in: " + ex.Message + ex.Source);
                }
                finally
                {
                    conn.Close();
                }
            }

            return rider;
        }


        public static bool removeRiders(int id, string rider)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"DELETE FROM rider WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
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

        public static DataTable displayRider()
        {
            DataTable riderTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM rider";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(riderTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching coustomers: " + ex.Message);
                }
            }

            return riderTable;
        }


    }
}
