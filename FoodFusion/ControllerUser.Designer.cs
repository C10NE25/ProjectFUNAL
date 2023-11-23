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
            dataGridView1 = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnClean = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtID = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(534, 128);
            dataGridView1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(209, 132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(76, 29);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(52, 132);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(76, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(405, 132);
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
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClean);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 174);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Controller";
            // 
            // txtID
            // 
            txtID.Location = new Point(68, 79);
            txtID.Name = "txtID";
            txtID.Size = new Size(168, 23);
            txtID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 82);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 8;
            label3.Text = "ID";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(351, 34);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(151, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(68, 34);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(168, 23);
            txtUser.TabIndex = 6;
            // 
            // frmControllerUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 347);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "frmControllerUser";
            Text = "ControllerUser";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnClean;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private TextBox txtUser;
        private TextBox txtID;
        private Label label3;
    }
}