using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phonebook
{
    public partial class Phone : Form
    {
        // Creating the SQL Connection and adding the source (Properties of the DB in Server Explorer)
        SqlConnection con = new SqlConnection("Data Source = SFB4945.DDC.Local; Initial Catalog = Phonebook; Integrated Security = True");

        public Phone()
        {
            InitializeComponent();
        }

        // Logic for Displaying the DataGrid at Runtime
        private void Phone_Load(object sender, EventArgs e)
        {
            /* Another method of choosing which textbox I would like to focus on when the app loads. Commented out as I do not need it but good to know.
            this.ActiveControl = textBox2; 56 
            textBox2.Focus();
            */

            Display();

        }

        // Logic for resetting the Form and clearing them. There are 2 ways we can clear texts, both displayed below. 
        // The combo box requires I choose on of the options, since the first one is 0, I need to use -1. And sets the focus to the first textbox.
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
        }

        // Logic for Inserting Data into the DB. I need to work on my SQL Insert query and place it in the paranthesis before the , con
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO MOBILE (First, Last, Mobile, Email, Category) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved a New Phonebook Buddy!");
            Display();
        }

        // Function that Updates the Data Grid everytime I perform a change to the Database
        void Display()
        {
            // Creates the SQL Connection and Select all Query from the Mobile table. Fills the dataGrid.
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Mobile", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            // Logic for each row being displayed
            foreach (DataRow item in dt.Rows)
            {
                // Add a row each time starting from the First Row
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["First"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
            }
        }

        // Logic for displaying the Phonebook Buddys info from the Database into the Editable text fields above
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        // Logic for Deleting from the Database
        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Mobile WHERE (Mobile = '" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully from Phonebook Buddy!");
            Display();
        }

        // Logic for Updating a Phonebook Buddy
        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE Mobile SET First ='" + textBox1.Text + "', Last ='" + textBox2.Text + "', Mobile ='" + textBox3.Text + "', Email ='" + textBox4.Text + "', Category = '" + comboBox1.Text + "'WHERE (Mobile ='" + textBox3.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully to Phonebook Buddy!");
            Display();
        }
    }
}
