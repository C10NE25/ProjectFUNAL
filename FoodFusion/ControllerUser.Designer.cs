namespace FoodFusion
{
    partial class frmControllerUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvResultado = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            btnModificar = new Button();
            btnClean = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            txtNombre = new TextBox();
            btmAgregar = new Button();
            label5 = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Columns.AddRange(new DataGridViewColumn[] { Nombre, Password, Email, Username, Codigo });
            dgvResultado.Location = new Point(14, 276);
            dgvResultado.Margin = new Padding(3, 4, 3, 4);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowHeadersWidth = 51;
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(1058, 171);
            dgvResultado.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.Width = 125;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.Width = 125;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(985, 176);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(87, 39);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(985, 49);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(87, 39);
            btnClean.TabIndex = 3;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 45);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 49);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(610, 232);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Controller";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(99, 96);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(191, 27);
            txtUsuario.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 99);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 10;
            label4.Text = "Username";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(401, 96);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(172, 27);
            txtCodigo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 99);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 8;
            label3.Text = "Codigo";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(401, 45);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(172, 27);
            txtPassword.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 45);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 27);
            txtNombre.TabIndex = 6;
            // 
            // btmAgregar
            // 
            btmAgregar.Location = new Point(882, 49);
            btmAgregar.Margin = new Padding(3, 4, 3, 4);
            btmAgregar.Name = "btmAgregar";
            btmAgregar.Size = new Size(87, 39);
            btmAgregar.TabIndex = 7;
            btmAgregar.Text = "Agregar";
            btmAgregar.UseVisualStyleBackColor = true;
            btmAgregar.Click += btmAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 143);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 140);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 27);
            txtEmail.TabIndex = 13;
            // 
            // frmControllerUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 463);
            Controls.Add(btmAgregar);
            Controls.Add(groupBox1);
            Controls.Add(dgvResultado);
            Controls.Add(btnClean);
            Controls.Add(btnModificar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmControllerUser";
            Text = "ControllerUser";
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResultado;
        private Button btnModificar;
        private Button btnClean;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label3;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Codigo;
        private TextBox txtUsuario;
        private Label label4;
        private Button btmAgregar;
        private TextBox txtEmail;
        private Label label5;
    }
}