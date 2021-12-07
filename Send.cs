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
    public partial class Send : Form
    {
        Connection c = new Connection();
        String autor = "";
        public Send(Form1 fo)
        {
            InitializeComponent();
            fastColoredTextBox1.Text = fo.fastColoredTextBox1.Text;
            fastColoredTextBox1.Language = fo.fastColoredTextBox1.Language;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.insert(fastColoredTextBox1.Text, fastColoredTextBox1.Language.ToString(), autor, richTextBoxDescri.Text, textBoxNome.Text);
            MessageBox.Show("Função enviada ao banco","Agradecemos sua participação na comunidade", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void ibtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ibtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
