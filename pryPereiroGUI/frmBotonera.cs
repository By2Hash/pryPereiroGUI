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
        int indice = 0;

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "Paula";
            vecNombre[1] = "Jose";
            vecNombre[2] = "Nico";

            lblNombre.Text = vecNombre[0];
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            lblNombre.Text = vecNombre[indice];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            indice--;


            if (indice < vecNombre.Length)
            {
                lblNombre.Text = vecNombre[indice];

                if (indice == 0)
                {
                    btnSubir.Enabled = true;

                    if (indice < vecNombre.Length)
                    {
                        btnAtras.Enabled = false;
                    }
                }


            }




        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

            indice++;

            if (indice < vecNombre.Length)
            {
                lblNombre.Text = vecNombre[indice];


                if (vecNombre.Length >= indice)
                {

                    btnAtras.Enabled = true;

                    if (indice >= 2)
                    {
                        btnSubir.Enabled = false;
                    }

                }










            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                
            lblNombre.Text = vecNombre[0];

            
            
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            lblNombre.Text = vecNombre[2];
        }
    }
}
