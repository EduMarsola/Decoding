using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Code_for_Education
{
    public partial class Form1 : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
            Editor.PerformClick();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if(pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip);
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void Save()
        {
            SaveFileDialog Save = new SaveFileDialog();
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            { Save.Filter = "Csharp File|*.cs| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            { Save.Filter = "HTML File|*.html| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
            { Save.Filter = "Visual Basic File|*.vb| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
            { Save.Filter = "Java Script File|*.js| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
            { Save.Filter = "Lua File|*.lua| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            { Save.Filter = "PHP File|*.php| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.SQL)
            { Save.Filter = "SQL File|*.sql| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
            { Save.Filter = "XML File|*.xml| Any Files|*."; }
            else { Save.Filter = "Any Files|*."; }

            if (Save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(Save.FileName);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
            TitleChange(Save.FileName);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sr = new StreamWriter(this.Text);
                sr.Write(fastColoredTextBox1.Text);
                sr.Close();
            }
            catch
            {
                Save();
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Open()
        {
            OpenFileDialog Open = new OpenFileDialog();
            /*if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            { Open.Filter = "Csharp File|*.cs| Any Files|*."; }
            else*/
            if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            { Open.Filter = "HTML File|*.html| Any Files|*.";
                PrepareHTML();
            }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.VB)
            { Open.Filter = "Visual Basic File|*.vb| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
            { Open.Filter = "Java Script File|*.js| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
            { Open.Filter = "Lua File|*.lua| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
            { Open.Filter = "PHP File|*.php| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.SQL)
            { Open.Filter = "SQL File|*.sql| Any Files|*."; }
            else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.XML)
            { Open.Filter = "XML File|*.xml| Any Files|*."; }
            else { Open.Filter = "Any Files|*."; }
            if (Open.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(Open.FileName);
                fastColoredTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = Path.GetFileName(Open.FileName);

            }
            TitleChange(Open.FileName);
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
            
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.ForeColor = fd.Color;
            }
        }

        private void backGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.BackColor = fd.Color;
            }
        }
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.LineNumberColor = fd.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Font = fd.Font;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Paste();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
            TitleChange("DeCoding");
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowFindDialog();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowGoToDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.ShowReplaceDialog();
        }

        private void Language_Click(object sender, EventArgs e)
        {

        }
        public void AskSave()
        {
            if (fastColoredTextBox1.Text != "")
            {
                if (MessageBox.Show("Deseja salvar o script passado", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Save();
                }
            }
            fastColoredTextBox1.Text = "";
        }

        public void TitleChange(String title)
        {
            lblTitle.Text = title;
        } 
        private void cSharptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
            
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            PrepareHTML();
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
        }

        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL;
        }

        private void vBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.VB;
        }

        private void lUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskSave();
            fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.XML;
        }

        private void Run_Click(object sender, EventArgs e)
        {
            try
            {
                if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
                {
                    HTMLPreview html = new HTMLPreview(fastColoredTextBox1.Text);
                    html.Show();
                }
                else if (fastColoredTextBox1.Language == FastColoredTextBoxNS.Language.JS)
                {
                    HTMLPreview js = new HTMLPreview(fastColoredTextBox1.Text);
                    js.Show();
                }
            }
            catch
            {
                MessageBox.Show("Cannot run this file","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        public void PrepareHTML()
        {
            fastColoredTextBox1.Text =
                      "<html>\n" +
                      " <head>\n   \n</head>\n" +
                      " <body>\n   \n </body>\n" +
                      "</html>";        
        }
        public void InitLanguage()
        {
            fastColoredTextBox1.Language = Properties.Settings.Default.Language;
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void Editor_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Dock = DockStyle.Fill;
        }

        private void EditorNotes_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Dock = DockStyle.Left;
            OpenFileDialog Open = new OpenFileDialog();
            Open.Title = "Escolha um arquivo para ser seu resumo";
            Open.Filter = "Text Files|*.txt";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(Open.FileName);
                sr.Close();
                this.Text = Open.FileName;

            }
        }

        private void ibtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void Send_Click(object sender, EventArgs e)
        {
            if (fastColoredTextBox1.Text != "")
            {
                try
                {
                    Send s = new Send(this);
                    s.Show();
                   
                }
                catch (Exception er)
                { MessageBox.Show(Convert.ToString(er), "Erro ao se conectar", MessageBoxButtons.OK); }
                finally
                {

                }
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void ibtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) { this.WindowState = FormWindowState.Maximized; }
            else { this.WindowState = FormWindowState.Normal; }
        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Community_Click(object sender, EventArgs e)
        {
            Community cm = new Community(this);
            cm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
    }

