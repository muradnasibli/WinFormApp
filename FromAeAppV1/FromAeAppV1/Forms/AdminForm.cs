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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string connectionStr = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb; Integrated Security=SSPI;";
            SqlConnection sqlConnection = new SqlConnection(connectionStr);
            string query = "SELECT  * FROM Admin WHERE Email = '" + txbx_log_email.Text.Trim() + "' AND Password ='" + txbx_log_pass.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                AddingForm addingForm = new AddingForm();
                this.Hide();
                addingForm.Show();

            }
            else
            {
                MessageBox.Show("Check your email and password");
            }
        }
    }
}
