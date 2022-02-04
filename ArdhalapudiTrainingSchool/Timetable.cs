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

    public partial class Timetable : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public Timetable()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jimmy\Documents\ArdhalapudiTrainingSchool.accdb;Persist Security Info=False;";

        }

        private void Timetable_Load(object sender, EventArgs e)
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
                command.CommandText = "insert into Timetable ([TimetableID], [StudentID], [Course], [Date/Time], [AttendingFaculty]) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
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
                string query = "update Timetable set StudentID='" + TextBox2.Text + "', Course='" + TextBox3.Text + "', Date/Time='" + TextBox4.Text + "', AttendingFaculty='" + TextBox5.Text + "' where TimetableID=" + TextBox1.Text + "";
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Timetable where TimetableID=" + TextBox1.Text + "";
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
    }
}
