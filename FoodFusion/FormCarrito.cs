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
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
