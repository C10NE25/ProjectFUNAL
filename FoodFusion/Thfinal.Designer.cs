namespace FoodFusion
{
    partial class Thfinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thfinal));
            pictureBox1 = new PictureBox();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(562, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ForeColor = Color.Moccasin;
            btnMinimizar.Image = Properties.Resources.Boton_Minimizar;
            btnMinimizar.Location = new Point(733, 2);
            btnMinimizar.Margin = new Padding(3, 4, 3, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(26, 31);
            btnMinimizar.TabIndex = 15;
            btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnMaximizar
            // 
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ForeColor = Color.Moccasin;
            btnMaximizar.Image = Properties.Resources.Boton_Expandir;
            btnMaximizar.Location = new Point(765, 2);
            btnMaximizar.Margin = new Padding(3, 4, 3, 4);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(26, 31);
            btnMaximizar.TabIndex = 16;
            btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.Moccasin;
            btnCerrar.Image = Properties.Resources.Boton_Cerrar;
            btnCerrar.Location = new Point(797, 2);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 31);
            btnCerrar.TabIndex = 17;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Thfinal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(829, 446);
            Controls.Add(btnCerrar);
            Controls.Add(btnMaximizar);
            Controls.Add(btnMinimizar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Thfinal";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnCerrar;
    }
}