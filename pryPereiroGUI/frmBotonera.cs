using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPereiroGUI
{
    public partial class frmBotonera : Form
    {
        public frmBotonera()
        {
            InitializeComponent();
        }
        string[] vecNombre = new string[3];
        int i = 0;
        private void frmBotonera_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "Paula";
            vecNombre[1] = "Jose";
            vecNombre[2] = "Nico";

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            lblNombre.Text = vecNombre[i];

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                lblNombre.Text = vecNombre[i];
            
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            
            
                lblNombre.Text = vecNombre[i];
            
        }
    }
}
