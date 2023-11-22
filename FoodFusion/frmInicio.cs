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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private List<Producto> productosSeleccionados = new List<Producto>();
        public class Producto
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }

            public override string ToString()
            {
                return $"{Nombre} - ${Precio}";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private string ObtenerNombreProducto(string nombreCheckBox)
        {
            switch (nombreCheckBox)
            {
                case "cbxSalchi1":
                    return "Salchi Hotdog - La económica";
                case "cbxSalchi2":
                case "cbxSalchi3":
                    return "Salchi Hotdog - A lo pobre";
                case "cbxSalchi4":
                    return "Salchi Hotdog - La revuelta";
                case "cbxBebida1":
                case "cbxBebida2":
                    return "Inka Cola 1L";
                case "cbxBebida3":
                    return "Jarra de Chicha morada 1L";
                case "cbxBebida4":
                    return "Jarra de Limonada Frozen 1L";
                default:
                    return "";
            }
        }

        private decimal ObtenerPrecioPorProducto(string nombreCheckBox)
        {
            switch (nombreCheckBox)
            {
                case "cbxSalchi1":
                    return 12.50m;
                case "cbxSalchi2":
                case "cbxSalchi3":
                case "cbxSalchi4":
                    return 17.90m;
                case "cbxBebida1":
                case "cbxBebida2":
                    return 7m;
                case "cbxBebida3":
                    return 10m;
                case "cbxBebida4":
                    return 12m;
                default:
                    return 0m;
            }
        }



        private void btnComprar_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    // Configura la propiedad Tag al crear el CheckBox
                    checkBox.Tag = new Producto
                    {
                        Nombre = ObtenerNombreProducto(checkBox.Name),
                        Precio = ObtenerPrecioPorProducto(checkBox.Name)
                    };

                    // Recupera la información del Tag asociado al CheckBox
                    Producto producto = (Producto)checkBox.Tag;

                    productosSeleccionados.Add(producto);
                }
            }




            FormCarrito form = new FormCarrito(productosSeleccionados);
            this.Visible = false;
            form.ShowDialog();
        }

        }
    

}
