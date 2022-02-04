using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ArdhalapudiTrainingSchool
{
    public partial class Login : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jimmy\Documents\ArdhalapudiTrainingSchool.accdb;Persist Security Info=False;";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Dashboard a = new Dashboard();
            a.Visible = true;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
