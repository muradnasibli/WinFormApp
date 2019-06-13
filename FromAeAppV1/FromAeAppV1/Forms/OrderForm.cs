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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        
        private void OrderForm_Load(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>();
            
            string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI";
            using(SqlConnection sqlConnection = new SqlConnection(conString))
            {
                sqlConnection.Open();

                string query = "SELECT Id,Model FROM PhoneDescription";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Product product = new Product
                            {
                                Id = int.Parse(sqlDataReader["Id"].ToString()),
                                Model = sqlDataReader["Model"].ToString()
                            };
                            list.Add(product);
                        }
                    }
                }
            }
            lsbx_product_models.DisplayMember = "Model";
            lsbx_product_models.ValueMember = "Id";

            lsbx_product_models.DataSource = list;
            //lbl_username.Text = user.Name;



        }

        private void lsbx_product_models_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = new Product();

            int id = int.Parse(lsbx_product_models.SelectedValue.ToString());

            string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI";
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                sqlConnection.Open();

                string query = "SELECT Id,Model,Memory,ScreenType,OS,RAM,Color,Cost,Path FROM PhoneDescription WHERE Id = @p1";
                using(SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@p1", id);
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            product = new Product
                            {
                                Id = int.Parse(sqlDataReader["Id"].ToString()),
                                Model = sqlDataReader["Model"].ToString(),
                                Memory = sqlDataReader["Memory"].ToString(),
                                ScreenType = sqlDataReader["ScreenType"].ToString(),
                                OS = sqlDataReader["OS"].ToString(),
                                RAM = sqlDataReader["RAM"].ToString(),
                                Color = sqlDataReader["Color"].ToString(),
                                Cost = decimal.Parse(sqlDataReader["Cost"].ToString()),
                                Path = sqlDataReader["Path"].ToString()
                            };
                        }
                    }
                }
                lbl_product_model.Text = product.Model;
                lbl_product_memory.Text = product.Memory;
                lbl_product_scrtype.Text = product.ScreenType;
                lbl_product_os.Text = product.OS;
                lbl_product_ram.Text = product.RAM;
                lbl_product_color.Text = product.Color;
                lbl_product_cost.Text = product.Cost.ToString();

                

                string path = Environment.CurrentDirectory + "/photos/" + product.Path;
                pictureBox1.Load(path);
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            BuyingForm buyingForm = new BuyingForm();
            this.Hide();
            buyingForm.Show();
            
        }
    }
}
