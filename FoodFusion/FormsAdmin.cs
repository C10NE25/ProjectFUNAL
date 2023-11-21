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
    public partial class FormsAdmin : Form
    {
        public FormsAdmin()
        {
            InitializeComponent();
        }
        int X = 0;
        int Y = 0;

        private void PanelTBadmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
            else
            {
                Left = Left + (e.X - X);
                Top = Top + (e.Y - Y);
            }
        }

        private void btnCerrarAdmin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
