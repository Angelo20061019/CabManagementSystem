using Google.Protobuf.Compiler;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAB_1st.Class
{
    internal class Admin : Person
    {
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Admin(string id, string name, string password, string nic, string tp, string email)
            : base(id, name, password, nic, tp) 
        {
            Email = email; 
        }

        //create data base connection
        private static string connectionString = "server=localhost;database=cabms;user=root;password=;";

        //admin signin method 
        public static void adminSignIn(Person person)
        {
            if(person is Admin admin)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        //check admin count 
                        string countQuery = "SELECT COUNT(*) FROM admin";
                        using (MySqlCommand countCmd = new MySqlCommand(countQuery, conn))
                        {
                            int adminCount = Convert.ToInt32(countCmd.ExecuteScalar());

                            if (adminCount >= 50)
                            {
                                MessageBox.Show("The admin limit of 50 has been reached. No more admins can be added.");
                                return;
                            }
                        }

                        string query = "INSERT INTO admin (id, name, password, nic, tp, mail) VALUES (@id, @name, @password, @nic, @tp, @mail)";
                        using (MySqlCommand Cmd = new MySqlCommand(query, conn))
                        {
                            Cmd.Parameters.AddWithValue("@id", admin.Id);
                            Cmd.Parameters.AddWithValue("@name", admin.Name);
                            Cmd.Parameters.AddWithValue("@password", admin.Password);
                            Cmd.Parameters.AddWithValue("@nic", admin.Nic);
                            Cmd.Parameters.AddWithValue("@tp", admin.TP);
                            Cmd.Parameters.AddWithValue("@mail", admin.Email);
                            Cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Admin has registered!");
                    }
                    catch(Exception ex)
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

        public static Admin Login(string name, string password)
        {
            Admin admin = null;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM admin WHERE name = @name AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string id = reader["id"].ToString();
                                string adminName = reader["name"].ToString();
                                string adminPassword = reader["password"].ToString();
                                string nic = reader["nic"].ToString(); ;
                                string tp = reader["tp"].ToString();
                                string email = reader["mail"].ToString();

                                admin = new Admin(id, adminName, adminPassword, nic, tp, email);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logging in: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            return admin;
        }

        public static bool removeAdmins(int id, string admin)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"DELETE FROM admin WHERE id = @id";
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

        public static DataTable displayAdmins()
        {
            DataTable adminsTable = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM admin";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(adminsTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching admins: " + ex.Message);
                }
            }

            return adminsTable;
        }

    }
}
