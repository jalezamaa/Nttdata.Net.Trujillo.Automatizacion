using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GENCODE
{
    public partial class Form1 : Form
    {
        public List<string> Variable_Nombre2 = new List<string>();
        public List<string> Variable_Tipo2 = new List<string>();
        Variables frm2 = new Variables();

        //DataGridView dgvVariables = new DataGridView();
        public int c = 0;
        public string TipoService;
        public Form1()
        {
            
            InitializeComponent();
           
        }
        public bool validator = false;
        private void btnVariable_Click(object sender, EventArgs e)
        {
           

            frm2.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(String.Join("\n", Variable_Nombre2));
            Console.WriteLine(String.Join("\n", Variable_Tipo2));
         
            int varaible = frm2.dataGridView1.RowCount;
            int FlagVal = frm2.FlagAct;
            TipoService = cboService.Text;
            if (string.IsNullOrWhiteSpace(txtProyecto.Text) || string.IsNullOrWhiteSpace(cboService.Text) || string.IsNullOrWhiteSpace(txtMejora.Text) || string.IsNullOrWhiteSpace(txtMessage.Text))
            {

                MessageBox.Show("Complete los datos", "Completar");
            }
            else { 
         
            if (FlagVal == 1)
            {

                Variable_Nombre2 = frm2.Variable_Nombre;
                Variable_Tipo2 = frm2.Variable_Tipo;
                Console.WriteLine(String.Join("\n", Variable_Nombre2));
                Console.WriteLine(String.Join("\n", Variable_Tipo2));

                validator = true;
                GenerarWB();
                GenerarBL();
                GenerarRequest();
                GenerarResponse();
                GenerarBEDatos();
                GenerarAspx();

                MessageBox.Show("Se ah generado Correctamente", "Terminado");
            }else{

                MessageBox.Show("Es necesario completar las variables", "Completar");

            }
          }
            
        }


        public void GenerarRequest()
        {
            
            string cadConsumo = string.Empty;
            cadConsumo += "//  " + txtProyecto.Text + "" + Environment.NewLine;

            if (TipoService == "DataPower")
            {

                cadConsumo += " using System;" + Environment.NewLine;
                cadConsumo += " using System.Collections.Generic;" + Environment.NewLine;
                cadConsumo += " using System.Linq;" + Environment.NewLine;
                cadConsumo += " using System.Text;" + Environment.NewLine;
                cadConsumo += " using System.Runtime.Serialization;" + Environment.NewLine;

                cadConsumo += "namespace Claro.SISACT.Entity.claro_int_" + txtMejora.Text + "" + Environment.NewLine;
                cadConsumo += " {" + Environment.NewLine;
                cadConsumo += " [DataContract]" + Environment.NewLine;
                cadConsumo += " [Serializable]" + Environment.NewLine;
                cadConsumo += " public class MessageRequest" + txtMejora.Text + "" + Environment.NewLine;
                cadConsumo += " {" + Environment.NewLine;
                cadConsumo += " [DataMember(Name = \"Header\")]" + Environment.NewLine;
                cadConsumo += " public DataPowerRest.HeadersRequest Header { get; set; }" + Environment.NewLine;
                cadConsumo += "" + Environment.NewLine;
                cadConsumo += " [DataMember(Name = \"" + txtMessage.Text + "Request\")]" + Environment.NewLine;
                cadConsumo += " public BE" + txtMejora.Text + "  " + txtMessage.Text + "Request { get; set; }" + Environment.NewLine;

                cadConsumo += "public MessageRequest" + txtMejora.Text + "()" + Environment.NewLine;
                cadConsumo += "{" + Environment.NewLine;
                cadConsumo += "    Header = new DataPowerRest.HeadersRequest();" + Environment.NewLine;
                cadConsumo += "    " + txtMessage.Text + "Request = new BE" + txtMejora.Text + "();" + Environment.NewLine;
                cadConsumo += "" + Environment.NewLine;
                cadConsumo += "    }" + Environment.NewLine;
                cadConsumo += "  }" + Environment.NewLine;
                cadConsumo += " }" + Environment.NewLine;
            }
            else if (TipoService == "RestService")
            {
               cadConsumo += " using System;" + Environment.NewLine;
               cadConsumo += " using System.Collections.Generic;" + Environment.NewLine;
               cadConsumo += " using System.Linq;" + Environment.NewLine;
               cadConsumo += " using System.Text;" + Environment.NewLine;
               cadConsumo += " using System.Runtime.Serialization;" + Environment.NewLine;

               cadConsumo += "namespace Claro.SISACT.Entity.claro_int_"+txtMejora.Text+"" + Environment.NewLine;
               cadConsumo += " {" + Environment.NewLine;
               cadConsumo += " [DataContract]" + Environment.NewLine;
               cadConsumo += " [Serializable]" + Environment.NewLine;
               cadConsumo += " public class MessageRequest" + txtMejora.Text + "" + Environment.NewLine;
               cadConsumo += " {" + Environment.NewLine;
               cadConsumo += "" + Environment.NewLine;
               cadConsumo += " [DataMember(Name = \"" + txtMessage.Text + "Request\")]" + Environment.NewLine;
               cadConsumo += " public BE" + txtMejora.Text + "  " + txtMessage.Text + "Request { get; set; }" + Environment.NewLine;

               cadConsumo += "public MessageRequest" + txtMejora.Text + "()" + Environment.NewLine;
               cadConsumo += "{" + Environment.NewLine;
               cadConsumo += "" + Environment.NewLine;
               cadConsumo += "    " + txtMessage.Text + "Request = new BE" + txtMejora.Text + "();" + Environment.NewLine;
               cadConsumo += "" + Environment.NewLine;
               cadConsumo += "    }" + Environment.NewLine;
               cadConsumo += "  }" + Environment.NewLine;
               cadConsumo += " }" + Environment.NewLine;

            }
            else
            {
            }
        
           

            //FINAL
            txtBERest.Text = cadConsumo;
           
        }
      
        public void GenerarBL()
        {
             string cadBL = string.Empty;
             cadBL += "//  " + txtProyecto.Text + "" + Environment.NewLine;

             if (TipoService == "DataPower")
             {

                 cadBL += "/// <summary>" + Environment.NewLine;
                 cadBL += "/// " + Environment.NewLine;
                 cadBL += "/// </summary>" + Environment.NewLine;
                 cadBL += "/// <param name=\"objResponse\"></param>" + Environment.NewLine;
                 cadBL += "/// <returns></returns>" + Environment.NewLine;
                 cadBL += "  public bool " + txtMessage.Text + "( ref MessageResponse" + txtMejora.Text + " objResponse) //agregar variables" + Environment.NewLine;
                 cadBL += "    {" + Environment.NewLine;
                 cadBL += "      GeneradorLog objLog = new GeneradorLog(null, string.Format(\"{0}{1}\", \"[INICIO][" + txtProyecto.Text + "][" + txtMessage + "]\", string.Empty), null, null);" + Environment.NewLine;
                 cadBL += "      BW" + txtMejora.Text + " obj" + txtMejora.Text + "WS = new BW" + txtMejora.Text + "();" + Environment.NewLine;
                 cadBL += "       MessageRequest" + txtMejora.Text + " objRequest = new MessageRequest" + txtMejora.Text + "();" + Environment.NewLine;
                 cadBL += "  bool blResultado = false;" + Environment.NewLine;
                 cadBL += "  try" + Environment.NewLine;
                 cadBL += "  {" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;


                 for (c = 0; c < Variable_Nombre2.Count; c++)
                 {
                     cadBL += "    objRequest." + txtMessage.Text + "Request." + Variable_Nombre2[c] + " = " + Variable_Nombre2[c] + ";" + Environment.NewLine;
                 }

                 cadBL += "" + Environment.NewLine;
                 cadBL += "    objResponse = obj" + txtMejora.Text + "WS." + txtMessage.Text + "WS(objRequest);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  if (objResponse != null && objResponse." + txtMessage.Text + "Response != null && objResponse." + txtMessage.Text + "Response.auditResponse != null" + Environment.NewLine;
                 cadBL += "      && objResponse." + txtMessage.Text + "Response.auditResponse.codigoRespuesta == \"0\")" + Environment.NewLine;
                 cadBL += "  {" + Environment.NewLine;
                 cadBL += "      blResultado = true;" + Environment.NewLine;
                 cadBL += "  }" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "][blResultado]\", blResultado), null, null);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "]\", string.Empty), null, null);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  return blResultado;" + Environment.NewLine;
                 cadBL += "  }" + Environment.NewLine;
                 cadBL += " catch(Exception ex)" + Environment.NewLine;
                 cadBL += " {" + Environment.NewLine;
                 cadBL += "   objLog.CrearArchivolog(string.Format(\"{0} {1} | {2}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "][ERROR]\", Funciones.CheckStr(ex.Message), Funciones.CheckStr(ex.StackTrace)), null, null);" + Environment.NewLine;
                 cadBL += "   objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "]\", string.Empty), null, null);" + Environment.NewLine;
                 cadBL += "   throw new Exception(ex.Message);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "}" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "}" + Environment.NewLine;
             }
             else if (TipoService == "RestService")
             {
                 cadBL += "/// <summary>" + Environment.NewLine;
                 cadBL += "/// " + Environment.NewLine;
                 cadBL += "/// </summary>" + Environment.NewLine;
                 cadBL += "/// <param name=\"objResponse\"></param>" + Environment.NewLine;
                 cadBL += "/// <returns></returns>" + Environment.NewLine;
                 cadBL += "  public bool " + txtMessage.Text + "( ref MessageResponse" + txtMejora.Text + " objResponse) //agregar variables" + Environment.NewLine;
                 cadBL += "    {" + Environment.NewLine;
                 cadBL += "      GeneradorLog objLog = new GeneradorLog(null, string.Format(\"{0}{1}\", \"[INICIO][" + txtProyecto.Text + "][" + txtMessage + "]\", string.Empty), null, null);" + Environment.NewLine;
                 cadBL += "      BW" + txtMejora.Text + " obj" + txtMejora.Text + "WS = new BW" + txtMejora.Text + "();" + Environment.NewLine;
                 cadBL += "       MessageRequest" + txtMejora.Text + " objRequest = new MessageRequest" + txtMejora.Text + "();" + Environment.NewLine;
                 cadBL += "  bool blResultado = false;" + Environment.NewLine;
                 cadBL += "  try" + Environment.NewLine;
                 cadBL += "  {" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;


                 for (c = 0; c < Variable_Nombre2.Count; c++)
                 {
                     cadBL += "    objRequest." + txtMessage.Text + "Request." + Variable_Nombre2[c] + " = " + Variable_Nombre2[c] + ";" + Environment.NewLine;
                 }

                 cadBL += "" + Environment.NewLine;
                 cadBL += "    objResponse = obj" + txtMejora.Text + "WS." + txtMessage.Text + "WS(objRequest);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  if (objResponse != null && objResponse." + txtMessage.Text + "Response != null && objResponse." + txtMessage.Text + "Response.auditResponse != null" + Environment.NewLine;
                 cadBL += "      && objResponse." + txtMessage.Text + "Response.auditResponse.codigoRespuesta == \"0\")" + Environment.NewLine;
                 cadBL += "  {" + Environment.NewLine;
                 cadBL += "      blResultado = true;" + Environment.NewLine;
                 cadBL += "  }" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "][blResultado]\", blResultado), null, null);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "]\", string.Empty), null, null);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "  return blResultado;" + Environment.NewLine;
                 cadBL += "  }" + Environment.NewLine;
                 cadBL += " catch(Exception ex)" + Environment.NewLine;
                 cadBL += " {" + Environment.NewLine;
                 cadBL += "   objLog.CrearArchivolog(string.Format(\"{0} {1} | {2}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "][ERROR]\", Funciones.CheckStr(ex.Message), Funciones.CheckStr(ex.StackTrace)), null, null);" + Environment.NewLine;
                 cadBL += "   objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "]\", string.Empty), null, null);" + Environment.NewLine;
                 cadBL += "   throw new Exception(ex.Message);" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "}" + Environment.NewLine;
                 cadBL += "" + Environment.NewLine;
                 cadBL += "}" + Environment.NewLine;
             }
             else
             {
                 #region StoreProcedureBL

                 cadBL += " public static bool Grabar" + txtMejora.Text + "(BE" + txtMejora.Text + " item" + txtMejora.Text + ")" + Environment.NewLine;
                 cadBL += " {" + Environment.NewLine;
                 cadBL += "   return DA" + txtMejora.Text + ".Grabar" + txtMejora.Text + "(BE" + txtMejora.Text + " item" + txtMejora.Text + ");" + Environment.NewLine;
                 cadBL += " }" + Environment.NewLine;

                 #endregion
             }



             //FINAL
             txtBL.Text = cadBL;
        }

        public void GenerarBEDatos()
        {
            string cadBEDatos = string.Empty;
            cadBEDatos += "//  " + txtProyecto.Text + "" + Environment.NewLine;

            if (TipoService == "DataPower")
            {
                cadBEDatos += "using System;" + Environment.NewLine;
                cadBEDatos += "using System.Collections.Generic;" + Environment.NewLine;
                cadBEDatos += "using System.Linq;" + Environment.NewLine;
                cadBEDatos += "using System.Text;" + Environment.NewLine;
                cadBEDatos += "using System.Runtime.Serialization;" + Environment.NewLine;

                cadBEDatos += " namespace Claro.SISACT.Entity.claro_int_" + txtMejora.Text + "" + Environment.NewLine;
                cadBEDatos += "  {" + Environment.NewLine;
                cadBEDatos += "   [DataContract]" + Environment.NewLine;
                cadBEDatos += "   [Serializable]" + Environment.NewLine;
                cadBEDatos += "   public class BE" + txtMejora.Text + "" + Environment.NewLine;
                cadBEDatos += "   {" + Environment.NewLine;
                cadBEDatos += "" + Environment.NewLine;
                for (c = 0; c < Variable_Nombre2.Count; c++)
                {
                    cadBEDatos += "  [DataMember(Name = \"" + Variable_Nombre2[c] + "\")]" + Environment.NewLine;
                    cadBEDatos += "  public " + Variable_Tipo2[c] + " " + Variable_Nombre2[c] + " { get; set; }" + Environment.NewLine;
                }

                cadBEDatos += "" + Environment.NewLine;
                cadBEDatos += "  }" + Environment.NewLine;
                cadBEDatos += "" + Environment.NewLine;
                cadBEDatos += " }" + Environment.NewLine;

            }
            else if (TipoService == "RestService")
            {

                 cadBEDatos += "using System;" + Environment.NewLine;
                 cadBEDatos += "using System.Collections.Generic;" + Environment.NewLine;
                 cadBEDatos += "using System.Linq;" + Environment.NewLine;
                 cadBEDatos += "using System.Text;" + Environment.NewLine;
                 cadBEDatos += "using System.Runtime.Serialization;" + Environment.NewLine;

                 cadBEDatos += " namespace Claro.SISACT.Entity.claro_int_"+txtMejora.Text+"" + Environment.NewLine;
                 cadBEDatos += "  {" + Environment.NewLine;
                 cadBEDatos += "   [DataContract]" + Environment.NewLine;
                 cadBEDatos += "   [Serializable]" + Environment.NewLine;
                 cadBEDatos += "   public class BE"+txtMejora.Text+"" + Environment.NewLine;
                 cadBEDatos += "   {" + Environment.NewLine;
                 cadBEDatos += "" + Environment.NewLine;
                  for (c = 0; c < Variable_Nombre2.Count; c++)
                {
                    cadBEDatos += "  [DataMember(Name = \"" + Variable_Nombre2[c] + "\")]" + Environment.NewLine;
                    cadBEDatos += "  public " + Variable_Tipo2[c] + " " + Variable_Nombre2[c] + " { get; set; }" + Environment.NewLine;
                 }

                 cadBEDatos += "" + Environment.NewLine;
                 cadBEDatos += "  }" + Environment.NewLine;
                 cadBEDatos += "" + Environment.NewLine;
                 cadBEDatos += " }" + Environment.NewLine;

            }
            else
            {
                #region BEDatos

                cadBEDatos += "using System;" + Environment.NewLine;
                cadBEDatos += "using System.Collections.Generic;" + Environment.NewLine;
                cadBEDatos += "using System.Linq;" + Environment.NewLine;
                cadBEDatos += "using System.Text;" + Environment.NewLine;
                cadBEDatos += "" + Environment.NewLine;
                cadBEDatos += "namespace Claro.SISACT.Entity" + Environment.NewLine;
                cadBEDatos += " {" + Environment.NewLine;
                cadBEDatos += " [Serializable] // " + txtProyecto.Text + " " + Environment.NewLine;
                cadBEDatos += " public class BE" + txtMejora.Text + " " + Environment.NewLine;
                cadBEDatos += " {" + Environment.NewLine;

                for (c = 0; c < Variable_Nombre2.Count; c++)
                {

                    cadBEDatos += " private " + Variable_Tipo2[c] + "  " + Variable_Nombre2[c] + ";" + Environment.NewLine;

                }


                cadBEDatos += "" + Environment.NewLine;
                cadBEDatos += " public BE" + txtMejora.Text + " () { }" + Environment.NewLine;
                cadBEDatos += "" + Environment.NewLine;

                for (c = 0; c < Variable_Nombre2.Count; c++)
                {

                    cadBEDatos += "   public " + Variable_Tipo2[c] + " " + Variable_Nombre2[c] + " " + Environment.NewLine;
                    cadBEDatos += "     {" + Environment.NewLine;
                    cadBEDatos += "       get { return " + Variable_Nombre2[c] + "; }" + Environment.NewLine;
                    cadBEDatos += "       set { " + Variable_Nombre2[c] + " = value; }" + Environment.NewLine;
                    cadBEDatos += "     }" + Environment.NewLine;
                }

                cadBEDatos += "" + Environment.NewLine;
                cadBEDatos += "" + Environment.NewLine;
                cadBEDatos += "   }" + Environment.NewLine;
                cadBEDatos += " }" + Environment.NewLine;

                #endregion
            }
          


            //FINAL
            txtBEDatos.Text = cadBEDatos;


        }

        public void GenerarResponse()
        {

              string cadResponse = string.Empty;
             cadResponse += "//  " + txtProyecto.Text + "" + Environment.NewLine;


            if (TipoService == "DataPower")
            {
                 cadResponse += "using System;" + Environment.NewLine;
                 cadResponse += "using System.Collections.Generic;" + Environment.NewLine;
                 cadResponse += "using System.Linq;" + Environment.NewLine;
                 cadResponse += "using System.Text;" + Environment.NewLine;
                 cadResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                 cadResponse += "using Claro.SISACT.Entity.GenericRequestResponse;" + Environment.NewLine;

                 cadResponse += "namespace Claro.SISACT.Entity.claro_int_"+txtMejora.Text+"" + Environment.NewLine;
                 cadResponse += "{" + Environment.NewLine;
                 cadResponse += " [DataContract]" + Environment.NewLine;
                 cadResponse += " [Serializable]" + Environment.NewLine;
                 cadResponse += " public class MessageResponse" + txtMejora.Text + "" + Environment.NewLine;
                 cadResponse += " {" + Environment.NewLine;
                 cadResponse += "    [DataMember(Name = \""+txtMessage.Text+"Response\")]" + Environment.NewLine;
                 cadResponse += "    public Response" + txtMejora.Text + "  " + txtMessage.Text + "Response { get; set; }" + Environment.NewLine;
                 cadResponse += " }" + Environment.NewLine;
                 cadResponse += "}" + Environment.NewLine;

            }
            else if (TipoService == "RestService")
            {
                cadResponse += "using System;" + Environment.NewLine;
                cadResponse += "using System.Collections.Generic;" + Environment.NewLine;
                cadResponse += "using System.Linq;" + Environment.NewLine;
                cadResponse += "using System.Text;" + Environment.NewLine;
                cadResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                cadResponse += "using Claro.SISACT.Entity.GenericRequestResponse;" + Environment.NewLine;

                cadResponse += "namespace Claro.SISACT.Entity.claro_int_" + txtMejora.Text + "" + Environment.NewLine;
                cadResponse += "{" + Environment.NewLine;
                cadResponse += " [DataContract]" + Environment.NewLine;
                cadResponse += " [Serializable]" + Environment.NewLine;
                cadResponse += " public class MessageResponse" + txtMejora.Text + "" + Environment.NewLine;
                cadResponse += " {" + Environment.NewLine;
                cadResponse += "    [DataMember(Name = \"" + txtMessage.Text + "Response\")]" + Environment.NewLine;
                cadResponse += "    public Response" + txtMejora.Text + "  " + txtMessage.Text + "Response { get; set; }" + Environment.NewLine;
                cadResponse += " }" + Environment.NewLine;
                cadResponse += "}" + Environment.NewLine;
            }
            else
            {
            }

            txtConsumo.Text = cadResponse;

        }
        public void GenerarWB() {

              string cadWB = string.Empty;
              cadWB += "//  " + txtProyecto.Text + "" + Environment.NewLine;

              // txtMejora  -  txtMessage - txtProyecto
           
            if (TipoService == "DataPower")
            {

                cadWB += "using System;" + Environment.NewLine;
                cadWB += "using System.Collections.Generic;" + Environment.NewLine;
                cadWB += "using System.Linq;" + Environment.NewLine;
                cadWB += "using System.Text;" + Environment.NewLine;
                // cadWB += "using Claro.SISACT.Entity.claro_int_transaccionCorreo;" + Environment.NewLine; //OBS claro_int por el servicio a usar
                cadWB += "using Claro.SISACT.Common;" + Environment.NewLine;
                cadWB += "using Claro.SISACT.Entity;" + Environment.NewLine;
                cadWB += "using System.Collections;" + Environment.NewLine;
                cadWB += "using Claro.SISACT.WS.RestServices;" + Environment.NewLine;
                cadWB += "using System.Configuration;" + Environment.NewLine;
                cadWB += "using System.Web;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "    namespace Claro.SISACT.WS" + Environment.NewLine;
                cadWB += "     {" + Environment.NewLine;
                cadWB += "         public class BW" + txtMejora.Text + " " + Environment.NewLine;
                cadWB += "        {" + Environment.NewLine;
                cadWB += "             public BW" + txtMejora.Text + "()" + Environment.NewLine;
                cadWB += "             {" + Environment.NewLine;
                cadWB += "             }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;


                cadWB += "    /// <summary>" + Environment.NewLine;
                cadWB += "    /// " + Environment.NewLine;
                cadWB += "    /// </summary>" + Environment.NewLine;
                cadWB += "    /// <param name=\"objRequest\"></param>" + Environment.NewLine;
                cadWB += "    /// <returns></returns>" + Environment.NewLine;
                cadWB += "    public MessageResponse" + txtMejora.Text + " " + txtMessage.Text + "WS(MessageRequest" + txtMejora.Text + " objRequest)" + Environment.NewLine;
                cadWB += "    {" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "         GeneradorLog objLog = new GeneradorLog(null, string.Format(\"{0}{1}\", \"[INICIO][" + txtProyecto.Text + "][ " + txtMessage.Text + "WS]\", string.Empty), null, null);" + Environment.NewLine;
                cadWB += "         MessageResponse" + txtMejora.Text + " objResponse = new MessageResponse" + txtMejora.Text + "();" + Environment.NewLine;
                cadWB += "         BEAuditoriaRequest objAuditoria = new BEAuditoriaRequest();" + Environment.NewLine;
                cadWB += "         Hashtable datosHeader = new Hashtable();" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "     try" + Environment.NewLine;
                cadWB += "          {" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;



                cadWB += " #region Header" + Environment.NewLine;
                cadWB += "  objAuditoria.wsIp = Funciones.CheckStr(ConfigurationManager.AppSettings[\"DAT_ConsultaNacionalidad_wsIp\"]);" + Environment.NewLine;
                cadWB += "  objAuditoria.ipTransaccion = Funciones.CheckStr(HttpContext.Current.Session[\"CurrentTerminal\"]);" + Environment.NewLine;
                cadWB += "  objAuditoria.usuarioAplicacion = Funciones.CheckStr(HttpContext.Current.Session[\"CurrentUser\"]);" + Environment.NewLine;
                cadWB += "  objAuditoria.applicationCode = Funciones.CheckStr(ConfigurationManager.AppSettings[\"constAplicacion\"]);" + Environment.NewLine;
                cadWB += "  objAuditoria.ipApplication = Funciones.CheckStr(ConfigurationManager.AppSettings[\"constUsuarioAplicacion\"]);" + Environment.NewLine;
                cadWB += "  objAuditoria.usuarioAplicacionEncriptado = Funciones.CheckStr(ConfigurationManager.AppSettings[\"User_ConsultaNacionalidad\"]);" + Environment.NewLine;
                cadWB += "  objAuditoria.claveEncriptada = Funciones.CheckStr(ConfigurationManager.AppSettings[\"Password_ConsultaNacionalidad\"]);" + Environment.NewLine;
                cadWB += "  objAuditoria.urlRest = \"Url" + txtMessage.Text + "WS\";" + Environment.NewLine;
                cadWB += "  objAuditoria.urlTimeOut_Rest = \"TimeOut" + txtMessage.Text + "WS\";" + Environment.NewLine;
                cadWB += "  objAuditoria.dataPower = false;" + Environment.NewLine;
                cadWB += " " + Environment.NewLine;
                cadWB += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestHeader][wsIp]\", objAuditoria.wsIp), null, null);" + Environment.NewLine;
                cadWB += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestHeader][ipTransaccion]\", objAuditoria.ipTransaccion), null, null);" + Environment.NewLine;
                cadWB += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestHeader][usuarioAplicacion]\", objAuditoria.usuarioAplicacion), null, null);" + Environment.NewLine;
                cadWB += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestHeader][applicationCode]\", objAuditoria.applicationCode), null, null);" + Environment.NewLine;
                cadWB += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestHeader][idAplicacion]\", objAuditoria.idAplicacion), null, null);" + Environment.NewLine;
                cadWB += "  objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestHeader][bolDataPower]\", objAuditoria.dataPower), null, null);" + Environment.NewLine;
                cadWB += " " + Environment.NewLine;
                cadWB += "  datosHeader.Add(\"idTransaccion\", DateTime.Now.ToString(\"yyyyMMddHHmmssfff\"));" + Environment.NewLine;
                cadWB += "  datosHeader.Add(\"msgId\", DateTime.Now.ToString(\"yyyyMMddHHmmssfff\"));" + Environment.NewLine;
                cadWB += "  datosHeader.Add(\"userId\", Funciones.CheckStr(ConfigurationManager.AppSettings[\"constAplicacion\"]));" + Environment.NewLine;
                cadWB += "  datosHeader.Add(\"timestamp\", DateTime.UtcNow.ToString(\"yyyy-MM-ddTHH:mm:ssZ\"));" + Environment.NewLine;
                cadWB += " " + Environment.NewLine;
                cadWB += "  objAuditoria.table = datosHeader;" + Environment.NewLine;
                cadWB += "  #endregion" + Environment.NewLine;
                cadWB += " " + Environment.NewLine;
                cadWB += " " + Environment.NewLine;





                cadWB += "    #region Body" + Environment.NewLine;


                for (c = 0; c < Variable_Nombre2.Count; c++)
                {

                    cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestBody][" + Variable_Nombre2[c] + "]\", Funciones.CheckStr(objRequest." + txtMessage.Text + "Request." + Variable_Nombre2[c] + ")), null, null);" + Environment.NewLine;

                }
                cadWB += "" + Environment.NewLine;
                cadWB += "     #endregion" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0} : {1} | {2} : {3}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][NameKeyWS]\", objAuditoria.urlRest, \"[ValorKeyWS]\", Funciones.CheckStr(ConfigurationManager.AppSettings[\"Url" + txtMessage.Text + "WS\"])), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0} : {1} | {2} : {3}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][NameTimeOutWS]\", objAuditoria.urlTimeOut_Rest, \"[ValorTimeOutWS]\", Funciones.CheckStr(ConfigurationManager.AppSettings[\"TimeOut" + txtMessage.Text + "WS\"])), null, null);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   string strIdTransaccion = string.Empty;" + Environment.NewLine;
                cadWB += "   string strCodigoRespuesta = string.Empty;" + Environment.NewLine;
                cadWB += "   string strMensajeRespuesta = string.Empty;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   objResponse = RestServiceDPGeneral.PostInvoque<MessageResponse" + txtMejora.Text + ">(objRequest, objAuditoria);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   strIdTransaccion = Funciones.CheckStr(objResponse." + txtMessage.Text + "Response.auditResponse.idTransaccion);" + Environment.NewLine;
                cadWB += "   strCodigoRespuesta = Funciones.CheckStr(objResponse." + txtMessage.Text + "Response.auditResponse.codigoRespuesta);" + Environment.NewLine;
                cadWB += "   strMensajeRespuesta = Funciones.CheckStr(objResponse." + txtMessage.Text + "Response.auditResponse.mensajeRespuesta);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Response][strIdTransaccion]\", strIdTransaccion), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Response][strCodigoRespuesta]\", strCodigoRespuesta), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Response][strMensajeRespuesta]\", strMensajeRespuesta), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "WS]\", string.Empty), null, null);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "     return objResponse;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "      }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "  catch (Exception ex)" + Environment.NewLine;
                cadWB += "   {" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "       objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Ocurrio un error con el servicio]\", Funciones.CheckStr(ConfigurationManager.AppSettings[objAuditoria.urlRest])), null, null);" + Environment.NewLine;
                cadWB += "       objLog.CrearArchivolog(string.Format(\"{0} {1} | {2}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][ERROR]\", Funciones.CheckStr(ex.Message), Funciones.CheckStr(ex.StackTrace)), null, null);" + Environment.NewLine;
                cadWB += "       objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "WS]\", string.Empty), null, null);" + Environment.NewLine;
                cadWB += "       throw new Exception(ex.Message);" + Environment.NewLine;
                cadWB += "   }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " }" + Environment.NewLine;


            }
            else if (TipoService == "RestService")
            {
                cadWB += "using System;" + Environment.NewLine;
                cadWB += "using System.Collections.Generic;" + Environment.NewLine;
                cadWB += "using System.Linq;" + Environment.NewLine;
                cadWB += "using System.Text;" + Environment.NewLine;
               // cadWB += "using Claro.SISACT.Entity.claro_int_transaccionCorreo;" + Environment.NewLine; //OBS claro_int por el servicio a usar
                cadWB += "using Claro.SISACT.Common;" + Environment.NewLine;
                cadWB += "using Claro.SISACT.Entity;" + Environment.NewLine;
                cadWB += "using System.Collections;" + Environment.NewLine;
                cadWB += "using Claro.SISACT.WS.RestServices;" + Environment.NewLine;
                cadWB += "using System.Configuration;" + Environment.NewLine;
                cadWB += "using System.Web;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "    namespace Claro.SISACT.WS" + Environment.NewLine;
                cadWB += "     {" + Environment.NewLine;
                cadWB += "         public class BW"+ txtMejora.Text +" "+ Environment.NewLine;
                cadWB += "        {" + Environment.NewLine;
                cadWB += "             public BW" + txtMejora.Text + "()" + Environment.NewLine;
                cadWB += "             {" + Environment.NewLine;
                cadWB += "             }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;


                cadWB += "    /// <summary>" + Environment.NewLine;
                cadWB += "    /// " + Environment.NewLine;
                cadWB += "    /// </summary>" + Environment.NewLine;
                cadWB += "    /// <param name=\"objRequest\"></param>" + Environment.NewLine;
                cadWB += "    /// <returns></returns>" + Environment.NewLine;
                cadWB += "    public MessageResponse" + txtMejora.Text + " " + txtMessage.Text + "WS(MessageRequest" + txtMejora.Text + " objRequest)" + Environment.NewLine;
                cadWB += "    {" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "         GeneradorLog objLog = new GeneradorLog(null, string.Format(\"{0}{1}\", \"[INICIO][" + txtProyecto.Text + "][ " + txtMessage.Text + "WS]\", string.Empty), null, null);" + Environment.NewLine;
                cadWB += "         MessageResponse" + txtMejora.Text + " objResponse = new MessageResponse" + txtMejora.Text + "();" + Environment.NewLine;
                cadWB += "         BEAuditoriaRequest objAuditoria = new BEAuditoriaRequest();" + Environment.NewLine;
                cadWB += "         Hashtable datosHeader = new Hashtable();" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "     try" + Environment.NewLine;
                cadWB += "          {" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "    #region Body" + Environment.NewLine;


                for (c = 0; c < Variable_Nombre2.Count; c++)
                {

                    cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][RequestBody][" + Variable_Nombre2[c] + "]\", Funciones.CheckStr(objRequest." + txtMessage.Text + "Request." + Variable_Nombre2[c] + ")), null, null);" + Environment.NewLine;

                }
                cadWB += "" + Environment.NewLine;
                cadWB += "     #endregion" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0} : {1} | {2} : {3}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][NameKeyWS]\", objAuditoria.urlRest, \"[ValorKeyWS]\", Funciones.CheckStr(ConfigurationManager.AppSettings[\"Url" + txtMessage.Text + "WS\"])), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0} : {1} | {2} : {3}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][NameTimeOutWS]\", objAuditoria.urlTimeOut_Rest, \"[ValorTimeOutWS]\", Funciones.CheckStr(ConfigurationManager.AppSettings[\"TimeOut" + txtMessage.Text + "WS\"])), null, null);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   string strIdTransaccion = string.Empty;" + Environment.NewLine;
                cadWB += "   string strCodigoRespuesta = string.Empty;" + Environment.NewLine;
                cadWB += "   string strMensajeRespuesta = string.Empty;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   objResponse = RestServiceDPGeneral.PostInvoque<MessageResponse" + txtMejora.Text + ">(objRequest, objAuditoria);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   strIdTransaccion = Funciones.CheckStr(objResponse." + txtMessage.Text + "Response.auditResponse.idTransaccion);" + Environment.NewLine;
                cadWB += "   strCodigoRespuesta = Funciones.CheckStr(objResponse." + txtMessage.Text + "Response.auditResponse.codigoRespuesta);" + Environment.NewLine;
                cadWB += "   strMensajeRespuesta = Funciones.CheckStr(objResponse." + txtMessage.Text + "Response.auditResponse.mensajeRespuesta);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Response][strIdTransaccion]\", strIdTransaccion), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Response][strCodigoRespuesta]\", strCodigoRespuesta), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Response][strMensajeRespuesta]\", strMensajeRespuesta), null, null);" + Environment.NewLine;
                cadWB += "   objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "WS]\", string.Empty), null, null);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "     return objResponse;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "      }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "  catch (Exception ex)" + Environment.NewLine;
                cadWB += "   {" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "       objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][Ocurrio un error con el servicio]\", Funciones.CheckStr(ConfigurationManager.AppSettings[objAuditoria.urlRest])), null, null);" + Environment.NewLine;
                cadWB += "       objLog.CrearArchivolog(string.Format(\"{0} {1} | {2}\", \"[" + txtProyecto.Text + "][" + txtMessage.Text + "WS][ERROR]\", Funciones.CheckStr(ex.Message), Funciones.CheckStr(ex.StackTrace)), null, null);" + Environment.NewLine;
                cadWB += "       objLog.CrearArchivolog(string.Format(\"{0}{1}\", \"[FIN][" + txtProyecto.Text + "][" + txtMessage.Text + "WS]\", string.Empty), null, null);" + Environment.NewLine;
                cadWB += "       throw new Exception(ex.Message);" + Environment.NewLine;
                cadWB += "   }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " }" + Environment.NewLine;
                //
            }
            else{


                #region StoreProcedure
                cadWB += " public static bool Grabar" + txtMejora.Text + "(BE" + txtMejora.Text + " item" + txtMejora.Text + ")" + Environment.NewLine;
                cadWB += "  {" + Environment.NewLine;
                cadWB += "   DAABRequest.Parameter[] arrParam = {" + Environment.NewLine;
                cadWB += "		new DAABRequest.Parameter(\"K_RESULTADO\", DbType.Int32, ParameterDirection.Output)," + Environment.NewLine;


                for (c = 0; c < Variable_Nombre2.Count; c++)
                {

                    cadWB += "		new DAABRequest.Parameter(\"" + Variable_Nombre2[c] + "\", DbType." + Variable_Tipo2[c] + ", ParameterDirection.Input)," + Environment.NewLine;


                }



                cadWB += "" + Environment.NewLine;
                cadWB += "					 };" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " int i;" + Environment.NewLine;
                cadWB += " for (i = 0; i < arrParam.Length; i++)" + Environment.NewLine;
                cadWB += "    arrParam[i].Value = DBNull.Value;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                for (c = 0; c < Variable_Nombre2.Count; c++)
                {

                    cadWB += "     i = 1; arrParam[i].Value = itemCuota." + Variable_Nombre2[c] + ";" + Environment.NewLine;


                }

                cadWB += "" + Environment.NewLine;
                cadWB += "  string strCodResp = \"0\";" + Environment.NewLine;
                cadWB += "  bool salida = false;" + Environment.NewLine;
                cadWB += "  BDSISACT obj = new BDSISACT(BaseDatos.BdSisact);" + Environment.NewLine;
                cadWB += "  DAABRequest obRequest = obj.CreaRequest();" + Environment.NewLine;
                cadWB += "  obRequest.CommandType = CommandType.StoredProcedure;" + Environment.NewLine;
                cadWB += "  obRequest.Command = BaseDatos.SISACT_PKG_DRA_" + txtMejora.Text + " + \".SISACSI_INSERT_" + txtMejora.Text + "\";" + Environment.NewLine;
                cadWB += "  obRequest.Parameters.AddRange(arrParam);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " try" + Environment.NewLine;
                cadWB += " {" + Environment.NewLine;
                cadWB += "   obRequest.Factory.ExecuteNonQuery(ref obRequest);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   IDataParameter parSalida;" + Environment.NewLine;
                cadWB += "   parSalida = (IDataParameter)obRequest.Parameters[0];" + Environment.NewLine;
                cadWB += "   strCodResp = Funciones.CheckStr(parSalida.Value);" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   if (strCodResp == \"0\")" + Environment.NewLine;
                cadWB += "   {" + Environment.NewLine;
                cadWB += "   salida = true;" + Environment.NewLine;
                cadWB += "   }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " }" + Environment.NewLine;
                cadWB += " catch (Exception ex)" + Environment.NewLine;
                cadWB += " {" + Environment.NewLine;
                cadWB += "   throw ex;" + Environment.NewLine;
                cadWB += " }" + Environment.NewLine;
                cadWB += " finally" + Environment.NewLine;
                cadWB += " {" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += "   obRequest.Parameters.Clear();" + Environment.NewLine;
                cadWB += "   obRequest.Factory.Dispose();" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " }" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " return salida;" + Environment.NewLine;
                cadWB += "" + Environment.NewLine;
                cadWB += " }" + Environment.NewLine;
                #endregion

            }
            txtWB.Text = cadWB;

        }

        public void GenerarAspx() { 

         string cadaspx = string.Empty;
           cadaspx += "//  " + txtProyecto.Text + "" + Environment.NewLine;

            if (TipoService == "DataPower")
            {

                cadaspx += "  private static void " + txtMessage.Text + "( ) //tipo de variable variables" + Environment.NewLine;
                cadaspx += "   {  " + Environment.NewLine;
                cadaspx += "    BEResponseWebMethod objResponse = new BEResponseWebMethod();" + Environment.NewLine;
                cadaspx += "    GeneradorLog _objLog = new GeneradorLog(CurrentUsers, string.Empty, null, \"WEB\");" + Environment.NewLine;
                cadaspx += "  try" + Environment.NewLine;
                cadaspx += "  {" + Environment.NewLine;
                cadaspx += "   MessageResponse" + txtMejora.Text + " objResponse" + txtMejora.Text + " = new MessageResponse" + txtMejora.Text + "();" + Environment.NewLine;
                cadaspx += "   BL" + txtMejora.Text + " bl" + txtMejora.Text + " = new BL" + txtMejora.Text + "();" + Environment.NewLine;
                cadaspx += "" + Environment.NewLine;
                cadaspx += "    bl" + txtMejora.Text + "." + txtMessage + "( ref objResponse" + txtMessage.Text + "); //variables , ref objResponse" + txtMessage.Text + "" + Environment.NewLine;
                cadaspx += "   if (objResponse" + txtMejora.Text + "." + txtMessage.Text + "Response != null)" + Environment.NewLine;
                cadaspx += "   {" + Environment.NewLine;
                cadaspx += "       _objLog.CrearArchivolog(\"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage + "] [INICIO]\", null, null);" + Environment.NewLine;
                cadaspx += "       _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [Codigorespuesta]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.auditResponse.codigoRespuesta)), null, null);" + Environment.NewLine;
                cadaspx += "       _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [Idtransaccion]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.auditResponse.idTransaccion)), null, null);" + Environment.NewLine;
                cadaspx += "       _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [MensajeRespuesta]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.auditResponse.mensajeRespuesta)), null, null);" + Environment.NewLine;
                cadaspx += " " + Environment.NewLine;
                cadaspx += "       if (objResponse" + txtMejora.Text + "." + txtMejora.Text + "Response.correoCliente != null)" + Environment.NewLine;
                cadaspx += "       {" + Environment.NewLine;
                cadaspx += "           _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [CorreoCliente]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.correoCliente.correo)), null, null);" + Environment.NewLine;
                cadaspx += "       }" + Environment.NewLine;
                cadaspx += "    }" + Environment.NewLine;
                cadaspx += "  }" + Environment.NewLine;
                cadaspx += "  catch (Exception ex)" + Environment.NewLine;
                cadaspx += "  {" + Environment.NewLine;
                cadaspx += "   _objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "][Ocurrio un error con el servicio]\", Funciones.CheckStr(objResponse.Mensaje)), null, null);" + Environment.NewLine;
                cadaspx += "   _objLog.CrearArchivolog(string.Format(\"{0} {1} | {2}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "][ERROR]\", Funciones.CheckStr(ex.Message), Funciones.CheckStr(ex.StackTrace)), null , null);" + Environment.NewLine;
                cadaspx += "  }" + Environment.NewLine;
                cadaspx += " }" + Environment.NewLine;

            }
            else if (TipoService == "RestService")
            {

                cadaspx += "  private static void " + txtMessage.Text + "( ) //tipo de variable variables" + Environment.NewLine;
             cadaspx += "   {  " + Environment.NewLine;
             cadaspx += "    BEResponseWebMethod objResponse = new BEResponseWebMethod();" + Environment.NewLine;
             cadaspx += "    GeneradorLog _objLog = new GeneradorLog(CurrentUsers, string.Empty, null, \"WEB\");" + Environment.NewLine;
             cadaspx += "  try" + Environment.NewLine;
             cadaspx += "  {" + Environment.NewLine;
             cadaspx += "   MessageResponse" + txtMejora.Text + " objResponse" + txtMejora.Text + " = new MessageResponse" + txtMejora.Text + "();" + Environment.NewLine;
             cadaspx += "   BL" + txtMejora.Text + " bl" + txtMejora.Text + " = new BL" + txtMejora.Text + "();" + Environment.NewLine;
             cadaspx += "" + Environment.NewLine;
             cadaspx += "    bl" + txtMejora.Text + "." + txtMessage + "( ref objResponse" + txtMessage.Text + "); //variables , ref objResponse" + txtMessage.Text + "" + Environment.NewLine;
             cadaspx += "   if (objResponse" + txtMejora.Text + "." + txtMessage.Text + "Response != null)" + Environment.NewLine;
             cadaspx += "   {" + Environment.NewLine;
             cadaspx += "       _objLog.CrearArchivolog(\"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage + "] [INICIO]\", null, null);" + Environment.NewLine;
             cadaspx += "       _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [Codigorespuesta]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.auditResponse.codigoRespuesta)), null, null);" + Environment.NewLine;
             cadaspx += "       _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [Idtransaccion]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.auditResponse.idTransaccion)), null, null);" + Environment.NewLine;
             cadaspx += "       _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [MensajeRespuesta]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.auditResponse.mensajeRespuesta)), null, null);" + Environment.NewLine;
             cadaspx += " " + Environment.NewLine;
             cadaspx += "       if (objResponse" + txtMejora.Text + "." + txtMejora.Text + "Response.correoCliente != null)" + Environment.NewLine;
             cadaspx += "       {" + Environment.NewLine;
             cadaspx += "           _objLog.CrearArchivolog(String.Format(\"{0} --> {1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "] [CorreoCliente]\", Funciones.CheckStr(objResponseTransaccionCorreo.insertarCorreoClienteResponse.correoCliente.correo)), null, null);" + Environment.NewLine;
             cadaspx += "       }" + Environment.NewLine;
             cadaspx += "    }" + Environment.NewLine;
             cadaspx += "  }" + Environment.NewLine;
             cadaspx += "  catch (Exception ex)" + Environment.NewLine;
             cadaspx += "  {" + Environment.NewLine;
             cadaspx += "   _objLog.CrearArchivolog(string.Format(\"{0}-->{1}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "][Ocurrio un error con el servicio]\", Funciones.CheckStr(objResponse.Mensaje)), null, null);" + Environment.NewLine;
             cadaspx += "   _objLog.CrearArchivolog(string.Format(\"{0} {1} | {2}\", \"[" + txtPagina.Text + " - " + txtProyecto.Text + " - " + txtMessage.Text + "][ERROR]\", Funciones.CheckStr(ex.Message), Funciones.CheckStr(ex.StackTrace)), null , null);" + Environment.NewLine;
             cadaspx += "  }" + Environment.NewLine;
             cadaspx += " }" + Environment.NewLine;
                //

            }
            else
            {


            }

             textaspx.Text = cadaspx ;
        
        }
 
      
       

        private void btnExpBEDatos_Click(object sender, EventArgs e)
        {
            TipoService = cboService.Text;

            string Aspx = textaspx.Text;
            string Response = txtConsumo.Text;
            string Request =txtBERest.Text;
            string BL = txtBL.Text;
            string WB = txtWB.Text;
            string BEDatos = txtBEDatos.Text;
          
            if (validator == true)
            {

                if (TipoService == "DataPower")
                {
                    System.IO.File.WriteAllText(@"C:\Exportables\Aspx.txt", Aspx);
                    System.IO.File.WriteAllText(@"C:\Exportables\WB.txt", WB);
                    System.IO.File.WriteAllText(@"C:\Exportables\BL.txt", BL);
                    System.IO.File.WriteAllText(@"C:\Exportables\BEDatos.txt", BEDatos);
                    System.IO.File.WriteAllText(@"C:\Exportables\Response.txt", Response);
                    System.IO.File.WriteAllText(@"C:\Exportables\Request.txt", Request);



                    MessageBox.Show("Se generaron los archivos de Datapower correctamente", "Exito");
                }
                else if (TipoService == "RestService")
                {

                    System.IO.File.WriteAllText(@"C:\Exportables\Aspx.txt", Aspx);
                    System.IO.File.WriteAllText(@"C:\Exportables\WB.txt", WB);
                    System.IO.File.WriteAllText(@"C:\Exportables\BL.txt", BL);
                    System.IO.File.WriteAllText(@"C:\Exportables\BEDatos.txt", BEDatos);
                    System.IO.File.WriteAllText(@"C:\Exportables\Response.txt", Response);
                    System.IO.File.WriteAllText(@"C:\Exportables\Request.txt", Request);


                    MessageBox.Show("Se generaron los archivos de Rest Service correctamente", "Exito");
                }
                else {

                   // System.IO.File.WriteAllText(@"C:\Exportables\Aspx.txt", Aspx);
                    System.IO.File.WriteAllText(@"C:\Exportables\WB.txt", WB);
                    System.IO.File.WriteAllText(@"C:\Exportables\BL.txt", BL);
                    System.IO.File.WriteAllText(@"C:\Exportables\BEDatos.txt", BEDatos);
                  


                    MessageBox.Show("Se generaron los archivos de Store Procedure correctamente", "Exito");
                
                }
              

            }
            else
            {

                MessageBox.Show("No Se genero el archivo", "Completar");
            }

        }

        private void cboLimpiar_Click(object sender, EventArgs e)
        {
            textaspx.Text = "";
            txtConsumo.Text= "";
            txtBERest.Text= "";
            txtBL.Text= "";
            txtWB.Text= "";
            txtBEDatos.Text = "";
        }
      

    }
}
