using FromAeAppV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAeAppV1.Forms
{
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            List<Order> list = new List<Order>();

            string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI";
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                sqlConnection.Open();

                string query = "SELECT Id,Name FROM BuyerList";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Order order = new Order
                            {
                                Id = int.Parse(sqlDataReader["Id"].ToString()),
                                Name = sqlDataReader["Name"].ToString()
                            };
                            list.Add(order);
                        }
                    }
                }
            }
            lsbx_orderlist.DisplayMember = "Name";
            lsbx_orderlist.ValueMember = "Id";

            lsbx_orderlist.DataSource = list;
        }

        private void lsbx_orderlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = new Order();

            int id = int.Parse(lsbx_orderlist.SelectedValue.ToString());

            string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI";
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                sqlConnection.Open();

                string query = "SELECT Id,Name,Email,Model,Quantity,Cost FROM BuyerList WHERE Id = @p1";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@p1", id);
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            order = new Order
                            {
                                Id = int.Parse(sqlDataReader["Id"].ToString()),
                                Name = sqlDataReader["Name"].ToString(),
                                Email = sqlDataReader["Email"].ToString(),
                                Model = sqlDataReader["Model"].ToString(),
                                Quantity = decimal.Parse(sqlDataReader["Quantity"].ToString()),
                                Cost = decimal.Parse(sqlDataReader["Cost"].ToString()),
                            };
                        }
                    }
                }
                lbl_order_username.Text = order.Name;
                lbl_order_email.Text = order.Email;
                lbl_order_productmodel.Text = order.Model;
                lbl_order_quantity.Text = order.Quantity.ToString();
                lbl_order_cost.Text = order.Cost.ToString();

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            AddingForm add = new AddingForm();
            this.Hide();
            add.Show();
        }
    }
 
}
