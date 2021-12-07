
namespace Code_for_Education
{
    partial class Login
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.brnSignIn = new System.Windows.Forms.Button();
            this.cboxPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(22, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(22, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Password";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Code_for_Education.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(22, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(22, 136);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit ";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // brnSignIn
            // 
            this.brnSignIn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.brnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnSignIn.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnSignIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.brnSignIn.Location = new System.Drawing.Point(103, 136);
            this.brnSignIn.Name = "brnSignIn";
            this.brnSignIn.Size = new System.Drawing.Size(75, 28);
            this.brnSignIn.TabIndex = 6;
            this.brnSignIn.Text = "Sign in";
            this.brnSignIn.UseVisualStyleBackColor = false;
            // 
            // cboxPassword
            // 
            this.cboxPassword.AutoSize = true;
            this.cboxPassword.Checked = true;
            this.cboxPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxPassword.Location = new System.Drawing.Point(268, 102);
            this.cboxPassword.Name = "cboxPassword";
            this.cboxPassword.Size = new System.Drawing.Size(15, 14);
            this.cboxPassword.TabIndex = 8;
            this.cboxPassword.UseVisualStyleBackColor = true;
            this.cboxPassword.CheckedChanged += new System.EventHandler(this.cboxPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(302, 186);
            this.Controls.Add(this.cboxPassword);
            this.Controls.Add(this.brnSignIn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button brnSignIn;
        private System.Windows.Forms.CheckBox cboxPassword;
    }
}