namespace FromAeAppV1.NewFolder1
{
    partial class RegistrationForm
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
            this.btn_register = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPas = new System.Windows.Forms.Label();
            this.txbx_reg_pass = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.txbx_reg_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_reg_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_reg_name = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Red;
            this.btn_register.Location = new System.Drawing.Point(102, 319);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(178, 43);
            this.btn_register.TabIndex = 19;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(131, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Registration";
            // 
            // labelPas
            // 
            this.labelPas.AutoSize = true;
            this.labelPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPas.Location = new System.Drawing.Point(51, 260);
            this.labelPas.Name = "labelPas";
            this.labelPas.Size = new System.Drawing.Size(86, 20);
            this.labelPas.TabIndex = 17;
            this.labelPas.Text = "Password :";
            // 
            // txbx_reg_pass
            // 
            this.txbx_reg_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_reg_pass.Location = new System.Drawing.Point(179, 257);
            this.txbx_reg_pass.Name = "txbx_reg_pass";
            this.txbx_reg_pass.Size = new System.Drawing.Size(201, 26);
            this.txbx_reg_pass.TabIndex = 16;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Email.Location = new System.Drawing.Point(51, 212);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 20);
            this.Email.TabIndex = 15;
            this.Email.Text = "Email :";
            // 
            // txbx_reg_email
            // 
            this.txbx_reg_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_reg_email.Location = new System.Drawing.Point(179, 209);
            this.txbx_reg_email.Name = "txbx_reg_email";
            this.txbx_reg_email.Size = new System.Drawing.Size(201, 26);
            this.txbx_reg_email.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(51, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Surname :";
            // 
            // txbx_reg_surname
            // 
            this.txbx_reg_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_reg_surname.Location = new System.Drawing.Point(179, 161);
            this.txbx_reg_surname.Name = "txbx_reg_surname";
            this.txbx_reg_surname.Size = new System.Drawing.Size(201, 26);
            this.txbx_reg_surname.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(51, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name :";
            // 
            // txbx_reg_name
            // 
            this.txbx_reg_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_reg_name.Location = new System.Drawing.Point(179, 118);
            this.txbx_reg_name.Name = "txbx_reg_name";
            this.txbx_reg_name.Size = new System.Drawing.Size(201, 26);
            this.txbx_reg_name.TabIndex = 10;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(183, 12);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(97, 24);
            this.btn_login.TabIndex = 20;
            this.btn_login.Text = "Login as User";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Login as Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPas);
            this.Controls.Add(this.txbx_reg_pass);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.txbx_reg_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_reg_surname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_reg_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPas;
        private System.Windows.Forms.TextBox txbx_reg_pass;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox txbx_reg_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_reg_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_reg_name;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
    }
}