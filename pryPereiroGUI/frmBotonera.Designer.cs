namespace pryPereiroGUI
{
    partial class frmBotonera
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
            button1 = new Button();
            button2 = new Button();
            lblNombre = new Label();
            btnAgregar = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            button1.Location = new Point(180, 182);
            button1.Name = "button1";
            button1.Size = new Size(49, 32);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123236__1_;
            button2.Location = new Point(249, 182);
            button2.Name = "button2";
            button2.Size = new Size(49, 32);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.7F);
            lblNombre.Location = new Point(180, 104);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(118, 17);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Ingrese su nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(180, 153);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "button3";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 4;
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(textBox1);
            Controls.Add(btnAgregar);
            Controls.Add(lblNombre);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmBotonera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBotonera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblNombre;
        private Button btnAgregar;
        private TextBox textBox1;
    }
}