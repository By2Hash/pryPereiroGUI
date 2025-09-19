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
            frmBotonera f = new frmBotonera(); // crea el frmInicio

            f.Show(); // visualiza y ejecuta el frmInicio

            for (int indice = 0; indice < f.vecNombre.Length;)
            {
                lsbNombres.Items.Add(f.vecNombre[indice]);
                indice++;
            }

            this.Show(); // visualiza nuevamente este formulario



        }

        private void lsbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
