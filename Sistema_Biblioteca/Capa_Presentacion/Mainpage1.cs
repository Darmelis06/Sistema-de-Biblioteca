using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Mainpage1 : Form
    {
        public Mainpage1()
        {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            subMenu.Visible = true;
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            subMenu.Visible = false;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            subMenu.Visible = false;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
