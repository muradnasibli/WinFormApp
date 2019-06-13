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
using FromAeAppV1.Forms;

namespace FromAeAppV1.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string connectionStr = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb; Integrated Security=SSPI;";

            //using (SqlConnection connection = new SqlConnection(connectionStr)) 
            //{
            //    connection.Open();

            //    string query = "SELECT  * FROM RegisteredUsers WHERE Email = @p1  AND Password = @p2";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@p1", txbx_log_email.Text.Trim());
            //        command.Parameters.AddWithValue("@p2", txbx_log_pass.Text.Trim());
            //    }
            //}
            
            SqlConnection sqlConnection = new SqlConnection(connectionStr);
            string query = "SELECT  * FROM RegisteredUsers WHERE Email = '" + txbx_log_email.Text.Trim() + "' AND Password ='" + txbx_log_pass.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                OrderForm ordForm = new OrderForm();
                this.Hide();
                ordForm.Show();

            }
            else
            {
                MessageBox.Show("Check your email and password");
            }
        }
    }
}
