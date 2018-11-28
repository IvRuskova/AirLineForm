namespace AirLine
{
    partial class Login_form
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
            this.userlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.logbtn = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlbl.Location = new System.Drawing.Point(57, 35);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(73, 16);
            this.userlbl.TabIndex = 0;
            this.userlbl.Text = "User Name";
            this.userlbl.Click += new System.EventHandler(this.userlbl_Click);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.Location = new System.Drawing.Point(57, 97);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(65, 16);
            this.passlbl.TabIndex = 1;
            this.passlbl.Text = "Password";
            // 
            // logbtn
            // 
            this.logbtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logbtn.Location = new System.Drawing.Point(158, 161);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(135, 42);
            this.logbtn.TabIndex = 2;
            this.logbtn.Text = "Login";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(158, 31);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(145, 20);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(158, 93);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(145, 20);
            this.txtpass.TabIndex = 4;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 269);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.userlbl);
            this.Name = "Login_form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
    }
}

