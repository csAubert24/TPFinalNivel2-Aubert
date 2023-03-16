using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class HomeApp : Form
    {
        public HomeApp()
        {
            InitializeComponent();
        }

        private void btnAbrirArticulos_Click(object sender, EventArgs e)
        {
            frmCatalogo home = new frmCatalogo();
            home.ShowDialog();
        }

        private void cargarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
