using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginPage
{
    public partial class AddStudent : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True;Pooling=False;");

        public AddStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";


                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image1.ImageLocation = imageLocation;

                    
                }
            }
            catch (Exception)
              {
                MessageBox.Show("AN Error occured", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into StudentInformation values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + image1 + "','"+textBox4.Text+"', '"+textBox5.Text+ "', '"+textBox6.Text+ "', '"+textBox7.Text+"', '"+textBox8.Text+"' )";
            cmd.ExecuteNonQuery();
            con.Close();

            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";

            MessageBox.Show("Book added successfully");
        }
    }
}
