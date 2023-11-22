namespace FoodFusion
{
    partial class FormsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsAdmin));
            PanelTBadmin = new Panel();
            btnCerrarAdmin = new Button();
            btnExpandirAdmin = new Button();
            btnMinimizarAdmin = new Button();
            label1 = new Label();
            lblTitleAdmin = new Label();
            dataGridView1 = new DataGridView();
            PanelTBadmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PanelTBadmin
            // 
            PanelTBadmin.BackColor = Color.FromArgb(255, 224, 192);
            PanelTBadmin.Controls.Add(btnCerrarAdmin);
            PanelTBadmin.Controls.Add(btnExpandirAdmin);
            PanelTBadmin.Controls.Add(btnMinimizarAdmin);
            PanelTBadmin.Controls.Add(label1);
            PanelTBadmin.Controls.Add(lblTitleAdmin);
            PanelTBadmin.Dock = DockStyle.Top;
            PanelTBadmin.Location = new Point(0, 0);
            PanelTBadmin.Name = "PanelTBadmin";
            PanelTBadmin.Size = new Size(954, 41);
            PanelTBadmin.TabIndex = 11;
            PanelTBadmin.MouseMove += PanelTBadmin_MouseMove;
            // 
            // btnCerrarAdmin
            // 
            btnCerrarAdmin.FlatStyle = FlatStyle.Flat;
            btnCerrarAdmin.ForeColor = Color.FromArgb(255, 224, 192);
            btnCerrarAdmin.Image = Properties.Resources.Boton_Cerrar;
            btnCerrarAdmin.Location = new Point(916, 7);
            btnCerrarAdmin.Name = "btnCerrarAdmin";
            btnCerrarAdmin.Size = new Size(29, 27);
            btnCerrarAdmin.TabIndex = 4;
            btnCerrarAdmin.UseVisualStyleBackColor = true;
            btnCerrarAdmin.Click += btnCerrarAdmin_Click;
            // 
            // btnExpandirAdmin
            // 
            btnExpandirAdmin.FlatStyle = FlatStyle.Flat;
            btnExpandirAdmin.ForeColor = Color.FromArgb(255, 224, 192);
            btnExpandirAdmin.Image = Properties.Resources.Boton_Expandir;
            btnExpandirAdmin.Location = new Point(881, 7);
            btnExpandirAdmin.Name = "btnExpandirAdmin";
            btnExpandirAdmin.Size = new Size(29, 27);
            btnExpandirAdmin.TabIndex = 3;
            btnExpandirAdmin.UseVisualStyleBackColor = true;
            // 
            // btnMinimizarAdmin
            // 
            btnMinimizarAdmin.FlatStyle = FlatStyle.Flat;
            btnMinimizarAdmin.ForeColor = Color.FromArgb(255, 224, 192);
            btnMinimizarAdmin.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizarAdmin.Location = new Point(846, 7);
            btnMinimizarAdmin.Name = "btnMinimizarAdmin";
            btnMinimizarAdmin.Size = new Size(29, 27);
            btnMinimizarAdmin.TabIndex = 2;
            btnMinimizarAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(418, 5);
            label1.Name = "label1";
            label1.Size = new Size(92, 32);
            label1.TabIndex = 1;
            label1.Text = "FUSION";
            // 
            // lblTitleAdmin
            // 
            lblTitleAdmin.AutoSize = true;
            lblTitleAdmin.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleAdmin.Location = new Point(352, 5);
            lblTitleAdmin.Name = "lblTitleAdmin";
            lblTitleAdmin.Size = new Size(69, 32);
            lblTitleAdmin.TabIndex = 0;
            lblTitleAdmin.Text = "FOOD";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(902, 213);
            dataGridView1.TabIndex = 19;
            // 
            // FormsAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 539);
            Controls.Add(dataGridView1);
            Controls.Add(PanelTBadmin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormsAdmin";
            Text = "FormsTables";
            PanelTBadmin.ResumeLayout(false);
            PanelTBadmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelTBadmin;
        private Label label1;
        private Label lblTitleAdmin;
        private Button btnCerrarAdmin;
        private Button btnExpandirAdmin;
        private Button btnMinimizarAdmin;
        private DataGridView dataGridView1;
    }
}