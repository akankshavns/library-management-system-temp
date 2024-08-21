using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace LoginPage
{
    public partial class Issue_Book : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");
        public Issue_Book()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_MouseClick(object sender, MouseEventArgs e)
        {
            panel3.Visible = true;
            if (searchBox.Text == "Search Book...")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

       

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void Issue_Book_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select sN0=id,BookId,BookName From Book";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int i = 0;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id,BookId, BookName From Book where BookName like('%" + searchBox.Text + "%') or AuthorName like ('%" + searchBox.Text + "%') ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                con.Close();

                if (i == 0)
                {
                    MessageBox.Show("Book not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the book ID from the selected cell
                int Id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

                // Define your connection string
                //string connectionString = "your_connection_string_here";

                // Define your SQL query
                string query = "SELECT AvailableBook FROM Book WHERE id = '"+Id+"'";

                // Variable to store the result
                int num = 0;
                    try
                    {
                       
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@BookId", Id);

                        // Open the connection
                        con.Open();

                        // Execute the command and read the results
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store the result in the variable `num`
                                num = reader.GetInt32(0);
                            }
                            else
                        { 
                                MessageBox.Show("No record found.");
                                return;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return;
                    }
                con.Close();
                if (num == 0)
                {
                    MessageBox.Show("Book is not available at present.");
                }
                else
                {
                    messageBox.Visible = true;
                }
                
            }
        }


        private void close_Click(object sender, EventArgs e)
        {
            messageBox.Visible=false;
        }

        private void messageBox_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Yes_Click_1(object sender, EventArgs e)
        {
            panel3.Visible=false;
            issuePage.Visible = true;
            //try
            //{
            //    con.Open();
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = " ";
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter adapter = new SqlDataAdapter();
            //    adapter.SelectCommand = cmd;
            //    adapter.Fill(dt);
            //    i = Convert.ToInt32(dt.Rows.Count.ToString());
            //    dataGridView1.DataSource = dt;
            //    con.Close();

               
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //issueInfo II = new issueInfo();
            //II.Show();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }
    }
}