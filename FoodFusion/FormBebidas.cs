using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodFusion
{
    public partial class FormBebidas : Form
    {
        public FormBebidas()
        {
            InitializeComponent();
        }

        private void lblBebidas_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormThanks form = new FormThanks();
            this.Visible = false;
            form.ShowDialog();
        }
    }
}
