
namespace Code_for_Education
{
    partial class WebViewer
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
            this.iconButtonJS = new FontAwesome.Sharp.IconButton();
            this.iconButtonHTML = new FontAwesome.Sharp.IconButton();
            this.iconButtonPHP = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconButtonJS
            // 
            this.iconButtonJS.BackColor = System.Drawing.Color.LightGray;
            this.iconButtonJS.FlatAppearance.BorderSize = 0;
            this.iconButtonJS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonJS.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonJS.IconChar = FontAwesome.Sharp.IconChar.Js;
            this.iconButtonJS.IconColor = System.Drawing.Color.Gold;
            this.iconButtonJS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonJS.IconSize = 80;
            this.iconButtonJS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonJS.Location = new System.Drawing.Point(-1, -1);
            this.iconButtonJS.Name = "iconButtonJS";
            this.iconButtonJS.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.iconButtonJS.Size = new System.Drawing.Size(210, 344);
            this.iconButtonJS.TabIndex = 0;
            this.iconButtonJS.Text = "JavaScript";
            this.iconButtonJS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonJS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonJS.UseVisualStyleBackColor = false;
            this.iconButtonJS.MouseEnter += new System.EventHandler(this.iconButtonJS_MouseEnter);
            this.iconButtonJS.MouseLeave += new System.EventHandler(this.iconButtonJS_MouseLeave);
            // 
            // iconButtonHTML
            // 
            this.iconButtonHTML.BackColor = System.Drawing.Color.LightGray;
            this.iconButtonHTML.FlatAppearance.BorderSize = 0;
            this.iconButtonHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHTML.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonHTML.IconChar = FontAwesome.Sharp.IconChar.Html5;
            this.iconButtonHTML.IconColor = System.Drawing.Color.Orange;
            this.iconButtonHTML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHTML.IconSize = 80;
            this.iconButtonHTML.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonHTML.Location = new System.Drawing.Point(209, -1);
            this.iconButtonHTML.Name = "iconButtonHTML";
            this.iconButtonHTML.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.iconButtonHTML.Size = new System.Drawing.Size(210, 344);
            this.iconButtonHTML.TabIndex = 1;
            this.iconButtonHTML.Text = "HTML";
            this.iconButtonHTML.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonHTML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonHTML.UseVisualStyleBackColor = false;
            this.iconButtonHTML.MouseEnter += new System.EventHandler(this.iconButtonHTML_MouseEnter);
            this.iconButtonHTML.MouseLeave += new System.EventHandler(this.iconButtonHTML_MouseLeave);
            // 
            // iconButtonPHP
            // 
            this.iconButtonPHP.BackColor = System.Drawing.Color.LightGray;
            this.iconButtonPHP.FlatAppearance.BorderSize = 0;
            this.iconButtonPHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPHP.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.iconButtonPHP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButtonPHP.IconChar = FontAwesome.Sharp.IconChar.Php;
            this.iconButtonPHP.IconColor = System.Drawing.Color.SteelBlue;
            this.iconButtonPHP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPHP.IconSize = 80;
            this.iconButtonPHP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonPHP.Location = new System.Drawing.Point(419, -1);
            this.iconButtonPHP.Name = "iconButtonPHP";
            this.iconButtonPHP.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.iconButtonPHP.Size = new System.Drawing.Size(210, 344);
            this.iconButtonPHP.TabIndex = 2;
            this.iconButtonPHP.Text = "PHP";
            this.iconButtonPHP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonPHP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButtonPHP.UseVisualStyleBackColor = false;
            this.iconButtonPHP.Click += new System.EventHandler(this.iconButton1_Click);
            this.iconButtonPHP.MouseEnter += new System.EventHandler(this.iconButtonPHP_MouseEnter);
            this.iconButtonPHP.MouseLeave += new System.EventHandler(this.iconButtonPHP_MouseLeave);
            // 
            // WebViewer
            // 
            this.ClientSize = new System.Drawing.Size(629, 271);
            this.Controls.Add(this.iconButtonPHP);
            this.Controls.Add(this.iconButtonHTML);
            this.Controls.Add(this.iconButtonJS);
            this.Name = "WebViewer";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnJS;
        private FontAwesome.Sharp.IconButton iconButtonJS;
        private FontAwesome.Sharp.IconButton iconButtonHTML;
        private FontAwesome.Sharp.IconButton iconButtonPHP;
    }
}