namespace pryPereiroGUI
{
    public partial class frmControleGUI : Form
    {
        public frmControleGUI()
        {
            InitializeComponent();
        }

        private void btnBotonera_Click(object sender, EventArgs e)
        {
            this.Hide(); // oculta este formualrio
            frmBotonera f = new frmBotonera(); // crea el frmInicio
            
            f.ShowDialog(); // visualiza y ejecuta el frmInicio
            this.Show(); // visualiza nuevamente este formulario
        }
    }
}
