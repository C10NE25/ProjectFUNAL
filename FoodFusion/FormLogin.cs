using System.Windows.Forms;

namespace FoodFusion
{
    public partial class FormLogin : Form
    {
        int X = 0;
        int Y = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void PaneTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lo lamentamos, esta pestaña no se puede agrandar");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Asignamos las variable un valor.
            string nombre = txtBUser.Text;
            string password = txtBPassword.Text;

            if (nombre == "admin" && password == "/A@495067")
            {
                frmControllerUser frm1 = new frmControllerUser();
                this.Visible = false;
                frm1.StartPosition = FormStartPosition.CenterParent;
                frm1.ShowDialog();
            }
            else if (nombre == "kitchen" && password == "/@R2014")
            {
                FormsAdmin frm2 = new FormsAdmin();
                this.Visible = false;
                frm2.ShowDialog();
            }
            else if (nombre == "" && password == "")
            {
                frmInicio frm3 = new frmInicio();
                this.Visible = false;
                frm3.StartPosition = FormStartPosition.CenterParent;
                frm3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error: Revise los datos nuevamente");
            }
            //Hacer una funcion que valide los datos dentro del datagriedview

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void PanelBarLogin_MouseMove(object sender, MouseEventArgs e)
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

        private void PbxLogin_Click(object sender, EventArgs e)
        {

        }

        private void lklRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Lleva hacia el nuevo formulario
            FormRegister frm = new FormRegister();
            frm.Owner = this;
            //Inicia la posición en el centro y bloquea el formulario principal
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void lklSavePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSavePassword Save = new FormSavePassword();
            Save.Owner = this;
            Save.ShowDialog();

        }
    }
}