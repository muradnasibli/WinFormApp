using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FromAeAppV1.Forms
{
    public partial class BuyingForm : Form
    {
        public BuyingForm()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            int affectedRows = 0;
            
            string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string query = "INSERT INTO BuyerList(Name,Email,Model,Quantity,Cost) VALUES(@p1,@p2,@p3,@p4,@p5)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@p1", txbx_buyer_name.Text);
                    command.Parameters.AddWithValue("@p2", txbx_buyer_email.Text);
                    command.Parameters.AddWithValue("@p3", txbx_buyer_model.Text);
                    command.Parameters.AddWithValue("@p4", txbx_buyer_quantity.Text);
                    command.Parameters.AddWithValue("@p5", txbx_model_cost.Text);
                   
                    affectedRows = command.ExecuteNonQuery();

                }
            }

            if (affectedRows == 0)
            {
                MessageBox.Show("Your Order failed");
            }
            else
            {
                MessageBox.Show("Your Order Completed!");

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            this.Hide();
            order.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.Show();
        }
    }
}

