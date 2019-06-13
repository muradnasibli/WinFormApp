using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromAeAppV1.UserControls
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }

        public int Id { get; internal set; }
        public string Model { get; internal set; }
    }
}
