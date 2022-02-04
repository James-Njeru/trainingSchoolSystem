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
    public partial class Course : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Course()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jimmy\Documents\ArdhalapudiTrainingSchool.accdb;Persist Security Info=False;";

        }

        private void Course_Load(object sender, EventArgs e)
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Course ([CourseId], [CourseName]) values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
                command.ExecuteNonQuery();

                MessageBox.Show("Data Saved");
                connection.Close();
                connection.Dispose();
            }
            catch
            {
                MessageBox.Show("Failed to save");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Course set CourseName='" + TextBox2.Text + "' where CourseId=" + TextBox1.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Data Updated");
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Update" + ex);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Course where CourseId=" + TextBox1.Text + "";
                command.CommandText = query;
                command.ExecuteNonQuery();

                MessageBox.Show("Data Deleted");
                connection.Close();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Dellete" + ex);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}
