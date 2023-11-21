namespace FoodFusion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        int X = 0;
        int Y = 0;
        private void PaneTopBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Asignamos las variable un valor.
            string nombre = txtBUser.Text;
            string password = txtBPassword.Text;

            if (nombre == "admin" && password == "/A@495067") 
            {
                FormsAdmin frm = new FormsAdmin();
                this.Visible = false;
                frm.ShowDialog();
            }
            else if(nombre == "" && password == "")
            {
                frmInicio frm2 = new frmInicio();
                this.Visible = false;
                frm2.ShowDialog();
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