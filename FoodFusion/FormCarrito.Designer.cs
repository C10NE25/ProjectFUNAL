namespace FoodFusion
{
    partial class FormCarrito
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
            btnCerrar = new Button();
            btnMaximizar = new Button();
            btnMinimizar = new Button();
            lblMenuC = new Label();
            btnComprar = new Button();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(64, 64, 64);
            btnCerrar.Image = Properties.Resources.Boton_Cerrar;
            btnCerrar.Location = new Point(675, 13);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 31);
            btnCerrar.TabIndex = 1;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.BackColor = Color.Transparent;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = Color.FromArgb(64, 64, 64);
            btnMaximizar.Image = Properties.Resources.Boton_Expandir;
            btnMaximizar.Location = new Point(643, 13);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(26, 31);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.FromArgb(64, 64, 64);
            btnMinimizar.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizar.Location = new Point(611, 13);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 31);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // lblMenuC
            // 
            lblMenuC.AutoSize = true;
            lblMenuC.BackColor = Color.Transparent;
            lblMenuC.Font = new Font("MV Boli", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuC.ForeColor = SystemColors.ButtonHighlight;
            lblMenuC.Location = new Point(52, 60);
            lblMenuC.Name = "lblMenuC";
            lblMenuC.Size = new Size(597, 62);
            lblMenuC.TabIndex = 24;
            lblMenuC.Text = "CONFIRME SU COMPRA";
            // 
            // btnComprar
            // 
            btnComprar.BackColor = SystemColors.ButtonHighlight;
            btnComprar.Font = new Font("Ravie", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.Black;
            btnComprar.Location = new Point(541, 532);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(160, 37);
            btnComprar.TabIndex = 34;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // FormCarrito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoMENU3;
            ClientSize = new Size(713, 591);
            Controls.Add(btnComprar);
            Controls.Add(lblMenuC);
            Controls.Add(btnMinimizar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarrito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnMaximizar;
        private Button btnMinimizar;
        private Label lblMenuC;
        private Button btnComprar;
    }
}