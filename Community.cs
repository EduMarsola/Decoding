using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;


namespace Code_for_Education
{
    public partial class Community : Form
    {
        bool drag = false;
        Connection c = new Connection();
        Point start_pont = new Point(0,0);
        String fcb;
        Form1 fo;
        Rectangle panelTopCOriginalRect;
        Rectangle panelSearchOriginalRect;
        Rectangle panelXOriginalRect;
        Rectangle richTextBox2OriginalRect;
        Size formOriginalRect;
        int qtd;
        public Community(Form1 f)
        {
            
           InitializeComponent();
           
           fo = f;
           fcb = fo.fastColoredTextBox1.Text;
           this.SetStyle(ControlStyles.ResizeRedraw, true);
           
            
        }
        private const int cGrip = 16;
        private const int cCaption = 32;
        
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) ;
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
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
            this.Hide();
            
        }
        

        private void Community_Load(object sender, EventArgs e)
        {
            /*formOriginalRect = this.Size;
            panelSearchOriginalRect = new Rectangle(panelSearch.Location.X, panelSearch.Location.Y, panelSearch.Width, panelSearch.Height);
            panelXOriginalRect = new Rectangle(panelX.Location.X, panelX.Location.Y, panelX.Width, panelX.Height);
            panelTopCOriginalRect = new Rectangle(panelTopC.Location.X, panelTopC.Location.Y, panelTopC.Width, panelTopC.Height);
            richTextBox2OriginalRect = new Rectangle(richTextBox2.Location.X, richTextBox2.Location.Y, richTextBox2.Width, richTextBox2.Width);
        */}

        private void resizeChildrenControls()
        {
            /*resizeControl(panelXOriginalRect, panelX);
            resizeControl(panelTopCOriginalRect, panelTopC);
            resizeControl(panelSearchOriginalRect, panelSearch);
            resizeControl(richTextBox2OriginalRect, richTextBox2);
            */
        }

        private void resizeControl(Rectangle originalControlRect, Control control)
        {
            /*float xRatio = (float)(this.Width)/(float)(formOriginalRect.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalRect.Height);

            int newX = (int)(originalControlRect.X * xRatio);
            int newY = (int)(originalControlRect.Y * yRatio);
            int newWidth = (int)(originalControlRect.Width * xRatio);
            int newHeight = (int)(originalControlRect.Height * xRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
            */

        }

        private void Community_Resize(object sender, EventArgs e)
        {
            /*resizeChildrenControls();*/
        }

        protected void richTextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(richTextBoxSearch.Text != "")
            {
                flowLayoutPanel1.Controls.Clear();
                qtd = c.SelectCount(richTextBoxSearch.Text);
                GetSearch();
            }
            
        }
        protected void GetSearch()
        {
            Button[] b = new Button[qtd];
            //SearchItem[] si = new SearchItem[GetSizeSearch()];

            for(int i=0;i<qtd; i++)
            {
                String[] d = new string[3];
                d = c.SelectName(richTextBoxSearch.Text);
                b[i] = new Button();
                b[i].Name = d[1];
                b[i].Text = (d[0])+":"+(d[2]);
                b[i].Width = 650;
                b[i].Height = 50;
                b[i].Font = new Font("Verdana", 9, FontStyle.Bold);
                b[i].TextAlign = ContentAlignment.MiddleLeft;
                b[i].FlatStyle = FlatStyle.Flat;
                b[i].BackColor = Color.WhiteSmoke;
                flowLayoutPanel1.Controls.Add(b[i]);
                b[i].Click += new System.EventHandler(this.btnClick);
            }
        }
        void btnClick(object sender, EventArgs e)
        {
            Button curentBtn = (Button)sender;
            this.fastColoredTextBox1.Text = curentBtn.Name;
        }
        private void richTextBoxSearch_Enter(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fo.fastColoredTextBox1.Text = fo.fastColoredTextBox1.Text +"\n\n" +fastColoredTextBox1.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBoxSearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}
