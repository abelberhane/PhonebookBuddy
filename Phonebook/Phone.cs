using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Phone : Form
    {
        public Phone()
        {
            InitializeComponent();
        }


        private void Phone_Load(object sender, EventArgs e)
        {
            /* Another method of choosing which textbox I would like to focus on when the app loads. Commented out as I do not need it but good to know.
            this.ActiveControl = textBox2; 23 
            textBox2.Focus();
            */
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

        // 
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
