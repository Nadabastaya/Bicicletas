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
    public partial class ConsultarAlumnos : Form
    {
        public ConsultarAlumnos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
