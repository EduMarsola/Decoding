
namespace Code_for_Education
{
    partial class Community
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Community));
            this.panelTop = new System.Windows.Forms.Panel();
            this.picboxIcon = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ibtnMin = new FontAwesome.Sharp.IconButton();
            this.ibtnMax = new FontAwesome.Sharp.IconButton();
            this.ibtnExit = new FontAwesome.Sharp.IconButton();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBoxSearch = new System.Windows.Forms.RichTextBox();
            this.tcc1DataSet = new Code_for_Education.Tcc1DataSet();
            this.tcc1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcc1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc1DataSetBindingSource)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(951, 28);
            this.panelTop.TabIndex = 10;
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
            this.ibtnMin.Location = new System.Drawing.Point(882, 0);
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
            this.ibtnMax.Location = new System.Drawing.Point(905, 0);
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
            this.ibtnExit.Location = new System.Drawing.Point(928, 0);
            this.ibtnExit.Name = "ibtnExit";
            this.ibtnExit.Size = new System.Drawing.Size(23, 28);
            this.ibtnExit.TabIndex = 7;
            this.ibtnExit.UseVisualStyleBackColor = false;
            this.ibtnExit.Click += new System.EventHandler(this.ibtnExit_Click);
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this.panelTop;
            this.dragControl.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fastColoredTextBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 627);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fastColoredTextBox1
            // 
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
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.WhiteSmoke;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(34, 323);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(896, 233);
            this.fastColoredTextBox1.TabIndex = 4;
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(844, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.AutoScroll = true;
            this.panelSearch.AutoSize = true;
            this.panelSearch.Controls.Add(this.flowLayoutPanel1);
            this.panelSearch.Controls.Add(this.richTextBoxSearch);
            this.panelSearch.Location = new System.Drawing.Point(34, 28);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(894, 289);
            this.panelSearch.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(888, 255);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // richTextBoxSearch
            // 
            this.richTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSearch.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.richTextBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxSearch.Name = "richTextBoxSearch";
            this.richTextBoxSearch.Size = new System.Drawing.Size(888, 22);
            this.richTextBoxSearch.TabIndex = 0;
            this.richTextBoxSearch.Text = "Pesquise por funções aqui.";
            this.richTextBoxSearch.Click += new System.EventHandler(this.richTextBoxSearch_Click);
            this.richTextBoxSearch.TextChanged += new System.EventHandler(this.richTextBoxSearch_TextChanged);
            this.richTextBoxSearch.Enter += new System.EventHandler(this.richTextBoxSearch_Enter);
            // 
            // tcc1DataSet
            // 
            this.tcc1DataSet.DataSetName = "Tcc1DataSet";
            this.tcc1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcc1DataSetBindingSource
            // 
            this.tcc1DataSetBindingSource.DataSource = this.tcc1DataSet;
            this.tcc1DataSetBindingSource.Position = 0;
            // 
            // Community
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(950, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Community";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Community";
            this.Load += new System.EventHandler(this.Community_Load);
            this.Resize += new System.EventHandler(this.Community_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcc1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcc1DataSetBindingSource)).EndInit();
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
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tcc1DataSetBindingSource;
        private Tcc1DataSet tcc1DataSet;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.RichTextBox richTextBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}