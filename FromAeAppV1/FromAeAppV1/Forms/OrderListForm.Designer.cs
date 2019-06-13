namespace FromAeAppV1.Forms
{
    partial class OrderListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsbx_orderlist = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_order_cost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_order_quantity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_order_productmodel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_order_email = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_order_username = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order List";
            // 
            // lsbx_orderlist
            // 
            this.lsbx_orderlist.FormattingEnabled = true;
            this.lsbx_orderlist.Location = new System.Drawing.Point(12, 45);
            this.lsbx_orderlist.Name = "lsbx_orderlist";
            this.lsbx_orderlist.Size = new System.Drawing.Size(225, 264);
            this.lsbx_orderlist.TabIndex = 13;
            this.lsbx_orderlist.SelectedIndexChanged += new System.EventHandler(this.lsbx_orderlist_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // lbl_order_cost
            // 
            this.lbl_order_cost.AutoSize = true;
            this.lbl_order_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_cost.Location = new System.Drawing.Point(161, 169);
            this.lbl_order_cost.Name = "lbl_order_cost";
            this.lbl_order_cost.Size = new System.Drawing.Size(0, 18);
            this.lbl_order_cost.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // lbl_order_quantity
            // 
            this.lbl_order_quantity.AutoSize = true;
            this.lbl_order_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_quantity.Location = new System.Drawing.Point(162, 139);
            this.lbl_order_quantity.Name = "lbl_order_quantity";
            this.lbl_order_quantity.Size = new System.Drawing.Size(0, 18);
            this.lbl_order_quantity.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Model";
            // 
            // lbl_order_productmodel
            // 
            this.lbl_order_productmodel.AutoSize = true;
            this.lbl_order_productmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_productmodel.Location = new System.Drawing.Point(162, 104);
            this.lbl_order_productmodel.Name = "lbl_order_productmodel";
            this.lbl_order_productmodel.Size = new System.Drawing.Size(0, 18);
            this.lbl_order_productmodel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cost";
            // 
            // lbl_order_email
            // 
            this.lbl_order_email.AutoSize = true;
            this.lbl_order_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_email.Location = new System.Drawing.Point(161, 67);
            this.lbl_order_email.Name = "lbl_order_email";
            this.lbl_order_email.Size = new System.Drawing.Size(0, 18);
            this.lbl_order_email.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity";
            // 
            // lbl_order_username
            // 
            this.lbl_order_username.AutoSize = true;
            this.lbl_order_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_username.Location = new System.Drawing.Point(161, 35);
            this.lbl_order_username.Name = "lbl_order_username";
            this.lbl_order_username.Size = new System.Drawing.Size(0, 18);
            this.lbl_order_username.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_order_cost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_order_quantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_order_productmodel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_order_email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_order_username);
            this.groupBox1.Location = new System.Drawing.Point(269, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 207);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About Order";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(508, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // OrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 318);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbx_orderlist);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderListForm";
            this.Text = "OrderListForm";
            this.Load += new System.EventHandler(this.OrderListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsbx_orderlist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_order_cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_order_quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_order_productmodel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_order_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_order_username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_back;
    }
}