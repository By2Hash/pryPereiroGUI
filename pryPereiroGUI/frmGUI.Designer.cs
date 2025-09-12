namespace pryPereiroGUI
{
    partial class frmControleGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBotonera = new Button();
            SuspendLayout();
            // 
            // btnBotonera
            // 
            btnBotonera.Location = new Point(12, 12);
            btnBotonera.Name = "btnBotonera";
            btnBotonera.Size = new Size(109, 23);
            btnBotonera.TabIndex = 0;
            btnBotonera.Text = "Abrir Botonera";
            btnBotonera.UseVisualStyleBackColor = true;
            // 
            // frmControleGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(btnBotonera);
            Name = "frmControleGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controles de Interfaz Grafica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBotonera;
    }
}
