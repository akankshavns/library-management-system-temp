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
            this.Hide();
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
    }
}
