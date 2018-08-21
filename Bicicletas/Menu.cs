using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicicletas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void consultarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAlumnos ca = new ConsultarAlumnos();
            ca.MdiParent = this;
            ca.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void consultarBicicletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarBicicleta cb = new ConsultarBicicleta();
            cb.MdiParent = this;
            cb.Show();
        }
    }
}
