using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Mobile_shop_Management_System
{
    public partial class login_form : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;
        public login_form()
        {
            InitializeComponent();
            InitializeComponent();
            server = "127.0.0.1";
            database = "test";
            user = "localhost";
            password = "";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               
                connection.Open();

                MessageBox.Show("successful connection");

               connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + connectionString);
                Environment.Exit(0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void login_form_exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
           
        }

        private void login_form_login_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h = new home();
            h.Show();
            
          
        }
    }
}
