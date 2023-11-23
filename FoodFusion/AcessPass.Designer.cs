namespace FoodFusion
{
    partial class AcessPass
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
            lblQuestion = new Label();
            button1 = new Button();
            btnOpcionB = new Button();
            btnOpcionC = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuestion.Location = new Point(30, 39);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(292, 32);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Elija la palabra bien escrita";
            // 
            // button1
            // 
            button1.Location = new Point(12, 117);
            button1.Name = "button1";
            button1.Size = new Size(92, 41);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnOpcionB
            // 
            btnOpcionB.Location = new Point(125, 117);
            btnOpcionB.Name = "btnOpcionB";
            btnOpcionB.Size = new Size(92, 41);
            btnOpcionB.TabIndex = 2;
            btnOpcionB.Text = "button2";
            btnOpcionB.UseVisualStyleBackColor = true;
            // 
            // btnOpcionC
            // 
            btnOpcionC.Location = new Point(242, 117);
            btnOpcionC.Name = "btnOpcionC";
            btnOpcionC.Size = new Size(92, 41);
            btnOpcionC.TabIndex = 3;
            btnOpcionC.Text = "button3";
            btnOpcionC.UseVisualStyleBackColor = true;
            // 
            // AcessPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 192);
            Controls.Add(btnOpcionC);
            Controls.Add(btnOpcionB);
            Controls.Add(button1);
            Controls.Add(lblQuestion);
            Name = "AcessPass";
            Text = "AcessPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private Button button1;
        private Button btnOpcionB;
        private Button btnOpcionC;
    }
}