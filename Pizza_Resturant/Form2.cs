using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Resturant
{
    public partial class PizzLicious : Form
    {
        public PizzLicious()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form frm = new PizzaOrder();
            frm.Show();
        }
    }
}
