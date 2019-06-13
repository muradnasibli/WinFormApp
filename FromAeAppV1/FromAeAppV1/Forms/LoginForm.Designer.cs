namespace FromAeAppV1.Forms
{
    partial class LoginForm
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
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.txbx_log_pass = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txbx_log_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Red;
            this.btn_login.Location = new System.Drawing.Point(108, 272);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(178, 43);
            this.btn_login.TabIndex = 29;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(151, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Login";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPas.Location = new System.Drawing.Point(41, 191);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(86, 20);
            this.labelPas.TabIndex = 27;
            this.labelPas.Text = "Password :";
            // 
            // txbx_log_pass
            // 
            this.txbx_log_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_log_pass.Location = new System.Drawing.Point(169, 188);
            this.txbx_log_pass.Name = "txbx_log_pass";
            this.txbx_log_pass.Size = new System.Drawing.Size(201, 26);
            this.txbx_log_pass.TabIndex = 26;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Email.Location = new System.Drawing.Point(41, 143);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 20);
            this.Email.TabIndex = 25;
            this.Email.Text = "Email :";
            // 
            // txbx_log_email
            // 
            this.txbx_log_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_log_email.Location = new System.Drawing.Point(169, 140);
            this.txbx_log_email.Name = "txbx_log_email";
            this.txbx_log_email.Size = new System.Drawing.Size(201, 26);
            this.txbx_log_email.TabIndex = 24;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 370);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.txbx_log_pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txbx_log_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox txbx_log_pass;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txbx_log_email;
    }
}