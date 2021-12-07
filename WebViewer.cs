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
{        //fazer o botão e panel php, trocar os ibtn por panels, deixar mais bonito 
    public partial class WebViewer : Form
    {
        public WebViewer()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonJS_MouseEnter(object sender, EventArgs e)
        {
            iconButtonJS.BackColor = System.Drawing.Color.DimGray;

        }

        private void iconButtonJS_MouseLeave(object sender, EventArgs e)
        {
            iconButtonJS.BackColor = System.Drawing.Color.LightGray;
        }

        private void iconButtonHTML_MouseEnter(object sender, EventArgs e)
        {
            iconButtonHTML.BackColor = System.Drawing.Color.DimGray;
        }

        private void iconButtonHTML_MouseLeave(object sender, EventArgs e)
        {
            iconButtonHTML.BackColor = System.Drawing.Color.LightGray;
        }

        private void iconButtonPHP_MouseEnter(object sender, EventArgs e)
        {
            iconButtonPHP.BackColor = System.Drawing.Color.DimGray;
        }

        private void iconButtonPHP_MouseLeave(object sender, EventArgs e)
        {
            iconButtonPHP.BackColor = System.Drawing.Color.LightGray;
        }
    }
}
