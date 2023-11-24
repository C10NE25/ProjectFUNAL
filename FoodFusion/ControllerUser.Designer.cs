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
            txtEmail = new TextBox();
            label5 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            txtNombre = new TextBox();
            btmAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Columns.AddRange(new DataGridViewColumn[] { Nombre, Password, Email, Username, Codigo });
            dgvResultado.Location = new Point(12, 207);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowHeadersWidth = 51;
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(677, 128);
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
            btnModificar.Location = new Point(582, 128);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(76, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(582, 78);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(76, 29);
            btnClean.TabIndex = 3;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 37);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 174);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Controller";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(87, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 107);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(87, 76);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(168, 23);
            txtUsuario.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 74);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "Username";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(351, 72);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(151, 23);
            txtCodigo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 74);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 8;
            label3.Text = "Codigo";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(351, 34);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(87, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 23);
            txtNombre.TabIndex = 6;
            // 
            // btmAgregar
            // 
            btmAgregar.Location = new Point(582, 32);
            btmAgregar.Name = "btmAgregar";
            btmAgregar.Size = new Size(76, 29);
            btmAgregar.TabIndex = 7;
            btmAgregar.Text = "Agregar";
            btmAgregar.UseVisualStyleBackColor = true;
            btmAgregar.Click += btmAgregar_Click;
            // 
            // frmControllerUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 347);
            Controls.Add(btmAgregar);
            Controls.Add(groupBox1);
            Controls.Add(dgvResultado);
            Controls.Add(btnClean);
            Controls.Add(btnModificar);
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