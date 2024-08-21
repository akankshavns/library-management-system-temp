using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_new_books ab = new Add_new_books();
            ab.Show();

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_books vb = new View_books();
            vb.Show();
        }

        private void updToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UpdateBooks ub = new UpdateBooks();
            ub.Show();
        }

        private void contToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void issueBookListToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    IssueBook ib = new IssueBook();
        //    ib.Show();
        //}

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueBookListToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Issue_list IL = new Issue_list();
            IL.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_Student_Info view_Student = new view_Student_Info();
            view_Student.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }







        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void DashContainer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Menucontainer.Width -= 10;
                if (Menucontainer.Width <= 46)
                {
                    sidebarExpand = false;
                    DashContainer.Stop();
                }
            }
            else
            {
                Menucontainer.Width += 10;
                if (Menucontainer.Width >= 160)
                {
                    sidebarExpand = true;
                    DashContainer.Stop();
                }

            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            DashContainer.Start();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
