namespace FromAeAppV1.Forms
{
    partial class OrderForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lsbx_product_models = new System.Windows.Forms.ListBox();
            this.lbl_product_model = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_product_cost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_product_color = new System.Windows.Forms.Label();
            this.lbl_product_ram = new System.Windows.Forms.Label();
            this.lbl_product_os = new System.Windows.Forms.Label();
            this.lbl_product_scrtype = new System.Windows.Forms.Label();
            this.lbl_product_memory = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(175, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lsbx_product_models
            // 
            this.lsbx_product_models.FormattingEnabled = true;
            this.lsbx_product_models.Location = new System.Drawing.Point(12, 30);
            this.lsbx_product_models.Name = "lsbx_product_models";
            this.lsbx_product_models.Size = new System.Drawing.Size(132, 277);
            this.lsbx_product_models.TabIndex = 1;
            this.lsbx_product_models.SelectedIndexChanged += new System.EventHandler(this.lsbx_product_models_SelectedIndexChanged);
            // 
            // lbl_product_model
            // 
            this.lbl_product_model.AutoSize = true;
            this.lbl_product_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_model.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_product_model.Location = new System.Drawing.Point(224, 213);
            this.lbl_product_model.Name = "lbl_product_model";
            this.lbl_product_model.Size = new System.Drawing.Size(0, 20);
            this.lbl_product_model.TabIndex = 2;
            this.lbl_product_model.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ScreenType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "OS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "RAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Color";
            // 
            // lbl_product_cost
            // 
            this.lbl_product_cost.AutoSize = true;
            this.lbl_product_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_cost.Location = new System.Drawing.Point(235, 234);
            this.lbl_product_cost.Name = "lbl_product_cost";
            this.lbl_product_cost.Size = new System.Drawing.Size(0, 20);
            this.lbl_product_cost.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_product_color);
            this.groupBox1.Controls.Add(this.lbl_product_ram);
            this.groupBox1.Controls.Add(this.lbl_product_os);
            this.groupBox1.Controls.Add(this.lbl_product_scrtype);
            this.groupBox1.Controls.Add(this.lbl_product_memory);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(343, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 221);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // lbl_product_color
            // 
            this.lbl_product_color.AutoSize = true;
            this.lbl_product_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_color.Location = new System.Drawing.Point(135, 174);
            this.lbl_product_color.Name = "lbl_product_color";
            this.lbl_product_color.Size = new System.Drawing.Size(0, 20);
            this.lbl_product_color.TabIndex = 12;
            // 
            // lbl_product_ram
            // 
            this.lbl_product_ram.AutoSize = true;
            this.lbl_product_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_ram.Location = new System.Drawing.Point(135, 143);
            this.lbl_product_ram.Name = "lbl_product_ram";
            this.lbl_product_ram.Size = new System.Drawing.Size(0, 20);
            this.lbl_product_ram.TabIndex = 11;
            // 
            // lbl_product_os
            // 
            this.lbl_product_os.AutoSize = true;
            this.lbl_product_os.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_os.Location = new System.Drawing.Point(135, 112);
            this.lbl_product_os.Name = "lbl_product_os";
            this.lbl_product_os.Size = new System.Drawing.Size(0, 20);
            this.lbl_product_os.TabIndex = 10;
            // 
            // lbl_product_scrtype
            // 
            this.lbl_product_scrtype.AutoSize = true;
            this.lbl_product_scrtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_scrtype.Location = new System.Drawing.Point(135, 79);
            this.lbl_product_scrtype.Name = "lbl_product_scrtype";
            this.lbl_product_scrtype.Size = new System.Drawing.Size(0, 20);
            this.lbl_product_scrtype.TabIndex = 9;
            // 
            // lbl_product_memory
            // 
            this.lbl_product_memory.AutoSize = true;
            this.lbl_product_memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_memory.Location = new System.Drawing.Point(135, 47);
            this.lbl_product_memory.Name = "lbl_product_memory";
            this.lbl_product_memory.Size = new System.Drawing.Size(0, 20);
            this.lbl_product_memory.TabIndex = 8;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(175, 268);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(134, 39);
            this.btn_buy.TabIndex = 10;
            this.btn_buy.Text = "BUY";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "This models are in stock";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.lbl_product_cost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_product_model);
            this.Controls.Add(this.lsbx_product_models);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lsbx_product_models;
        private System.Windows.Forms.Label lbl_product_model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_product_cost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label lbl_product_color;
        private System.Windows.Forms.Label lbl_product_ram;
        private System.Windows.Forms.Label lbl_product_os;
        private System.Windows.Forms.Label lbl_product_scrtype;
        private System.Windows.Forms.Label lbl_product_memory;
        private System.Windows.Forms.Label label1;
    }
}