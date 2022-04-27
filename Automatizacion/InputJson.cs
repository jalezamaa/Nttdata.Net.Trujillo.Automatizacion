using System;
using System.Linq;
using System.Windows.Forms;

namespace Automatizacion
{
    public partial class InputJson : Form
    {
        public InputJson()
        {
            InitializeComponent();
        }

        private void btnAgregarVariables_Click(object sender, EventArgs e)
        {
            if (txtJsonVariables.Text == string.Empty)
            {
                MessageBox.Show("Debe escribir un json valido.");
            }

            try
            {
                var listasDeVariablesProcesadas = BLGeneradorCodigo.ProcesarJson(txtJsonVariables.Text);

                switch (formAutomatizacion.tipoClaseProcesoMasivo)
                {
                    case 1: // request
                        formAutomatizacion.listVariablesRequest =
                            listasDeVariablesProcesadas.Where(x => x.nivelVariable == 2).ToList();

                        formAutomatizacion.listDeVariablesTipoListaRequest =
                            listasDeVariablesProcesadas.Where(x => x.nivelVariable == 3).ToList();
                        break;

                    case 2: // response
                        formAutomatizacion.listVariablesResponse =
                            listasDeVariablesProcesadas.Where(x => x.nivelVariable == 2).ToList();

                        formAutomatizacion.listListaDeVariablesTipoListaResponse =
                            listasDeVariablesProcesadas.Where(x => x.nivelVariable == 3).ToList();
                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe escribir un json valido.");
            }
        }
    }
}
