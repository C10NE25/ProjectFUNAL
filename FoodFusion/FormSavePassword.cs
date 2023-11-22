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
    public partial class FormSavePassword : Form
    {
        public FormSavePassword()
        {
            InitializeComponent();
        }

        private void btnCerrarSP_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExpandirSP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo lamentamos esta pestaña no se puede maximizar");
        }

        private void btnMinimizarSP_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
