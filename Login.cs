using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_for_Education
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void cboxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cboxPassword.Checked) {textBox2.UseSystemPasswordChar = true;}
            else {textBox2.UseSystemPasswordChar = false;}
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }
        
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
