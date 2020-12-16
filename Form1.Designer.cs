namespace PharmacyApp
{
    partial class Form1
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblauth = new System.Windows.Forms.Label();
            this.cmbauth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(202, 194);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(124, 36);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(373, 194);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(133, 36);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(217, 66);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(289, 20);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(217, 102);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(289, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(157, 66);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(29, 13);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "User";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(157, 102);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblauth
            // 
            this.lblauth.AutoSize = true;
            this.lblauth.Location = new System.Drawing.Point(102, 145);
            this.lblauth.Name = "lblauth";
            this.lblauth.Size = new System.Drawing.Size(109, 13);
            this.lblauth.TabIndex = 6;
            this.lblauth.Text = "Authentecation Mode";
            // 
            // cmbauth
            // 
            this.cmbauth.DisplayMember = "windows";
            this.cmbauth.FormattingEnabled = true;
            this.cmbauth.Items.AddRange(new object[] {
            "windows",
            "SQL server"});
            this.cmbauth.Location = new System.Drawing.Point(217, 142);
            this.cmbauth.Name = "cmbauth";
            this.cmbauth.Size = new System.Drawing.Size(289, 21);
            this.cmbauth.TabIndex = 7;
            this.cmbauth.ValueMember = "windows";
            this.cmbauth.SelectedIndexChanged += new System.EventHandler(this.cmbauth_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(854, 439);
            this.Controls.Add(this.cmbauth);
            this.Controls.Add(this.lblauth);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblauth;
        private System.Windows.Forms.ComboBox cmbauth;
    }
}

