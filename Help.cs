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
    public partial class Help : Form
    {
        bool inbtn = false;
        public Help()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }


        private void ibnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   O DeCoding é um trabalho de conclusão de curso realizado pelo aluno Eduardo Iobbi marsola para a conclusão do ensino técnico " +
                "de informática lesionado pela Prof(a)Raquel Lot representando o Centro Municipal de Ensino Profissionalizante " +
                "'Prof. Osmar Passarelli Silveira'.",
                "About", MessageBoxButtons.OK);
        }

        private void ibtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ibtnMax_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void ibtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ibtnFirstSteps_Click(object sender, EventArgs e)
        {
            WebViewer WV = new WebViewer();
            WV.Show();
            this.Hide();
        }

        private void ibtnCodeEditor_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();

        }

        private void ibtnWithCode_Click(object sender, EventArgs e)
        {

        }


        #region
        private void ClearPanelFirstSteps()
        {
            if (inbtn == false)
            {
                panelFirstSteps.Visible = true;
                lblFirstSteps.Visible = true;
                icopiboxFirstSteps.Visible = true;
                ibtnLearning.Visible = false;
                ibtnWithCode.Visible = false;
            }
            else
            {
                panelFirstSteps.Visible = false;
                lblFirstSteps.Visible = false;
                icopiboxFirstSteps.Visible = false;
                ibtnLearning.Visible = true;
                ibtnWithCode.Visible = true;
            }
        }

        private void panelFirstSteps_MouseEnter(object sender, EventArgs e)
        {
            /*inbtn = true;
            panelFirstSteps.Visible = false;
            panelFirstSteps.Enabled = false;
            ibtnLearning.Visible = true;
            ibtnWithCode.Visible = true;
            ibtnLearning.BringToFront();
            ibtnWithCode.BringToFront();*/
        }

        private void ibtnWithCode_MouseLeave(object sender, EventArgs e)
        {
            /* panelFirstSteps.Visible = true;
             lblFirstSteps.Visible = true;
             icopiboxFirstSteps.Visible = true;
             ibtnLearning.Visible = false;
             ibtnWithCode.Visible = false;*/
            inbtn = false;
            ClearPanelFirstSteps();
        }

        private void ibtnLearning_MouseLeave(object sender, EventArgs e)
        {
            inbtn = false;
            ClearPanelFirstSteps();
        }

        private void ibtnWithCode_MouseEnter(object sender, EventArgs e)
        {
            inbtn = true;
            ClearPanelFirstSteps();
        }

        private void ibtnLearning_MouseEnter(object sender, EventArgs e)
        {
            inbtn = true;
            ClearPanelFirstSteps();
        }
        #endregion


    }
}
