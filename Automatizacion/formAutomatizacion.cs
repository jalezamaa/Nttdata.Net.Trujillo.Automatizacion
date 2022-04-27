using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Automatizacion
{
    public partial class formAutomatizacion : Form
    {
        public static List<Variables> listVariablesRequest = new List<Variables>();
        public static List<Variables> listVariablesResponse = new List<Variables>();
        public static List<Variables> listDeVariablesTipoListaRequest = new List<Variables>();
        public static List<Variables> listListaDeVariablesTipoListaResponse = new List<Variables>();
        public static int tipoClaseProcesoMasivo;
        string rutaArchivo = string.Empty;
        FolderBrowserDialog dlg = new FolderBrowserDialog();

        public formAutomatizacion()
        {
            InitializeComponent();
            tslQuitarRequest.Enabled = false;
            tslQuitarResponse.Enabled = false;
            txtNombreClaseRequest.Focus();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tslAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarNombreRequest() == false)
            {
                return;
            }

            if (ValidarTipoVariableRequest() == false)
            {
                return;
            }
            //ValidarNombres(txtNombreVariableRequest.Text) == false ? return; : return);
            Variables listadoVariablesRequest = new Variables();
            listadoVariablesRequest.nombreVariable = txtNombreVariableRequest.Text;
            listadoVariablesRequest.tipoVariable = cmbTipoVariableRequest.SelectedItem.ToString();
            listVariablesRequest.Add(listadoVariablesRequest);
            dgvVariablesRequest.DataSource = new List<Variables>();
            dgvVariablesRequest.DataSource = listVariablesRequest;
            ColocarBotonEliminarEnGrid(dgvVariablesRequest);
            //BindingSource source = new BindingSource();
            //source.DataSource = listVariablesRequest;
            //dgvVariablesRequest.DataSource = source;
            //dgvVariablesRequest.ResetBindings();

            if (txtNombreVariableRequest.Text != String.Empty)
            {
                if (cmbTipoVariableRequest.SelectedIndex == 2 || cmbTipoVariableRequest.SelectedIndex == 3)
                {
                    gbVariableListaRequest.Visible = true;
                }

            }
            /*
            if (cmbTipoVariableRequest.SelectedIndex == 2 && txtNombreVariableRequest.Text != String.Empty)
            {
                gbVariableListaRequest.Visible = true;
            }
            */
            LimpiarControlesRequest();
            tslQuitarRequest.Enabled = true;
        }
        private void tslAgregarResponse_Click(object sender, EventArgs e)
        {
            if (ValidarNombreResponse() == false)
            {
                return;
            }
            if (ValidarTipoVariableResponse() == false)
            {
                return;
            }
            Variables listadoVariablesResponse = new Variables();
            listadoVariablesResponse.nombreVariable = txtNombreVariableResponse.Text;
            listadoVariablesResponse.tipoVariable = cbmTipoVariableResponse.SelectedItem.ToString();
            listVariablesResponse.Add(listadoVariablesResponse);
            dgvVariablesResponse.DataSource = new List<Variables>();
            dgvVariablesResponse.DataSource = listVariablesResponse;
            ColocarBotonEliminarEnGrid(dgvVariablesResponse);

            if (cbmTipoVariableResponse.SelectedIndex == 2 && txtNombreVariableResponse.Text != String.Empty)
            {
                gbVariableListaResponse.Visible = true;
            }
            LimpiarControlesResponse();
            tslQuitarResponse.Enabled = true;
        }

        #region Validaciones
        private bool ValidarNombreClaseRequest()
        {
            if (string.IsNullOrEmpty(txtNombreClaseRequest.Text))
            {
                erpError.SetError(txtNombreClaseRequest, "Debe Ingresar nombre de la clase Request");
                return false;
            }
            else
            {
                erpError.SetError(txtNombreClaseRequest, "");
                return true;
            }
        }
        private bool ValidarNombreClaseResponse()
        {
            if (string.IsNullOrEmpty(txtNombreClaseResponse.Text))
            {
                erpError.SetError(txtNombreClaseResponse, "Debe Ingresar nombre de la clase Response");
                return false;
            }
            else
            {
                erpError.SetError(txtNombreClaseResponse, "");
                return true;
            }
        }
        private bool ValidarNombreRequest()
        {
            if (string.IsNullOrEmpty(txtNombreVariableRequest.Text))
            {
                erpError.SetError(txtNombreVariableRequest, "Debe Ingresar nombre de las Variables Request");
                return false;
            }
            else
            {
                erpError.SetError(txtNombreVariableRequest, "");
                return true;
            }
        }
        private bool ValidarNombreVariableListaRequest()
        {
            if (string.IsNullOrEmpty(txtNombreVariableListaRequest.Text))
            {
                erpError.SetError(txtNombreVariableListaRequest, "Debe Ingresar nombre de las Variables de lista Request");
                return false;
            }
            else
            {
                erpError.SetError(txtNombreVariableListaRequest, "");
                return true;
            }
        }
        private bool ValidarNombreVariableListaResponse()
        {
            if (string.IsNullOrEmpty(txtNombreVariablesListaResponse.Text))
            {
                erpError.SetError(txtNombreVariablesListaResponse, "Debe Ingresar nombre de las Variables de lista Response");
                return false;
            }
            else
            {
                erpError.SetError(txtNombreVariablesListaResponse, "");
                return true;
            }
        }
        private bool ValidarNombreResponse()
        {
            if (string.IsNullOrEmpty(txtNombreVariableResponse.Text))
            {
                erpError.SetError(txtNombreVariableResponse, "Debe Ingresar nombre de las Variables Response");
                return false;
            }
            else
            {
                erpError.SetError(txtNombreVariableResponse, "");
                return true;
            }
        }
        private bool ValidarTipoVariableRequest()
        {
            if (string.IsNullOrEmpty(cmbTipoVariableRequest.Text))
            {
                erpError.SetError(cmbTipoVariableRequest, "Debe Seleccionar un tipo de Variable Request");
                return false;
            }
            else
            {
                erpError.SetError(cmbTipoVariableRequest, "");
                return true;
            }
        }
        private bool ValidarTipoVariableResponse()
        {
            if (string.IsNullOrEmpty(cbmTipoVariableResponse.Text))
            {
                erpError.SetError(cbmTipoVariableResponse, "Debe Seleccionar un tipo de Variable Response");
                return false;
            }
            else
            {
                erpError.SetError(cbmTipoVariableResponse, "");
                return true;
            }
        }
        private bool ValidarTipoVariableListRequest()
        {
            if (string.IsNullOrEmpty(cmbTipoVariableListaRequest.Text))
            {
                erpError.SetError(cbmTipoVariableResponse, "Debe Seleccionar un tipo de Variable para la lista Request");
                return false;
            }
            else
            {
                erpError.SetError(cbmTipoVariableResponse, "");
                return true;
            }
        }
        private bool ValidarTipoVariableListResponse()
        {
            if (string.IsNullOrEmpty(cmbTipoVariableListaResponse.Text))
            {
                erpError.SetError(cmbTipoVariableListaResponse, "Debe Seleccionar un tipo de Variable para la lista Response");
                return false;
            }
            else
            {
                erpError.SetError(cmbTipoVariableListaResponse, "");
                return true;
            }
        }
        private bool ValidarNombreMetodo()
        {
            if (string.IsNullOrEmpty(txtNombreMetodo.Text))
            {
                erpError.SetError(txtNombreMetodo, "Debe Ingresar nombre del Metodo para consumo");
                return false;
            }
            else
            {
                erpError.SetError(txtNombreMetodo, "");
                return true;
            }
        }
        private bool ValidarRutaDeArchivos()
        {
            if (string.IsNullOrEmpty(txtRutaArchivo.Text))
            {
                erpError.SetError(txtRutaArchivo, "Debe Ingresar la Ruta del archivo");
                return false;
            }
            else
            {
                erpError.SetError(txtRutaArchivo, "");
                return true;
            }
        }
        #endregion
        //private bool ValidarNombres(string nombre)
        //{
        //    if (string.IsNullOrEmpty(nombre))
        //    {
        //        erpError.SetError(txtNombreVariableRequest, "Debe Ingresar nombre de Variable");
        //        return false;
        //    }
        //    else
        //    {
        //        erpError.SetError(txtNombreVariableRequest, "");
        //        return true;
        //    }
        //}
        private void LimpiarControlesRequest()
        {
            txtNombreVariableRequest.Clear();
            cmbTipoVariableRequest.SelectedIndex = 0;

        }
        private void LimpiarControlesResponse()
        {
            txtNombreVariableResponse.Clear();
            cbmTipoVariableResponse.SelectedIndex = 0;

        }
        private void tslQuitar_Click(object sender, EventArgs e)
        {
            Int32 indexFilaEliminada = dgvVariablesRequest.CurrentRow.Index;
            listVariablesRequest.RemoveAt(indexFilaEliminada);
            dgvVariablesRequest.DataSource = null;
            dgvVariablesRequest.DataSource = listVariablesRequest;
            LimpiarControlesRequest();
            txtNombreVariableRequest.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = dlg.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                rutaArchivo = dlg.SelectedPath;
            }
            txtRutaArchivo.Text = rutaArchivo;
        }

        private void tslQuitarResponse_Click(object sender, EventArgs e)
        {
            Int32 indexFilaEliminada = dgvVariablesResponse.CurrentRow.Index;
            listVariablesResponse.RemoveAt(indexFilaEliminada);
            dgvVariablesResponse.DataSource = null;
            dgvVariablesResponse.DataSource = listVariablesResponse;
            LimpiarControlesResponse();
            txtNombreVariableResponse.Focus();
        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            string codigoRequest = string.Empty, codigoRequestLista = string.Empty, codigoResponse = string.Empty, codigoResponseLista = string.Empty;
            string codigoClaseRequest = string.Empty, codigoMesageRequest = string.Empty, codigoBodyRequest = string.Empty, codigoListaRequest = string.Empty;
            string codigoClaseResponse = string.Empty, codigoMesageResponse = string.Empty, codigoBodyResponse = string.Empty, codigoBeClaseResponse = string.Empty, codigoListaResponse = string.Empty, codigoBEresponseStatus = string.Empty, codigoBEresponseData = string.Empty;
            string codigoMetodoConsumo = string.Empty;
            string nombreClaseRequestBE = string.Empty, nombreClaseListaRequestBE = string.Empty;
            string nombreDataResponsetBE = string.Empty; 
            try
            {
                if (ValidarNombreClaseRequest() == false)
                {
                    return;
                }
                if (ValidarNombreClaseResponse() == false)
                {
                    return;
                }
                if (ValidarNombreMetodo() == false)
                {
                    return;
                }
                if (ValidarRutaDeArchivos() == false)
                {
                    return;
                }
                if (dgvVariablesRequest.RowCount == 0 || dgvVariablesResponse.RowCount == 0)
                {
                    throw new Exception("Ingrese datos en las listas");
                }
                #region codigoRequest

                /*
                codigoRequest += "using System;" + Environment.NewLine;
                codigoRequest += "using System.Collections.Generic;" + Environment.NewLine;
                codigoRequest += "using System.Linq;" + Environment.NewLine;
                codigoRequest += "using System.Web;" + Environment.NewLine + Environment.NewLine;

                codigoRequest += "namespace Claro.SIACU.Web.Application.BonusFullClaro.Areas.Bonus.Models.BonusActivation" + Environment.NewLine;
                codigoRequest += "{" + Environment.NewLine;
                codigoRequest += "  public class " + txtNombreClaseRequest.Text + Environment.NewLine;
                codigoRequest += "  {" + Environment.NewLine;

                foreach (DataGridViewRow row in dgvVariablesRequest.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "List")
                    {
                        codigoRequest += "      public List<" + row.Cells[0].Value.ToString() + ">  lista" + row.Cells[0].Value.ToString() + " { get; set; } " + Environment.NewLine;
                    }
                    else
                    {
                        codigoRequest += "      public " + row.Cells[1].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; } " + Environment.NewLine;
                    }

                }
                codigoRequest += "  }" + Environment.NewLine;
                codigoRequest += "}" + Environment.NewLine;
                CreacionDeArchivos(txtNombreClaseRequest.Text, codigoRequest);

                if (dgvVariablesListaRequest.RowCount > 0)
                {
                    string nombreListaRequest = string.Empty;
                    codigoRequestLista += Environment.NewLine;
                    codigoRequestLista += Environment.NewLine;
                    codigoRequestLista += Environment.NewLine;
                    codigoRequestLista += "// Creacion de la Clase para la variable ListRequest" + Environment.NewLine;

                    codigoRequestLista += "using System;" + Environment.NewLine;
                    codigoRequestLista += "using System.Collections.Generic;" + Environment.NewLine;
                    codigoRequestLista += "using System.Linq;" + Environment.NewLine;
                    codigoRequestLista += "using System.Web;" + Environment.NewLine + Environment.NewLine;

                    codigoRequestLista += "namespace Claro.SIACU.Web.Application.BonusFullClaro.Areas.Bonus.Models.BonusActivation" + Environment.NewLine;
                    codigoRequestLista += "{" + Environment.NewLine;
                    foreach (DataGridViewRow row in dgvVariablesRequest.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == "List")
                        {
                            nombreListaRequest = row.Cells[0].Value.ToString();
                            codigoRequestLista += "  public class " + row.Cells[0].Value.ToString()  + Environment.NewLine;
                        }
                    }
                    codigoRequestLista += "  {" + Environment.NewLine;

                    foreach (DataGridViewRow row in dgvVariablesListaRequest.Rows)
                    {
                        codigoRequestLista += "      public " + row.Cells[1].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; } " + Environment.NewLine;
                    }
                    codigoRequestLista += "  }" + Environment.NewLine;
                    codigoRequestLista += "}" + Environment.NewLine;
                    CreacionDeArchivos(nombreListaRequest, codigoRequestLista);
                }
                */
                #endregion
                #region codigoResponse
                /*
                codigoResponse += "using System;" + Environment.NewLine;
                codigoResponse += "using System.Collections.Generic;" + Environment.NewLine;
                codigoResponse += "using System.Linq;" + Environment.NewLine;
                codigoResponse += "using System.Web;" + Environment.NewLine + Environment.NewLine;

                codigoResponse += "namespace Claro.SIACU.Web.Application.BonusFullClaro.Areas.Bonus.Models.BonusActivation" + Environment.NewLine;
                codigoResponse += "{" + Environment.NewLine;
                codigoResponse += "  public class " + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoResponse += "  {" + Environment.NewLine;

                foreach (DataGridViewRow row in dgvVariablesResponse.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "List")
                    {
                        codigoResponse += "      public List<" + row.Cells[1].Value.ToString() + "> " + row.Cells[1].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; } " + Environment.NewLine;
                    }
                    else
                    {
                        codigoResponse += "      public " + row.Cells[1].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; } " + Environment.NewLine;
                    }
                }
                codigoResponse += "  }" + Environment.NewLine;
                codigoResponse += "}" + Environment.NewLine;
                CreacionDeArchivos(txtNombreClaseResponse.Text, codigoResponse);
                if (dgvVariablesListaResponse.RowCount > 0)
                {
                    string nombreListaReponse = string.Empty;
                    codigoResponseLista += Environment.NewLine;
                    codigoResponseLista += Environment.NewLine;
                    codigoResponseLista += Environment.NewLine;
                    codigoResponseLista += "// Creacion de la Clase para la variable ListRequest" + Environment.NewLine;

                    codigoResponseLista += "using System;" + Environment.NewLine;
                    codigoResponseLista += "using System.Collections.Generic;" + Environment.NewLine;
                    codigoResponseLista += "using System.Linq;" + Environment.NewLine;
                    codigoResponseLista += "using System.Web;" + Environment.NewLine + Environment.NewLine;

                    codigoResponseLista += "namespace Claro.SIACU.Web.Application.BonusFullClaro.Areas.Bonus.Models.BonusActivation" + Environment.NewLine;
                    codigoResponseLista += "{" + Environment.NewLine;
                    foreach (DataGridViewRow row in dgvVariablesResponse.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == "List")
                        {
                            nombreListaReponse = row.Cells[0].Value.ToString();
                            codigoResponseLista += "  public class " + row.Cells[0].Value.ToString() + Environment.NewLine;
                        }
                    }
                    codigoResponseLista += "  {" + Environment.NewLine;

                    foreach (DataGridViewRow row in dgvVariablesListaResponse.Rows)
                    {
                        codigoResponseLista += "      public " + row.Cells[1].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; } " + Environment.NewLine;
                    }
                    codigoResponseLista += "  }" + Environment.NewLine;
                    codigoResponseLista += "}" + Environment.NewLine;
                    CreacionDeArchivos(nombreListaReponse, codigoResponseLista);
                }
                */
                #endregion
                #region codigoMetodoConsumo
                /*
                codigoMetodoConsumo += "public JsonResult " + txtNombreMetodo.Text + "(" + txtNombreClaseRequest.Text + " " + txtNombreClaseRequest.Text + ")" + Environment.NewLine;
                codigoMetodoConsumo += "{" + Environment.NewLine;
                codigoMetodoConsumo += "     Tools.Traces.Logging.Info("+txtNombreClaseRequest.Text+".IdSession, "+txtNombreClaseRequest.Text+".IdSession, \"INI: " + txtNombreMetodo.Text + "\");" + Environment.NewLine;
                codigoMetodoConsumo += "     BonusFullClaroMasivoWS.BonusFullClaroMasivoClient objService = new BonusFullClaroMasivoWS.BonusFullClaroMasivoClient();" + Environment.NewLine;
                codigoMetodoConsumo += "     BonusFullClaroMasivoWS.ObtenerLineasValidasResponse1 obj"+ txtNombreClaseResponse+" = null;" + Environment.NewLine;
                codigoMetodoConsumo += "     BonusFullClaroMasivoWS.AuditRequest auditRequest = null;" + Environment.NewLine;
                codigoMetodoConsumo += "     BonusFullClaroMasivoWS.ObtenerLineasValidasRequest request = new BonusFullClaroMasivoWS.ObtenerLineasValidasRequest();" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "     " + txtNombreClaseResponse.Text.ToUpper() + " " + txtNombreClaseResponse.Text.ToLower() + " = new " + txtNombreClaseResponse.Text.ToUpper() + "();" + Environment.NewLine;
                foreach (DataGridViewRow row in dgvVariablesResponse.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "List")
                    {
                        codigoMetodoConsumo += "     " + txtNombreClaseResponse.Text.ToLower() + "." + row.Cells[0].Value.ToString() + " = new List<" + txtNombreClaseResponse.Text.ToUpper() + ">();" + Environment.NewLine;
                    }
                }
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "     try" + Environment.NewLine;
                codigoMetodoConsumo += "     {" + Environment.NewLine;
                codigoMetodoConsumo += "         auditRequest = Common.CreateAuditRequest<BonusFullClaroMasivoWS.AuditRequest>("+txtNombreClaseRequest.Text+".IdSession);" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "         if (KEY.AppSettings(\"strFullClaroFlagTOBE\") == \"1\")" + Environment.NewLine;
                codigoMetodoConsumo += "         {" + Environment.NewLine;
                codigoMetodoConsumo += "             if (string.IsNullOrEmpty("+txtNombreClaseRequest.Text+".tipoServicio))" + Environment.NewLine;
                codigoMetodoConsumo += "             {" + Environment.NewLine;
                codigoMetodoConsumo += "                 "+txtNombreClaseRequest.Text+".tipoServicio = \"MOVIL\";" + Environment.NewLine;
                codigoMetodoConsumo += "             }" + Environment.NewLine;
                codigoMetodoConsumo += "             Tools.Traces.Logging.Info(getLineasClienteFC.IdSession, getLineasClienteFC.numeroDocumento, string.Format(\"{0} --> {1}\", \"GetLineasFullClaro - tipoServicio\", CheckStr(getLineasClienteFC.tipoServicio)));" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "             //Header de Request" + Environment.NewLine;
                codigoMetodoConsumo += "             request.audit = Common.CreateAuditRequest<BonusFullClaroMasivoWS.AuditRequest>("+txtNombreClaseRequest.Text +".IdSession);" + Environment.NewLine;
                codigoMetodoConsumo += "             request.AuditService = new Audit();" + Environment.NewLine;
                codigoMetodoConsumo += "             request.MessageRequest = new ObtenerLineasValidasMessageRequest();" + Environment.NewLine;
                codigoMetodoConsumo += "             request.MessageRequest.Header = new HeadersRequest();" + Environment.NewLine;
                //codigoMetodoConsumo += "             Tools.Traces.Logging.Info(getLineasClienteFC.IdSession, getLineasClienteFC.numeroDocumento, string.Format(\"{0} --> {1}\", \"GetLineasFullClaro - audit 1\", Newtonsoft.Json.JsonConvert.SerializeObject(request)));" + Environment.NewLine;
                
                codigoMetodoConsumo += "             request.MessageRequest.Header.HeaderRequest = getHeaderRequest(KEY.AppSettings(\"strOperationconsultalineasSiacu\"));" + Environment.NewLine;
                //codigoMetodoConsumo += "             Tools.Traces.Logging.Info(getLineasClienteFC.IdSession, getLineasClienteFC.numeroDocumento, string.Format(\"{0} --> {1}\", \"GetLineasFullClaro - audit 2\", Newtonsoft.Json.JsonConvert.SerializeObject(request)));" + Environment.NewLine;
                codigoMetodoConsumo += "             request.MessageRequest.Body = new ObtenerLineasValidasBodyRequest();" + Environment.NewLine;
                codigoMetodoConsumo += "             request.MessageRequest.Body.obtenerLineasValidasRequest = new ObtenerLineasValidasRequestDP" + Environment.NewLine;
                codigoMetodoConsumo += "             {" + Environment.NewLine;
                foreach (DataGridViewRow row in dgvVariablesRequest.Rows)
                {
                    codigoMetodoConsumo += "                " + row.Cells[0].Value.ToString() + " = " + txtNombreClaseRequest.Text +"." + row.Cells[0].Value.ToString() + Environment.NewLine;
                }
                codigoMetodoConsumo += "             };" + Environment.NewLine;
                //codigoMetodoConsumo += "             Tools.Traces.Logging.Info(getLineasClienteFC.IdSession, getLineasClienteFC.numeroDocumento, string.Format(\"{0} --> {1}\", \"GetLineasFullClaro - Obtener Lineas Moviles Tobe - Request\", Newtonsoft.Json.JsonConvert.SerializeObject(request)));" + Environment.NewLine;
                codigoMetodoConsumo += "             objResponseLineasFullClaro = objService.GetObtenerLineasFC(request, auditRequest);" + Environment.NewLine;
                codigoMetodoConsumo += "           }" + Environment.NewLine;

                codigoMetodoConsumo += "           if (obj"+ txtNombreClaseResponse+" != null)" + Environment.NewLine;
                codigoMetodoConsumo += "           {" + Environment.NewLine;
                codigoMetodoConsumo += "               if (obj"+ txtNombreClaseResponse+".MessageResponse.Body.obtenerLineasValidasResponse != null ) "+ Environment.NewLine;
                codigoMetodoConsumo += "               {" + Environment.NewLine;
                codigoMetodoConsumo += "                    if (obj"+ txtNombreClaseResponse+".MessageResponse.Body.obtenerLineasValidasResponse.responseData != null ) "+ Environment.NewLine;
                codigoMetodoConsumo += "                    {" + Environment.NewLine;
                codigoMetodoConsumo += "                            if (obj"+ txtNombreClaseResponse+".MessageResponse.Body.obtenerLineasValidasResponse.responseData.lineas != null ) "+ Environment.NewLine;
                codigoMetodoConsumo += "                            {" + Environment.NewLine;
                codigoMetodoConsumo += "                                    if (obj"+ txtNombreClaseResponse+".MessageResponse.Body.obtenerLineasValidasResponse.responseData.linea.Count > 0)"+ Environment.NewLine;
                codigoMetodoConsumo += "                                    {" + Environment.NewLine;
                //codigoMetodoConsumo += "                                    Tools.Traces.Logging.Info(getLineasClienteFC.IdSession, getLineasClienteFC.numeroDocumento, \"GetLineasFullClaro - Se encontraron Datos\");"+ Environment.NewLine;
                codigoMetodoConsumo += "                                       foreach( var item in objResponseLineasFullClaro.MessageResponse.Body.obtenerLineasValidasResponse.responseData."+ txtNombreVariablesListaResponse.Text +")" + Environment.NewLine;
                codigoMetodoConsumo += "                                       {" + Environment.NewLine;
                codigoMetodoConsumo += "                                        " + txtNombreClaseResponse.Text.ToUpper() + "  i = new " + txtNombreClaseResponse.Text.ToUpper() + "();" + Environment.NewLine;
                foreach (DataGridViewRow row in dgvVariablesListaResponse.Rows)
                {
                    codigoMetodoConsumo += "                                        i." + row.Cells[0].Value.ToString() + " = item. " + row.Cells[0].Value.ToString() + Environment.NewLine;
                }
                codigoMetodoConsumo += "                                        " + txtNombreClaseResponse.Text.ToUpper() + "." + txtNombreClaseResponse.Text.ToLower() + ".Add(i)" + Environment.NewLine;
                codigoMetodoConsumo += "                                       }" + Environment.NewLine;
                codigoMetodoConsumo += "                                    }" + Environment.NewLine;
                codigoMetodoConsumo += "                                    "+txtNombreClaseResponse.Text.ToUpper()+".codigoRespuesta = objResponseLineasFullClaro.MessageResponse.Body.obtenerLineasValidasResponse.responseAudit.codigoRespuesta; " + Environment.NewLine;
                codigoMetodoConsumo += "                                    "+txtNombreClaseResponse.Text.ToUpper()+".mensajeRespuesta = objResponseLineasFullClaro.MessageResponse.Body.obtenerLineasValidasResponse.responseAudit.mensajeRespuesta; " + Environment.NewLine;
                codigoMetodoConsumo += "                            }" + Environment.NewLine;
                codigoMetodoConsumo += "                    }" + Environment.NewLine;
                codigoMetodoConsumo += "               }" + Environment.NewLine;
                codigoMetodoConsumo += "           }" + Environment.NewLine;
                codigoMetodoConsumo += "           if(" + txtNombreClaseResponse.Text.ToUpper() + "." + txtNombreClaseResponse.Text.ToLower() + ".Count > 0 )" + Environment.NewLine;
                codigoMetodoConsumo += "           {" + Environment.NewLine;
                codigoMetodoConsumo += "                Tools.Traces.Logging.Info("+ txtNombreClaseRequest.Text+".IdSession," + txtNombreClaseRequest.Text + ".numeroDocumento, \"GetLineasFullClaro - Se obtubo la lista\");" + Environment.NewLine;
                codigoMetodoConsumo += "                Tools.Traces.Logging.Info(" + txtNombreClaseRequest.Text + ".IdSession," + txtNombreClaseRequest.Text + ".numeroDocumento, \"FIN: GetLineasFullClaro\");" + Environment.NewLine;
                codigoMetodoConsumo += "                return Json(" + txtNombreClaseResponse.Text.ToLower() + ");" + Environment.NewLine;
                codigoMetodoConsumo += "           }" + Environment.NewLine;
                codigoMetodoConsumo += "           return Json(new Claro.SIACU.Web.Application.BonusFullClaro.BonusFullClaroMasivoWS.ObtenerLineasMovilFijaBodyResponse()" + txtNombreClaseResponse.Text.ToLower() + ");" + Environment.NewLine;
                codigoMetodoConsumo += "           {" + Environment.NewLine;
                codigoMetodoConsumo += "                mensajeError = \"\"" + Environment.NewLine;
                codigoMetodoConsumo += "           });" + Environment.NewLine;
                codigoMetodoConsumo += "       }" + Environment.NewLine;
                codigoMetodoConsumo += "       catch (Exception ex)" + Environment.NewLine;
                codigoMetodoConsumo += "       {" + Environment.NewLine;
                codigoMetodoConsumo += "           Tools.Traces.Logging.Error("+txtNombreClaseRequest.Text+".IdSession, "+txtNombreClaseRequest.Text+".IdSession, ex.Message);" + Environment.NewLine;
                codigoMetodoConsumo += "           throw;" + Environment.NewLine;
                codigoMetodoConsumo += "       }" + Environment.NewLine;
                codigoMetodoConsumo += "}" + Environment.NewLine;
                */
                #endregion
                #region codigosParaRequest
                /*Inicio Generando la Clase*/
                codigoClaseRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                codigoClaseRequest += Environment.NewLine;
                codigoClaseRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                codigoClaseRequest += "{" + Environment.NewLine;
                codigoClaseRequest += "    [System.Serializable()]" + Environment.NewLine;
                codigoClaseRequest += "    [DataContract]" + Environment.NewLine;
                codigoClaseRequest += Environment.NewLine;
                codigoClaseRequest += "    public class " + txtNombreClaseRequest.Text + "Request" + Environment.NewLine;
                codigoClaseRequest += "    {" + Environment.NewLine;
                codigoClaseRequest += "        [DataMember(Name = \"MessageRequest\")]" + Environment.NewLine;
                codigoClaseRequest += "        public MessageRequest" + txtNombreClaseRequest.Text + " MessageRequest { get; set; }" + Environment.NewLine;
                codigoClaseRequest += "        public " + txtNombreClaseRequest.Text + "Request()" + Environment.NewLine;
                codigoClaseRequest += "        {" + Environment.NewLine;
                codigoClaseRequest += "            MessageRequest = new MessageRequest" + txtNombreClaseRequest.Text + "();" + Environment.NewLine;
                codigoClaseRequest += "        }" + Environment.NewLine;
                codigoClaseRequest += "    }" + Environment.NewLine;
                codigoClaseRequest += "}" + Environment.NewLine;
                CreacionDeArchivos(txtNombreClaseRequest.Text + "Request", codigoClaseRequest);
                /*Fin generar Clase*/
                /*Inicio Generando ClaseMesageRequest*/
                codigoMesageRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                codigoMesageRequest += Environment.NewLine;
                codigoMesageRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                codigoMesageRequest += "{" + Environment.NewLine;
                codigoMesageRequest += "    [System.Serializable()]" + Environment.NewLine;
                codigoMesageRequest += "    [DataContract]" + Environment.NewLine;
                codigoMesageRequest += "    public class MessageRequest" + txtNombreClaseRequest.Text + Environment.NewLine;
                codigoMesageRequest += "    {" + Environment.NewLine;
                codigoMesageRequest += "        [DataMember(Name = \"Header\")]" + Environment.NewLine;
                codigoMesageRequest += "        public DataPowerRest.HeadersRequest Header { get; set; }" + Environment.NewLine;
                codigoMesageRequest += "        [DataMember(Name = \"Body\")]" + Environment.NewLine;
                codigoMesageRequest += "        public BodyRequest" + txtNombreClaseRequest.Text + " Body { get; set; }" + Environment.NewLine;
                codigoMesageRequest += "        public MessageRequest" + txtNombreClaseRequest.Text + "()" + Environment.NewLine;
                codigoMesageRequest += "        {" + Environment.NewLine;
                codigoMesageRequest += "            Header = new DataPowerRest.HeadersRequest();" + Environment.NewLine;
                codigoMesageRequest += "            Body = new BodyRequest" + txtNombreClaseRequest.Text + "();" + Environment.NewLine;
                codigoMesageRequest += "        }" + Environment.NewLine;
                codigoMesageRequest += "    }" + Environment.NewLine;
                codigoMesageRequest += "}" + Environment.NewLine;
                CreacionDeArchivos("MessageRequest" + txtNombreClaseRequest.Text, codigoMesageRequest);
                /*Fin Generando ClaseMesageRequest*/
                /*Inicio Generando Clase de los datos de primer nivel*/
                codigoBodyRequest += "using System.Collections.Generic;" + Environment.NewLine;
                codigoBodyRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                codigoBodyRequest += Environment.NewLine;
                codigoBodyRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                codigoBodyRequest += "{" + Environment.NewLine;
                codigoBodyRequest += "    [System.Serializable()]" + Environment.NewLine;
                codigoBodyRequest += "    [DataContract]" + Environment.NewLine;
                codigoBodyRequest += "    public class BodyRequest" + txtNombreClaseRequest.Text + Environment.NewLine;
                codigoBodyRequest += "    {" + Environment.NewLine;
                foreach (DataGridViewRow row in dgvVariablesRequest.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "List")
                    {
                        nombreClaseRequestBE = "Lista" + txtNombreClaseRequest.Text;
                        codigoBodyRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoBodyRequest += "        public List<" + row.Cells[0].Value.ToString() + "> " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                    }
                    else if (row.Cells[1].Value.ToString() == "Object")
                    {
                        nombreClaseRequestBE = "BodyRequest" + txtNombreClaseRequest.Text;
                        codigoBodyRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoBodyRequest += "        public BE" + row.Cells[0].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                        codigoBodyRequest += "        public BodyRequest" + txtNombreClaseRequest.Text + "()" + Environment.NewLine;
                        codigoBodyRequest += "        {" + Environment.NewLine;
                        codigoBodyRequest += "            " + row.Cells[0].Value.ToString() + "= new BE" + row.Cells[0].Value.ToString() + "Request();" + Environment.NewLine;
                        codigoBodyRequest += "        }" + Environment.NewLine;
                    }
                    else
                    {
                        nombreClaseRequestBE = "BodyRequest" + txtNombreClaseRequest.Text;
                        codigoBodyRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoBodyRequest += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                    }
                }
                codigoBodyRequest += "    }" + Environment.NewLine;
                codigoBodyRequest += "}" + Environment.NewLine;
                CreacionDeArchivos(nombreClaseRequestBE, codigoBodyRequest);
                /*fin Generando Clase de los datos de primer nivel*/
                /*inicio Generando Clase de 2do nivel*/
                if (dgvVariablesListaRequest.RowCount > 0)
                {
                    codigoListaRequest += "using System.Collections.Generic;" + Environment.NewLine;
                    codigoListaRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                    codigoListaRequest += Environment.NewLine;
                    codigoListaRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                    codigoListaRequest += "{" + Environment.NewLine;
                    codigoListaRequest += "    [System.Serializable()]" + Environment.NewLine;
                    codigoListaRequest += "    [DataContract]" + Environment.NewLine;
                    foreach (DataGridViewRow row in dgvVariablesRequest.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == "List" || row.Cells[1].Value.ToString() == "Object")
                        {
                            nombreClaseListaRequestBE = "BE" + row.Cells[0].Value.ToString();
                            codigoListaRequest += "    public class BE" + row.Cells[0].Value.ToString() + Environment.NewLine;
                        }
                    }
                    codigoListaRequest += "    {" + Environment.NewLine;
                    foreach (DataGridViewRow row in dgvVariablesListaRequest.Rows)
                    {
                        codigoListaRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoListaRequest += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                    }
                    codigoListaRequest += "    }" + Environment.NewLine;
                    codigoListaRequest += "}" + Environment.NewLine;
                    CreacionDeArchivos(nombreClaseListaRequestBE, codigoListaRequest);
                }
                /*FIN Generando Clase de 2do nivel*/
                #endregion

                #region codigosParaResponse
                /*Inicio Generando la Clase*/
                codigoClaseResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                codigoClaseResponse += Environment.NewLine;
                codigoClaseResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoClaseResponse += "{" + Environment.NewLine;
                codigoClaseResponse += "    [System.Serializable()]" + Environment.NewLine;
                codigoClaseResponse += "    [DataContract]" + Environment.NewLine;
                codigoClaseResponse += Environment.NewLine;
                codigoClaseResponse += "    public class " + txtNombreClaseResponse.Text + "Response" + Environment.NewLine;
                codigoClaseResponse += "    {" + Environment.NewLine;
                codigoClaseResponse += "        [DataMember(Name = \"MessageResponse\")]" + Environment.NewLine;
                codigoClaseResponse += "        public MessageResponse" + txtNombreClaseResponse.Text + " MessageResponse { get; set; }" + Environment.NewLine;
                codigoClaseResponse += "        public " + txtNombreClaseResponse.Text + "Request()" + Environment.NewLine;
                codigoClaseResponse += "        {" + Environment.NewLine;
                codigoClaseResponse += "            MessageResponse = new MessageResponse" + txtNombreClaseResponse.Text + "();" + Environment.NewLine;
                codigoClaseResponse += "        }" + Environment.NewLine;
                codigoClaseResponse += "    }" + Environment.NewLine;
                codigoClaseResponse += "}" + Environment.NewLine;
                CreacionDeArchivos(txtNombreClaseResponse.Text + "Response", codigoClaseResponse);
                /*Fin generar Clase*/

                /*Inicio Generando ClaseMesageRequest*/
                codigoMesageResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                codigoMesageResponse += Environment.NewLine;
                codigoMesageResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoMesageResponse += "{" + Environment.NewLine;
                codigoMesageResponse += "    [System.Serializable()]" + Environment.NewLine;
                codigoMesageResponse += "    [DataContract]" + Environment.NewLine;
                codigoMesageResponse += "    public class MessageResponse" + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoMesageResponse += "    {" + Environment.NewLine;
                codigoMesageResponse += "        [DataMember(Name = \"Header\")]" + Environment.NewLine;
                codigoMesageResponse += "        public DataPowerRest.HeadersResponse Header { get; set; }" + Environment.NewLine;
                codigoMesageResponse += "        [DataMember(Name = \"Body\")]" + Environment.NewLine;
                codigoMesageResponse += "        public BodyResponse" + txtNombreClaseResponse.Text + " Body { get; set; }" + Environment.NewLine;
                codigoMesageResponse += "        public MessageResponse" + txtNombreClaseResponse.Text + "()" + Environment.NewLine;
                codigoMesageResponse += "        {" + Environment.NewLine;
                codigoMesageResponse += "            Header = new DataPowerRest.HeadersRequest();" + Environment.NewLine;
                codigoMesageResponse += "            Body = new BodyResponse" + txtNombreClaseResponse.Text + "();" + Environment.NewLine;
                codigoMesageResponse += "        }" + Environment.NewLine;
                codigoMesageResponse += "    }" + Environment.NewLine;
                codigoMesageResponse += "}" + Environment.NewLine;
                CreacionDeArchivos("MessageResponse" + txtNombreClaseResponse.Text, codigoMesageResponse);
                /*Fin Generando ClaseMesageRequest*/

                /*Inicio Generando Clase BodyResponse*/
                codigoBodyResponse += "using System.Collections.Generic;" + Environment.NewLine;
                codigoBodyResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                codigoBodyResponse += Environment.NewLine;
                codigoBodyResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBodyResponse += "{" + Environment.NewLine;
                codigoBodyResponse += "    [System.Serializable()]" + Environment.NewLine;
                codigoBodyResponse += "    [DataContract]" + Environment.NewLine;
                codigoBodyResponse += "    public class BodyResponse" + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBodyResponse += "    {" + Environment.NewLine;
                codigoBodyResponse += "        [DataMember(Name = \"" + txtNombreClaseResponse.Text + "\")]" + Environment.NewLine;
                codigoBodyResponse += "        public BE" + txtNombreClaseResponse.Text + " " + txtNombreClaseResponse.Text + " { get; set; }" + Environment.NewLine;
                codigoBodyResponse += "        public BodyResponse" + txtNombreClaseResponse.Text + "()" + Environment.NewLine;
                codigoBodyResponse += "        {" + Environment.NewLine;
                codigoBodyResponse += "            " + txtNombreClaseResponse.Text + " = new BE" + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBodyResponse += "        }" + Environment.NewLine;
                codigoBodyResponse += "    }" + Environment.NewLine;
                codigoBodyResponse += "}" + Environment.NewLine;
                CreacionDeArchivos("BodyResponse" + txtNombreClaseResponse.Text, codigoBodyResponse);
                /*Fin Generando Clase Clase BodyResponse*/

                /*Inicio Generando Clase BE de Response*/
                codigoBeClaseResponse += "using System.Collections.Generic;" + Environment.NewLine;
                codigoBeClaseResponse += Environment.NewLine;
                codigoBeClaseResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBeClaseResponse += "{" + Environment.NewLine;
                codigoBeClaseResponse += "    [System.Serializable()]" + Environment.NewLine;
                codigoBeClaseResponse += "    [DataContract]" + Environment.NewLine;
                codigoBeClaseResponse += "    public class BE" + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBeClaseResponse += "    {" + Environment.NewLine;
                codigoBeClaseResponse += "        [DataMember(Name = \"responseStatus\")]" + Environment.NewLine;
                codigoBeClaseResponse += "        public BEresponseStatus responseStatus { get; set; }" + Environment.NewLine;
                codigoBeClaseResponse += "        [DataMember(Name = \"responseData\")]" + Environment.NewLine;
                codigoBeClaseResponse += "        public BEresponseData responseData { get; set; }" + Environment.NewLine;
                codigoBeClaseResponse += "        public BE" + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBeClaseResponse += "        {" + Environment.NewLine;
                codigoBeClaseResponse += "            responseStatus = new BEresponseStatus();" + Environment.NewLine;
                codigoBeClaseResponse += "            responseData = new BEresponseData();" + Environment.NewLine;
                codigoBeClaseResponse += "        }" + Environment.NewLine;
                codigoBeClaseResponse += "    }" + Environment.NewLine;
                codigoBeClaseResponse += "}" + Environment.NewLine;
                CreacionDeArchivos("BE" + txtNombreClaseResponse.Text, codigoBeClaseResponse);
                /*Fin Generando Clase BE de Response*/

                /*Inicio Generando Clase BEresponseStatus*/
                codigoBEresponseStatus += "using System.Collections.Generic;" + Environment.NewLine;
                codigoBEresponseStatus += Environment.NewLine;
                codigoBEresponseStatus += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBEresponseStatus += "{" + Environment.NewLine;
                codigoBEresponseStatus += "    [System.Serializable()]" + Environment.NewLine;
                codigoBEresponseStatus += "    [DataContract]" + Environment.NewLine;
                codigoBEresponseStatus += "    public class BEresponseStatus" + Environment.NewLine;
                codigoBEresponseStatus += "    {" + Environment.NewLine;
                codigoBEresponseStatus += "         [DataMember(Name = \"idTransaccion\")]" + Environment.NewLine;
                codigoBEresponseStatus += "         public string idTransaccion { get; set; }" + Environment.NewLine;
                codigoBEresponseStatus += "         [DataMember(Name = \"codigoRespuesta\")]" + Environment.NewLine;
                codigoBEresponseStatus += "         public string codigoRespuesta { get; set; }" + Environment.NewLine;
                codigoBEresponseStatus += "         [DataMember(Name = \"mensajeRespuesta\")]" + Environment.NewLine;
                codigoBEresponseStatus += "         public string mensajeRespuesta { get; set; }" + Environment.NewLine;
                codigoBEresponseStatus += "    }" + Environment.NewLine;
                codigoBEresponseStatus += "}" + Environment.NewLine;
                CreacionDeArchivos("BEresponseStatus", codigoBEresponseStatus);
                /*Fin Generando Clase BEresponseStatus*/

                /*Inicio Generando Clase BEresponseData*/
                codigoBEresponseData += "using System.Collections.Generic;" + Environment.NewLine;
                codigoBEresponseData += Environment.NewLine;
                codigoBEresponseData += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoBEresponseData += "{" + Environment.NewLine;
                codigoBEresponseData += "    [System.Serializable()]" + Environment.NewLine;
                codigoBEresponseData += "    [DataContract]" + Environment.NewLine;
                codigoBEresponseData += "    public class BEresponseData" + Environment.NewLine;
                codigoBEresponseData += "    {" + Environment.NewLine;
                foreach (DataGridViewRow row in dgvVariablesResponse.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "List")
                    {
                        //nombreDataResponsetBE = "Lista" + txtNombreClaseRequest.Text;
                        codigoBEresponseData += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoBEresponseData += "        public List<" + row.Cells[0].Value.ToString() + "> " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                    }
                    else if (row.Cells[1].Value.ToString() == "Object")
                    {
                        //nombreDataResponsetBE = "BodyRequest" + txtNombreClaseRequest.Text;
                        codigoBEresponseData += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoBEresponseData += "        public " + row.Cells[0].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                        codigoBEresponseData += "        public BodyRequest" + txtNombreClaseRequest.Text + "()" + Environment.NewLine;
                        codigoBEresponseData += "        {" + Environment.NewLine;
                        codigoBEresponseData += "            " + row.Cells[0].Value.ToString() + "= new " + row.Cells[0].Value.ToString() + "Request();" + Environment.NewLine;
                        codigoBEresponseData += "        }" + Environment.NewLine;
                    }
                    else
                    {
                        codigoBEresponseData += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoBEresponseData += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                    }
                }
                codigoBEresponseData += "   }" + Environment.NewLine;
                codigoBEresponseData += "}" + Environment.NewLine;
                CreacionDeArchivos("BEresponseData", codigoBEresponseData);
                /*Fin Generando Clase BEresponseData*/

                /*Inicio Generando Clase BEresponseDataLista*/
                if (dgvVariablesListaResponse.RowCount > 0)
                {
                    codigoListaResponse += "using System.Collections.Generic;" + Environment.NewLine;
                    codigoListaResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                    codigoListaResponse += Environment.NewLine;
                    codigoListaResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                    codigoListaResponse += "{" + Environment.NewLine;
                    codigoListaResponse += "    [System.Serializable()]" + Environment.NewLine;
                    codigoListaResponse += "    [DataContract]" + Environment.NewLine;
                    foreach (DataGridViewRow row in dgvVariablesResponse.Rows)
                    {
                        if (row.Cells[1].Value.ToString() == "List" || row.Cells[1].Value.ToString() == "Object")
                        {
                            nombreClaseListaRequestBE = "BELista" + row.Cells[0].Value.ToString();
                            codigoListaResponse += "    public class BELista" + row.Cells[0].Value.ToString() + Environment.NewLine;
                        }
                    }
                    codigoListaResponse += "    {" + Environment.NewLine;
                    foreach (DataGridViewRow row in dgvVariablesListaResponse.Rows)
                    {
                        codigoListaResponse += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                        codigoListaResponse += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                    }
                    codigoListaResponse += "    }" + Environment.NewLine;
                    codigoListaResponse += "}" + Environment.NewLine;
                    CreacionDeArchivos(nombreClaseListaRequestBE, codigoListaResponse);
                }
                /*Fin Generando Clase BEresponseDataLista*/
                #endregion

                #region codigosParaMetodoConsumo
                codigoMetodoConsumo += "Private Function " + txtNombreMetodo.Text + "(";
                foreach (DataGridViewRow row in dgvVariablesListaRequest.Rows)
                {
                    codigoMetodoConsumo += " ByVal " + row.Cells[1].Value.ToString() + " As " + row.Cells[0].Value.ToString();
                }
                codigoMetodoConsumo += ") As String" + Environment.NewLine;
                codigoMetodoConsumo += "    log.Info(\"[Inicio: " + txtNombreMetodo.Text + "]\")" + Environment.NewLine;
                codigoMetodoConsumo += "    Dim obj" + txtNombreClaseRequest.Text + "Request As New " + txtNombreClaseRequest.Text + "Carpeta." + txtNombreClaseRequest.Text + Environment.NewLine;
                codigoMetodoConsumo += "    Dim obj" + txtNombreClaseResponse.Text + "Request As New " + txtNombreClaseResponse.Text + "Carpeta." + txtNombreClaseResponse.Text + Environment.NewLine;
                codigoMetodoConsumo += "    Dim objBEAuditoriaREST As New Claro.SIAC.Entidades.BEAuditoriaRequest" + Environment.NewLine;
                codigoMetodoConsumo += "    Dim objHeaderRequest As New DataPowerRest.HeaderRequest" + Environment.NewLine;
                codigoMetodoConsumo += "    Dim objAuditRequest As New CancelarSuscripcionAsynClaroVideoRest.BEAuditRequest" + Environment.NewLine;
                codigoMetodoConsumo += "    Dim Aqui va la referencia del Servicio" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "    AQUI_DECLARACION_DE_VARIABLE_RESULTADO" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "    Try" + Environment.NewLine;
                codigoMetodoConsumo += "        Dim strUser As String = CurrentUser()" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.consumer = ConfigurationManager.AppSettings(\"consumerAMCO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.country = ConfigurationManager.AppSettings(\"countryAMCO\")" + Environment.NewLine; 
                codigoMetodoConsumo += "        objHeaderRequest.dispositivo = ConfigurationManager.AppSettings(\"dispositivoAMCO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.language = ConfigurationManager.AppSettings(\"languageAMCO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.modulo = ConfigurationManager.AppSettings(\"strmoduloAMCO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.msgType = ConfigurationManager.AppSettings(\"msgTypeAMCO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.operation = ConfigurationManager.AppSettings(\"strOperationAMCO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.pid = DateTime.Now.ToString(\"yyyyMMddHHmmssfff\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.system = ConfigurationManager.AppSettings(\"systemAMCO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.timestamp = DateTime.Now" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.userId = strUser" + Environment.NewLine;
                codigoMetodoConsumo += "        objHeaderRequest.wsIp = GetApplicationIp()" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        obj" + txtNombreClaseRequest.Text + "MessageRequest.Header.HeaderRequest = objHeaderRequest" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        objAuditRequest.idTransaccion = DateTime.Now.ToString(\"yyyyMMddHHmmssfff\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objAuditRequest.ipAplicacion = GetApplicationIp()" + Environment.NewLine;
                codigoMetodoConsumo += "        objAuditRequest.nombreAplicacion = ConfigurationManager.AppSettings(\"CodigoAplicacion\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objAuditRequest.usuarioAplicacion = CurrentUser()" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                foreach (DataGridViewRow row in dgvVariablesListaRequest.Rows)
                {
                    codigoMetodoConsumo += "        obj" + txtNombreClaseRequest.Text + ".MessageRequest.Body." + row.Cells[0].Value.ToString() + " = " + row.Cells[0].Value.ToString() + Environment.NewLine;
                }
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        obj" + txtNombreClaseRequest.Text + ".MessageRequest.Body.auditRequest = objAuditRequest" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST = New BEAuditoriaRequest" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.idTransaccion = DateTime.Now.ToString(\"yyyyMMddHHmmss\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.ipApplication = ConfigurationManager.AppSettings(\"idtransaccionesb\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.usuarioAplicacion = SIAC_session.CodUsuario" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.nameRegEdit = \"\"" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.applicationCodeWS = ConfigurationManager.AppSettings(\"AQUI_LA_URL_DEL_SERVICIO\")" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.userId = strUser" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.idTransaccionNegocio = objHeaderRequest.pid" + Environment.NewLine;
                codigoMetodoConsumo += "        objBEAuditoriaREST.applicationCode = ConfigurationManager.AppSettings(\"codaplicacion\")" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        Dim Log" + txtNombreClaseRequest.Text +  "Request As String = New JavaScriptSerializer().Serialize(obj" + txtNombreClaseRequest.Text + "Request)" + Environment.NewLine;
                codigoMetodoConsumo += "        log.Info(String.Format(\"Info Log" + txtNombreClaseRequest.Text + "Request : {0}\", Log" + txtNombreClaseRequest.Text + "Request))" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        Dim LogBEAuditoriaREST As String = New JavaScriptSerializer().Serialize(objBEAuditoriaREST)" + Environment.NewLine;
                codigoMetodoConsumo += "        log.Info(String.Format(\"Info LogBEAuditoriaREST: {0}\", LogBEAuditoriaREST))" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        obj" + txtNombreClaseResponse.Text + "Response = obj" + txtNombreClaseRequest.Text + ".NOMBRE_DEL_METODO(obj" + txtNombreClaseRequest.Text + "Request, objBEAuditoriaREST)" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "        Dim Log" + txtNombreClaseResponse.Text + "Response As String = New JavaScriptSerializer().Serialize(obj" + txtNombreClaseResponse.Text + "Response)" + Environment.NewLine;
                codigoMetodoConsumo += "        log.Info(String.Format(\"Info Log" + txtNombreClaseResponse.Text + "Request : {0}\", Log" + txtNombreClaseResponse.Text + "Response))" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "         If obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.code.Equals(\"0\") Then" + Environment.NewLine;
                codigoMetodoConsumo += "             log.Info(String.Format(\"[obj" + txtNombreClaseResponse.Text 
                    + "Response Header HeaderResponse]: Consumer: {0}, Pid: {1}, Status Code: {2}, Status Message: {3}, Status Msgid: {4}, Status Type: {5}, TimeStamp: {6}, VarArg: {7}\", obj" 
                    + txtNombreClaseResponse.Text + ".MessageResponse.Header.HeaderResponse.Consumer, obj" 
                    + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Pid, obj" 
                    + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.code, obj" 
                    + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.message, obj" 
                    + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.msgid, obj" 
                    + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.type, obj" 
                    + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Timestamp, obj" 
                    + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.VarArg))" 
                    + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "             If obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.codigoRespuesta.Equals(\"0\") Then" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "                 log.InfoFormat(\"info [" + txtNombreClaseResponse.Text + "]: po_coderror {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.codigoRespuesta)" + Environment.NewLine;
                codigoMetodoConsumo += "                 log.InfoFormat(\"info [" + txtNombreClaseResponse.Text + "]: po_msjerror {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.mensajeRespuesta)" + Environment.NewLine;
                codigoMetodoConsumo += "                 AQUI_DECLARACION_DE_VARIABLE_RESULTADO = obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.mensajeError.ToString()" + Environment.NewLine;
                codigoMetodoConsumo += "             Else" + Environment.NewLine;
                codigoMetodoConsumo += "                 log.ErrorFormat(\"error [" + txtNombreClaseResponse.Text + "]: {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.codigoRespuesta)" + Environment.NewLine;
                codigoMetodoConsumo += "             End If" + Environment.NewLine;
                codigoMetodoConsumo += "         Else" + Environment.NewLine;
                codigoMetodoConsumo += "             log.ErrorFormat(\"Error [" + txtNombreClaseResponse.Text + "]: {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.message)" + Environment.NewLine;
                codigoMetodoConsumo += "         End If" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "    Catch ex As Exception" + Environment.NewLine;
                codigoMetodoConsumo += "        log.ErrorFormat(\"Error [CancelarSuscripcionAsyn]: {0} \", ex.Message)" + Environment.NewLine;
                codigoMetodoConsumo += "    Finally" + Environment.NewLine;
                codigoMetodoConsumo += "        log.Info(\"[CancelarSuscripcionAsyn] Fin\")" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "    End Try" + Environment.NewLine;
                codigoMetodoConsumo += "    Return AQUI_DECLARACION_DE_VARIABLE_RESULTADO" + Environment.NewLine;
                codigoMetodoConsumo += Environment.NewLine;
                codigoMetodoConsumo += "End Function" + Environment.NewLine;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //txtClaseRequest.Text = codigoRequest + codigoRequestLista;
            txtClaseRequest.Text = codigoClaseRequest + Environment.NewLine + codigoMesageRequest + Environment.NewLine + codigoBodyRequest + Environment.NewLine + codigoListaRequest;
            txtClaseResponse.Text = codigoClaseResponse + Environment.NewLine + codigoMesageResponse + Environment.NewLine + codigoBodyResponse + Environment.NewLine + codigoBeClaseResponse + Environment.NewLine + codigoListaResponse + Environment.NewLine + codigoBEresponseStatus + Environment.NewLine + codigoBEresponseData;
            txtMetodoConsumo.Text = codigoMetodoConsumo;
        }
        private void CreacionDeArchivos(string nombreArchivo, string textoAEscribir)
        {
            string ruta = txtRutaArchivo.Text + "\\" + nombreArchivo + ".cs";
            try
            {

                using (FileStream fs = File.Create(ruta))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(textoAEscribir);
                    fs.Write(info, 0, info.Length);
                }

            }
            catch (Exception exttt)
            {
                MessageBox.Show(exttt.Message);
            }
        }
        private void cmbTipoVariableRequest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbmTipoVariableResponse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarVariablesListRequest_Click(object sender, EventArgs e)
        {
            if (ValidarNombreVariableListaRequest() == false)
            {
                return;
            }
            if (ValidarTipoVariableListRequest() == false)
            {
                return;
            }
            Variables listadoDeVariablesTipoListaRequest = new Variables();
            listadoDeVariablesTipoListaRequest.nombreVariable = txtNombreVariableListaRequest.Text;
            listadoDeVariablesTipoListaRequest.tipoVariable = cmbTipoVariableListaRequest.SelectedItem.ToString();
            listDeVariablesTipoListaRequest.Add(listadoDeVariablesTipoListaRequest);
            txtNombreVariableListaRequest.Text = string.Empty;
            cmbTipoVariableListaRequest.SelectedIndex = 0;
            dgvVariablesListaRequest.DataSource = new List<Variables>();
            dgvVariablesListaRequest.DataSource = listDeVariablesTipoListaRequest;
            ColocarBotonEliminarEnGrid(dgvVariablesListaRequest);

        }

        private void btnAgregarVariablesListResponse_Click(object sender, EventArgs e)
        {
            if (ValidarNombreVariableListaResponse() == false)
            {
                return;
            }
            if (ValidarTipoVariableListResponse() == false)
            {
                return;
            }
            Variables listadoListaDeVariablesTipoListaResponse = new Variables();
            listadoListaDeVariablesTipoListaResponse.nombreVariable = txtNombreVariablesListaResponse.Text;
            listadoListaDeVariablesTipoListaResponse.tipoVariable = cmbTipoVariableListaResponse.SelectedItem.ToString();
            listListaDeVariablesTipoListaResponse.Add(listadoListaDeVariablesTipoListaResponse);
            txtNombreVariablesListaResponse.Text = string.Empty;
            cmbTipoVariableListaResponse.SelectedIndex = 0;
            dgvVariablesListaResponse.DataSource = new List<Variables>();
            dgvVariablesListaResponse.DataSource = listListaDeVariablesTipoListaResponse;
            ColocarBotonEliminarEnGrid(dgvVariablesListaResponse);
        }

        private void btnAddVariablesRequestMasivo_Click(object sender, EventArgs e)
        {
            ProcesarJsonMasivo(1);
        }

        private void btnAddVariablesResponseMasivo_Click(object sender, EventArgs e)
        {
            ProcesarJsonMasivo(2);
        }

        private void ProcesarJsonMasivo(int tipoClase)
        {
            tipoClaseProcesoMasivo = tipoClase;

            using (var frmInputJson = new InputJson())
            {
                var result = frmInputJson.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;
                }
            }

            switch (tipoClase)
            {
                case 1:  // request
                    dgvVariablesRequest.DataSource = new List<Variables>();
                    dgvVariablesRequest.DataSource = listVariablesRequest;
                    ColocarBotonEliminarEnGrid(dgvVariablesRequest);

                    if (listDeVariablesTipoListaRequest.Count > 0)
                    {
                        gbVariableListaRequest.Visible = true; // debe ir antes del databinding
                        dgvVariablesListaRequest.DataSource = new List<Variables>();
                        dgvVariablesListaRequest.DataSource = listDeVariablesTipoListaRequest;
                        ColocarBotonEliminarEnGrid(dgvVariablesListaRequest);
                    }
                    break;

                case 2: // response
                    dgvVariablesResponse.DataSource = new List<Variables>();
                    dgvVariablesResponse.DataSource = listVariablesResponse;
                    ColocarBotonEliminarEnGrid(dgvVariablesResponse);

                    if (listListaDeVariablesTipoListaResponse.Count > 0)
                    {
                        gbVariableListaResponse.Visible = true;
                        dgvVariablesListaResponse.DataSource = new List<Variables>();
                        dgvVariablesListaResponse.DataSource = listListaDeVariablesTipoListaResponse;
                        ColocarBotonEliminarEnGrid(dgvVariablesListaResponse);
                    }
                    break;
            }

        }

        public void ColocarBotonEliminarEnGrid(DataGridView grid)
        {
            if (grid.Columns["dataGridViewDeleteButton"] != null)
            {
                grid.Columns.Remove("dataGridViewDeleteButton");
            }

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "";
            deleteButton.Text = "X";
            deleteButton.Width = 25;
            deleteButton.UseColumnTextForButtonValue = true;
            grid.Columns.Add(deleteButton);
        }

        private void BorrarFilaCallback(object sender, DataGridViewCellEventArgs eventArgs)
        {
            if (eventArgs.RowIndex == dgvVariablesRequest.NewRowIndex || eventArgs.RowIndex < 0)
                return;

            var grid = (DataGridView) sender;
            if (eventArgs.ColumnIndex == grid.Columns["dataGridViewDeleteButton"].Index)
            {
                List<Variables> listaVariables = new List<Variables>();
                Int32 indexFilaEliminada = grid.CurrentRow.Index;

                switch (grid.Name)
                {
                    case "dgvVariablesRequest":
                        listaVariables = listVariablesRequest;
                        break;
                    case "dgvVariablesListaRequest":
                        listaVariables = listDeVariablesTipoListaRequest;
                        break;
                    case "dgvVariablesResponse":
                        listaVariables = listVariablesResponse;
                        break;
                    case "dgvVariablesListaResponse":
                        listaVariables = listListaDeVariablesTipoListaResponse;
                        break;
                }

                listaVariables.RemoveAt(indexFilaEliminada);
                grid.DataSource = new List<Variables>();
                grid.DataSource = listaVariables;
            }
        }

        private void dgvVariablesRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BorrarFilaCallback(sender, e);
        }

        private void dgvVariablesListaRequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BorrarFilaCallback(sender, e);
        }

        private void dgvVariablesResponse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BorrarFilaCallback(sender, e);
        }

        private void dgvVariablesListaResponse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BorrarFilaCallback(sender, e);
        }

        private void formAutomatizacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}

