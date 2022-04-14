using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatizacion
{
    public partial class formVersVisual : Form
    {
        public formVersVisual()
        {
            InitializeComponent();
        }

        private void btnVisual2013_Click(object sender, EventArgs e)
        {
            Form formulario = new formAutomatizacion();
            formulario.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
