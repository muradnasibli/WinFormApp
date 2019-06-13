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

namespace FromAeAppV1.NewFolder1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            int affectedRows = 0;

            string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI;";
            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                sqlConnection.Open();

                string query = "INSERT INTO RegisteredUsers(Name,Surname,Email,Password) VALUES(@p1,@p2,@p3,@p4)";
                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@p1", txbx_reg_name.Text);
                    command.Parameters.AddWithValue("@p2", txbx_reg_surname.Text);
                    command.Parameters.AddWithValue("@p3", txbx_reg_email.Text);
                    command.Parameters.AddWithValue("@p4", txbx_reg_pass.Text);

                    affectedRows = command.ExecuteNonQuery();
                }
            }
            if (affectedRows == 0)
            {
                MessageBox.Show("Registration Failed");
            }
            else
            {
                MessageBox.Show("Registration completed");
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            this.Hide();
            admin.ShowDialog();
        }
    }
}
