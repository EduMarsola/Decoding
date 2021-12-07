
namespace Code_for_Education
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Run = new System.Windows.Forms.ToolStripDropDownButton();
            this.Settings = new System.Windows.Forms.ToolStripDropDownButton();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Language = new System.Windows.Forms.ToolStripDropDownButton();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSharptoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lUAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Window = new System.Windows.Forms.ToolStripDropDownButton();
            this.Editor = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.EditorFloatNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.Send = new System.Windows.Forms.ToolStripButton();
            this.Community = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.picboxIcon = new System.Windows.Forms.PictureBox();
            this.ibtnMin = new FontAwesome.Sharp.IconButton();
            this.ibtnMax = new FontAwesome.Sharp.IconButton();
            this.ibtnExit = new FontAwesome.Sharp.IconButton();
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(1);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Run,
            this.Settings,
            this.Language,
            this.Window,
            this.Send,
            this.Community});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.White;
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.newToolStripMenuItem});
            this.File.Font = new System.Drawing.Font("Verdana", 9F);
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Name = "File";
            this.File.ShowDropDownArrow = false;
            this.File.Size = new System.Drawing.Size(32, 22);
            this.File.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.White;
            this.Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Run.Font = new System.Drawing.Font("Verdana", 9F);
            this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
            this.Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Run.Name = "Run";
            this.Run.ShowDropDownArrow = false;
            this.Run.Size = new System.Drawing.Size(35, 22);
            this.Run.Text = "Run";
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.White;
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorToolStripMenuItem,
            this.backGroundColorToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.findToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.replaceToolStripMenuItem});
            this.Settings.Font = new System.Drawing.Font("Verdana", 9F);
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.ShowDropDownArrow = false;
            this.Settings.Size = new System.Drawing.Size(63, 22);
            this.Settings.Text = "Settings";
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.foreColorToolStripMenuItem.Text = "ForeColor";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // backGroundColorToolStripMenuItem
            // 
            this.backGroundColorToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.backGroundColorToolStripMenuItem.Name = "backGroundColorToolStripMenuItem";
            this.backGroundColorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.backGroundColorToolStripMenuItem.Text = "BackGround Color";
            this.backGroundColorToolStripMenuItem.Click += new System.EventHandler(this.backGroundColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.lineToolStripMenuItem.Text = "LineNumber Color";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.goToToolStripMenuItem.Text = "Go to";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // Language
            // 
            this.Language.BackColor = System.Drawing.Color.White;
            this.Language.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem,
            this.pHPToolStripMenuItem,
            this.javaScriptToolStripMenuItem,
            this.cSharptoolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.vBToolStripMenuItem,
            this.lUAToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.Language.Font = new System.Drawing.Font("Verdana", 9F);
            this.Language.Image = ((System.Drawing.Image)(resources.GetObject("Language.Image")));
            this.Language.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Language.Name = "Language";
            this.Language.ShowDropDownArrow = false;
            this.Language.Size = new System.Drawing.Size(74, 22);
            this.Language.Text = "Language";
            this.Language.Click += new System.EventHandler(this.Language_Click);
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            this.hTMLToolStripMenuItem.Click += new System.EventHandler(this.hTMLToolStripMenuItem_Click);
            // 
            // pHPToolStripMenuItem
            // 
            this.pHPToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.pHPToolStripMenuItem.Name = "pHPToolStripMenuItem";
            this.pHPToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pHPToolStripMenuItem.Text = "PHP";
            this.pHPToolStripMenuItem.Click += new System.EventHandler(this.pHPToolStripMenuItem_Click);
            // 
            // javaScriptToolStripMenuItem
            // 
            this.javaScriptToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.javaScriptToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.javaScriptToolStripMenuItem.Name = "javaScriptToolStripMenuItem";
            this.javaScriptToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.javaScriptToolStripMenuItem.Text = "JS";
            // 
            // cSharptoolStripMenuItem
            // 
            this.cSharptoolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.cSharptoolStripMenuItem.Enabled = false;
            this.cSharptoolStripMenuItem.Name = "cSharptoolStripMenuItem";
            this.cSharptoolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cSharptoolStripMenuItem.Text = "C#";
            this.cSharptoolStripMenuItem.Visible = false;
            this.cSharptoolStripMenuItem.Click += new System.EventHandler(this.cSharptoolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.sQLToolStripMenuItem.Enabled = false;
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Visible = false;
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // vBToolStripMenuItem
            // 
            this.vBToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.vBToolStripMenuItem.Name = "vBToolStripMenuItem";
            this.vBToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.vBToolStripMenuItem.Text = "VB";
            this.vBToolStripMenuItem.Visible = false;
            this.vBToolStripMenuItem.Click += new System.EventHandler(this.vBToolStripMenuItem_Click);
            // 
            // lUAToolStripMenuItem
            // 
            this.lUAToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.lUAToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.lUAToolStripMenuItem.Name = "lUAToolStripMenuItem";
            this.lUAToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.lUAToolStripMenuItem.Text = "LUA";
            this.lUAToolStripMenuItem.Visible = false;
            this.lUAToolStripMenuItem.Click += new System.EventHandler(this.lUAToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.BackColor = System.Drawing.Color.DimGray;
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Visible = false;
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // Window
            // 
            this.Window.BackColor = System.Drawing.Color.White;
            this.Window.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Editor,
            this.EditorNotes,
            this.EditorFloatNotes});
            this.Window.Font = new System.Drawing.Font("Verdana", 9F);
            this.Window.Image = ((System.Drawing.Image)(resources.GetObject("Window.Image")));
            this.Window.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Window.Name = "Window";
            this.Window.ShowDropDownArrow = false;
            this.Window.Size = new System.Drawing.Size(62, 22);
            this.Window.Text = "Window";
            // 
            // Editor
            // 
            this.Editor.BackColor = System.Drawing.Color.DimGray;
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(219, 22);
            this.Editor.Text = "Editor";
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // EditorNotes
            // 
            this.EditorNotes.BackColor = System.Drawing.Color.DimGray;
            this.EditorNotes.Name = "EditorNotes";
            this.EditorNotes.Size = new System.Drawing.Size(219, 22);
            this.EditorNotes.Text = "Editor + Notes";
            this.EditorNotes.Click += new System.EventHandler(this.EditorNotes_Click);
            // 
            // EditorFloatNotes
            // 
            this.EditorFloatNotes.BackColor = System.Drawing.Color.DimGray;
            this.EditorFloatNotes.Name = "EditorFloatNotes";
            this.EditorFloatNotes.Size = new System.Drawing.Size(219, 22);
            this.EditorFloatNotes.Text = "Editor + Floating Notes";
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.White;
            this.Send.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Send.Font = new System.Drawing.Font("Verdana", 9F);
            this.Send.Image = ((System.Drawing.Image)(resources.GetObject("Send.Image")));
            this.Send.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(43, 22);
            this.Send.Text = "Send";
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Community
            // 
            this.Community.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Community.Font = new System.Drawing.Font("Verdana", 9F);
            this.Community.Image = ((System.Drawing.Image)(resources.GetObject("Community.Image")));
            this.Community.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Community.Name = "Community";
            this.Community.Size = new System.Drawing.Size(81, 22);
            this.Community.Text = "Community";
            this.Community.Click += new System.EventHandler(this.Community_Click);
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
            this.fastColoredTextBox1.ContextMenuStrip = this.contextMenuStrip1;
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
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 25);
            this.fastColoredTextBox1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(798, 428);
            this.fastColoredTextBox1.TabIndex = 2;
            this.fastColoredTextBox1.WordWrap = true;
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // panelMiddle
            // 
            this.panelMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMiddle.AutoSize = true;
            this.panelMiddle.Controls.Add(this.fastColoredTextBox1);
            this.panelMiddle.Controls.Add(this.toolStrip1);
            this.panelMiddle.Location = new System.Drawing.Point(0, 28);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(798, 456);
            this.panelMiddle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(31, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 14);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "DeCoding";
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
            this.panelTop.Size = new System.Drawing.Size(798, 28);
            this.panelTop.TabIndex = 9;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
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
            this.ibtnMin.Location = new System.Drawing.Point(729, 0);
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
            this.ibtnMax.Location = new System.Drawing.Point(752, 0);
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
            this.ibtnExit.Location = new System.Drawing.Point(775, 0);
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(798, 480);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMiddle);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Code for Education ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMiddle.ResumeLayout(false);
            this.panelMiddle.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripDropDownButton Settings;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backGroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Language;
        private System.Windows.Forms.ToolStripMenuItem cSharptoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pHPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lUAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton Run;
        private System.Windows.Forms.ToolStripDropDownButton Window;
        private System.Windows.Forms.ToolStripMenuItem Editor;
        private System.Windows.Forms.ToolStripMenuItem EditorNotes;
        private System.Windows.Forms.ToolStripMenuItem EditorFloatNotes;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton ibtnMin;
        private FontAwesome.Sharp.IconButton ibtnExit;
        private FontAwesome.Sharp.IconButton ibtnMax;
        private System.Windows.Forms.ToolStripMenuItem javaScriptToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ToolStripButton Send;
        private System.Windows.Forms.PictureBox picboxIcon;
        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.ToolStripButton Community;
        public FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    }
}

