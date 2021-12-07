
namespace Code_for_Education
{
    partial class Send
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send));
            this.panelTop = new System.Windows.Forms.Panel();
            this.picboxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ibtnMin = new FontAwesome.Sharp.IconButton();
            this.ibtnMax = new FontAwesome.Sharp.IconButton();
            this.ibtnExit = new FontAwesome.Sharp.IconButton();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.richTextBoxDescri = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.AutoSize = true;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.panelTop.Controls.Add(this.picboxIcon);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.ibtnMin);
            this.panelTop.Controls.Add(this.ibtnMax);
            this.panelTop.Controls.Add(this.ibtnExit);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(823, 28);
            this.panelTop.TabIndex = 11;
            // 
            // picboxIcon
            // 
            this.picboxIcon.Image = global::Code_for_Education.Properties.Resources.Logo__2_;
            this.picboxIcon.Location = new System.Drawing.Point(3, 3);
            this.picboxIcon.Name = "picboxIcon";
            this.picboxIcon.Size = new System.Drawing.Size(22, 22);
            this.picboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxIcon.TabIndex = 3;
            this.picboxIcon.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(31, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 14);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "DeCoding Community";
            // 
            // ibtnMin
            // 
            this.ibtnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.ibtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnMin.FlatAppearance.BorderSize = 0;
            this.ibtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMin.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnMin.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.ibtnMin.IconColor = System.Drawing.Color.Azure;
            this.ibtnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMin.IconSize = 20;
            this.ibtnMin.Location = new System.Drawing.Point(754, 0);
            this.ibtnMin.Name = "ibtnMin";
            this.ibtnMin.Size = new System.Drawing.Size(23, 28);
            this.ibtnMin.TabIndex = 6;
            this.ibtnMin.UseVisualStyleBackColor = false;
            this.ibtnMin.Click += new System.EventHandler(this.ibtnMin_Click);
            // 
            // ibtnMax
            // 
            this.ibtnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.ibtnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnMax.FlatAppearance.BorderSize = 0;
            this.ibtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMax.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnMax.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.ibtnMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ibtnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMax.IconSize = 20;
            this.ibtnMax.Location = new System.Drawing.Point(777, 0);
            this.ibtnMax.Name = "ibtnMax";
            this.ibtnMax.Size = new System.Drawing.Size(23, 28);
            this.ibtnMax.TabIndex = 8;
            this.ibtnMax.UseVisualStyleBackColor = false;
            this.ibtnMax.Click += new System.EventHandler(this.ibtnMax_Click);
            // 
            // ibtnExit
            // 
            this.ibtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.ibtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnExit.FlatAppearance.BorderSize = 0;
            this.ibtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExit.ForeColor = System.Drawing.Color.DimGray;
            this.ibtnExit.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.ibtnExit.IconColor = System.Drawing.Color.DarkRed;
            this.ibtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExit.IconSize = 20;
            this.ibtnExit.Location = new System.Drawing.Point(800, 0);
            this.ibtnExit.Name = "ibtnExit";
            this.ibtnExit.Size = new System.Drawing.Size(23, 28);
            this.ibtnExit.TabIndex = 7;
            this.ibtnExit.UseVisualStyleBackColor = false;
            this.ibtnExit.Click += new System.EventHandler(this.ibtnExit_Click);
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(0, 16);
            this.fastColoredTextBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 16;
            this.fastColoredTextBox1.CharWidth = 9;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.Beige;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(75, 246);
            this.fastColoredTextBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(702, 309);
            this.fastColoredTextBox1.TabIndex = 9;
            this.fastColoredTextBox1.WordWrap = true;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(156, 48);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(233, 31);
            this.textBoxNome.TabIndex = 12;
            // 
            // richTextBoxDescri
            // 
            this.richTextBoxDescri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescri.Location = new System.Drawing.Point(110, 86);
            this.richTextBoxDescri.Name = "richTextBoxDescri";
            this.richTextBoxDescri.Size = new System.Drawing.Size(667, 141);
            this.richTextBoxDescri.TabIndex = 14;
            this.richTextBoxDescri.Text = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(664, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Compartilhar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nome da função:";
            // 
            // Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(823, 607);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxDescri);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Send";
            this.Text = "Send";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picboxIcon;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton ibtnMin;
        private FontAwesome.Sharp.IconButton ibtnMax;
        private FontAwesome.Sharp.IconButton ibtnExit;
        public FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.RichTextBox richTextBoxDescri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}