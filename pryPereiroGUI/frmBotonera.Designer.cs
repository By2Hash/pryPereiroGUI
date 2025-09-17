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
            btnAtras = new Button();
            btnSubir = new Button();
            lblNombre = new Label();
            btnUltimo = new Button();
            btnPrimero = new Button();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.Enabled = false;
            btnAtras.Image = Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123237;
            btnAtras.Location = new Point(180, 182);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(49, 32);
            btnAtras.TabIndex = 0;
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += button1_Click;
            // 
            // btnSubir
            // 
            btnSubir.Image = Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123236__1_;
            btnSubir.Location = new Point(249, 182);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(49, 32);
            btnSubir.TabIndex = 1;
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 9.7F);
            lblNombre.Location = new Point(180, 139);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(118, 40);
            lblNombre.TabIndex = 2;
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            lblNombre.Click += lblNombre_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(304, 182);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(64, 32);
            btnUltimo.TabIndex = 3;
            btnUltimo.Text = "Ultimo";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(110, 182);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(64, 32);
            btnPrimero.TabIndex = 4;
            btnPrimero.Text = "Primero";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += button2_Click;
            // 
            // frmBotonera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnPrimero);
            Controls.Add(btnUltimo);
            Controls.Add(lblNombre);
            Controls.Add(btnSubir);
            Controls.Add(btnAtras);
            Name = "frmBotonera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBotonera";
            Load += frmBotonera_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private Button btnSubir;
        private Label lblNombre;
        private Button btnUltimo;
        private Button btnPrimero;
    }
}