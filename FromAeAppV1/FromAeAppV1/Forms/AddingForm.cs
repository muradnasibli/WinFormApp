using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using FromAeAppV1.Forms;

namespace FromAeAppV1.Forms
{
    public partial class AddingForm : Form
    {
        public AddingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }


        }

        private void Btn_save_info_Click(object sender, EventArgs e)
        {
            int affectedRows = 0;

            FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);

            string path = Environment.CurrentDirectory + "/Photos/" + fileInfo.Name;
            File.Copy(openFileDialog1.FileName, path);

            string conString = "Data Source=MURAD-PC;Initial Catalog=FromAeAppDb;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string query = "INSERT INTO PhoneDescription(Model,Memory,ScreenType,OS,RAM,Color,Cost,Path) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@p1", txbx_model.Text);
                    command.Parameters.AddWithValue("@p2", txbx_memory.Text);
                    command.Parameters.AddWithValue("@p3", txbx_scrtype.Text);
                    command.Parameters.AddWithValue("@p4", txbx_os.Text);
                    command.Parameters.AddWithValue("@p5", txbx_ram.Text);
                    command.Parameters.AddWithValue("@p6", txbx_color.Text);
                    command.Parameters.AddWithValue("@p7", txbx_cost.Text);
                    command.Parameters.AddWithValue("@p8", fileInfo.Name);
                    
                    affectedRows = command.ExecuteNonQuery();

                }
            }

            if (affectedRows == 0)
            {
                MessageBox.Show("Save Information in DB failed!");
            }
            else
            {
                MessageBox.Show("Information saved in DB !");
                
            }
        }

        private void btn_view_orders_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            this.Hide();
            order.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderListForm list = new OrderListForm();
            this.Hide();
            list.Show();
        }
    }
}
