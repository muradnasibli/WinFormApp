using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FromAeAppV1.UserControls;
using System.Data.SqlClient;
using FromAeAppV1.NewFolder1;

namespace FromAeAppV1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //List<Product> products = new List<Product>();

            //string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI";
            //using (SqlConnection connection = new SqlConnection(conString))
            //{
            //    connection.Open();

            //    string query = "SELECT Id,Model FROM PhoneDescription";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        using (SqlDataReader sqlDataReader = command.ExecuteReader())
            //        {
            //            while (sqlDataReader.Read())
            //            {
            //                Product product = new Product
            //                {
            //                    Id = int.Parse(sqlDataReader["Id"].ToString()),
            //                    Model = sqlDataReader["Model"].ToString()
            //                };
            //            }
            //        }
            //    }
            //
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.Show();
        }
    }
}
