namespace PharmacyApp
{
    partial class custfrm
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbladress = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(105, 408);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(108, 49);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(415, 408);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(108, 49);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(257, 408);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(108, 49);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(34, 46);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(134, 20);
            this.txtid.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(509, 46);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(269, 20);
            this.txtemail.TabIndex = 4;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(322, 46);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(184, 20);
            this.txtphone.TabIndex = 5;
            this.txtphone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(171, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(148, 20);
            this.txtname.TabIndex = 6;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(74, 20);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "ID";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(591, 20);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(386, 20);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(38, 13);
            this.lblphone.TabIndex = 9;
            this.lblphone.Text = "Phone";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(211, 20);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 10;
            this.lblname.Text = "Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(554, 437);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(601, 411);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(63, 13);
            this.lblsearch.TabIndex = 12;
            this.lblsearch.Text = "search here";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 293);
            this.dataGridView1.TabIndex = 13;
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.Location = new System.Drawing.Point(74, 73);
            this.lbladress.Name = "lbladress";
            this.lbladress.Size = new System.Drawing.Size(45, 13);
            this.lbladress.TabIndex = 14;
            this.lbladress.Text = "Address";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(34, 89);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(184, 20);
            this.txtadd.TabIndex = 15;
            // 
            // custfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 548);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.lbladress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnsave);
            this.Name = "custfrm";
            this.Text = "custfrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbladress;
        private System.Windows.Forms.TextBox txtadd;
    }
}