using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArdhalapudiTrainingSchool
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course a = new Course();
            a.Visible = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty a = new Faculty();
            a.Visible = true;
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees a = new Fees();
            a.Visible = true;
        }

        private void progressReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressReport a = new ProgressReport();
            a.Visible = true;
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary a = new Salary();
            a.Visible = true;
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student a = new Student();
            a.Visible = true;
        }

        private void enrolledCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrolledCourse a = new EnrolledCourse();
            a.Visible = true;
        }

        private void tmetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timetable a = new Timetable();
            a.Visible = true;
        }
    }
}
