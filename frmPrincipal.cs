using GestionCobroEstacionamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCobroEstacionamiento
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(nupHorasEstancia.Text.Trim());


            string tipo = comboBox1.SelectedItem.ToString();

            switch (horas)
            {
                case 0:
                    //general                   
                    break;
                case 1:
                    //adulto mayor                   
                    break;
                case 2:
                    //estudiante alexa                    
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
