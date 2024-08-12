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
        bool menuExpand = false;

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

        private void issueBookListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issueBook ib = new issueBook();
            ib.Show();
        }

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

        private void DashContainer_Tick(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //private void DashContainer_Tick(object sender, EventArgs e)
        //{
        //    if (menuExpand == false)
        //    {
        //        Menucontainer.Width += 10;
        //        if (Menucontainer.Width >= 151)
        //        {
        //            menuExpand = true;
        //            DashContainer.Stop();
        //        }
        //    }
        //    else
        //        if (menuExpand == true) { 
        //        Menucontainer.Width -= 10;
        //        if (Menucontainer.Width <= 36)
        //        {
        //            menuExpand = false;
        //            DashContainer.Stop();
        //        }
        //    }
        //}

        //private void menuButton_Click(object sender, EventArgs e)
        //{
        //    DashContainer.Start();
        //}
    }
}
