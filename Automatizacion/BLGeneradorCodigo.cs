using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Automatizacion
{
    public class BLGeneradorCodigo
    {
        private static List<Variables> _listaVariables = new List<Variables>();

        public static List<Variables> ProcesarJson(string rawJson)
        {
            var res = new List<Variables>();
            _listaVariables.Clear();

            try
            {
                JObject json = JObject.Parse(rawJson);
                foreach (var propNv0 in json.Properties())
                {
                    if (propNv0.Value.Type == JTokenType.Object)
                    {
                        res = RecorrerJObject(propNv0);
                    }
                }
                return res;
            }
            catch (JsonReaderException e)
            {
                throw;
            }
        }

        public static List<Variables> RecorrerJObject(JProperty propiedadesJson, int contadorNivel = 1, bool iterandoPropieadesBody = false)
        {
            try
            {
                if (propiedadesJson.Value.Type != JTokenType.Array)
                {
                    var nuevoJson = (JObject)propiedadesJson.Value;
                    foreach (var propNivelX in nuevoJson.Properties())
                    {
                        string tipoVariableHomologado = string.Empty;
                        tipoVariableHomologado = ObtenerTipoVariableHomologada(propNivelX);

                        if (propNivelX.Value.Type == JTokenType.Object || propNivelX.Value.Type == JTokenType.Array)
                        {
                            if (propNivelX.Name != "Body" && !iterandoPropieadesBody)
                            {
                                continue;
                            }

                            if (propNivelX.Name != "Body")
                            {
                                _listaVariables.Add(new Variables(){ nombreVariable = propNivelX.Name, tipoVariable = tipoVariableHomologado, nivelVariable = contadorNivel });
                            }

                            RecorrerJObject(propNivelX, contadorNivel + 1, true);
                        }
                        else
                        {
                            _listaVariables.Add(new Variables() {nombreVariable = propNivelX.Name, tipoVariable = tipoVariableHomologado, nivelVariable = contadorNivel});
                        }
                    }
                }
                else
                {
                    JArray lista = JArray.FromObject(propiedadesJson.Value);
                    foreach (var item in lista)
                    {
                        var jToken = (JObject)item;
                        var itemparseado = jToken.Properties();
                        foreach (var item2 in itemparseado)
                        {
                            string tipoVariableHomologado = string.Empty;
                            tipoVariableHomologado = ObtenerTipoVariableHomologada(item2);
                            _listaVariables.Add(new Variables() { nombreVariable = item2.Name, tipoVariable = tipoVariableHomologado, nivelVariable = contadorNivel });
                        }
                        break;
                    }
                }
                
                return _listaVariables;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        private static string ObtenerTipoVariableHomologada(JProperty propNivelX)
        {
            string tipoVariableHomologado = String.Empty;

            switch (propNivelX.Value.Type.ToString())
            {
                case "Integer":
                    tipoVariableHomologado = "int";
                    break;
                case "Boolean":
                    tipoVariableHomologado = "bool";
                    break;
                case "Float":
                    tipoVariableHomologado = "double";
                    break;
                case "Date":
                    tipoVariableHomologado = "DateTime";
                    break;
                case "Array":
                    tipoVariableHomologado = "List";
                    break;
                default :
                    tipoVariableHomologado = propNivelX.Value.Type.ToString();
                    break;
            }
            return tipoVariableHomologado;
        }

        private static void GenerarCodigo()
        {

            string codigoRequest = string.Empty,
                codigoClaseRequest = string.Empty,
                codigoMesageRequest = string.Empty,
                codigoBodyRequest = string.Empty;
            string codigoResponse = string.Empty,
                codigoClaseResponse = string.Empty,
                codigoMesageResponse = string.Empty,
                codigoBodyResponse = string.Empty;
            try
            {
                //    #region codigosParaRequest
                //    /*Inicio Generando la Clase*/
                //    codigoClaseRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                //    codigoClaseRequest += Environment.NewLine;
                //    codigoClaseRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                //    codigoClaseRequest += "{" + Environment.NewLine;
                //    codigoClaseRequest += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoClaseRequest += "    [DataContract]" + Environment.NewLine;
                //    codigoClaseRequest += Environment.NewLine;
                //    codigoClaseRequest += "    public class " + txtNombreClaseRequest.Text + "Request" + Environment.NewLine;
                //    codigoClaseRequest += "    {" + Environment.NewLine;
                //    codigoClaseRequest += "        [DataMember(Name = \"MessageRequest\")]" + Environment.NewLine;
                //    codigoClaseRequest += "        public MessageRequest" + txtNombreClaseRequest.Text + " MessageRequest { get; set; }" + Environment.NewLine;
                //    codigoClaseRequest += "        public " + txtNombreClaseRequest.Text + "Request()" + Environment.NewLine;
                //    codigoClaseRequest += "        {" + Environment.NewLine;
                //    codigoClaseRequest += "            MessageRequest = new MessageRequest" + txtNombreClaseRequest.Text + "();" + Environment.NewLine;
                //    codigoClaseRequest += "        }" + Environment.NewLine;
                //    codigoClaseRequest += "    }" + Environment.NewLine;
                //    codigoClaseRequest += "}" + Environment.NewLine;
                //    CreacionDeArchivos(txtNombreClaseRequest.Text + "Request", codigoClaseRequest);
                //    /*Fin generar Clase*/
                //    /*Inicio Generando ClaseMesageRequest*/
                //    codigoMesageRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                //    codigoMesageRequest += Environment.NewLine;
                //    codigoMesageRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                //    codigoMesageRequest += "{" + Environment.NewLine;
                //    codigoMesageRequest += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoMesageRequest += "    [DataContract]" + Environment.NewLine;
                //    codigoMesageRequest += "    public class MessageRequest" + txtNombreClaseRequest.Text + Environment.NewLine;
                //    codigoMesageRequest += "    {" + Environment.NewLine;
                //    codigoMesageRequest += "        [DataMember(Name = \"Header\")]" + Environment.NewLine;
                //    codigoMesageRequest += "        public DataPowerRest.HeadersRequest Header { get; set; }" + Environment.NewLine;
                //    codigoMesageRequest += "        [DataMember(Name = \"Body\")]" + Environment.NewLine;
                //    codigoMesageRequest += "        public BodyRequest" + txtNombreClaseRequest.Text + " Body { get; set; }" + Environment.NewLine;
                //    codigoMesageRequest += "        public MessageRequest" + txtNombreClaseRequest.Text + "()" + Environment.NewLine;
                //    codigoMesageRequest += "        {" + Environment.NewLine;
                //    codigoMesageRequest += "            Header = new DataPowerRest.HeadersRequest();" + Environment.NewLine;
                //    codigoMesageRequest += "            Body = new BodyRequest" + txtNombreClaseRequest.Text + "();" + Environment.NewLine;
                //    codigoMesageRequest += "        }" + Environment.NewLine;
                //    codigoMesageRequest += "    }" + Environment.NewLine;
                //    codigoMesageRequest += "}" + Environment.NewLine;
                //    CreacionDeArchivos("MessageRequest" + txtNombreClaseRequest.Text, codigoMesageRequest);
                //    /*Fin Generando ClaseMesageRequest*/
                //    /*Inicio Generando Clase de los datos de primer nivel*/
                //    codigoBodyRequest += "using System.Collections.Generic;" + Environment.NewLine;
                //    codigoBodyRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                //    codigoBodyRequest += Environment.NewLine;
                //    codigoBodyRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                //    codigoBodyRequest += "{" + Environment.NewLine;
                //    codigoBodyRequest += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoBodyRequest += "    [DataContract]" + Environment.NewLine;
                //    codigoBodyRequest += "    public class BodyRequest" + txtNombreClaseRequest.Text + Environment.NewLine;
                //    codigoBodyRequest += "    {" + Environment.NewLine;
                //    foreach (DataGridViewRow row in dgvVariablesRequest.Rows)
                //    {
                //        if (row.Cells[1].Value.ToString() == "List")
                //        {
                //            nombreClaseRequestBE = "Lista" + txtNombreClaseRequest.Text;
                //            codigoBodyRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoBodyRequest += "        public List<" + row.Cells[0].Value.ToString() + ">" + row.Cells[0].Value.ToString() + "{ get; set; }" + Environment.NewLine;
                //        }
                //        else if (row.Cells[1].Value.ToString() == "Object")
                //        {
                //            nombreClaseRequestBE = "BodyRequest" + txtNombreClaseRequest.Text;
                //            codigoBodyRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoBodyRequest += "        public BE" + row.Cells[0].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                //            codigoBodyRequest += "        public BodyRequest" + txtNombreClaseRequest.Text + "()" + Environment.NewLine;
                //            codigoBodyRequest += "        {" + Environment.NewLine;
                //            codigoBodyRequest += "            " + row.Cells[0].Value.ToString() + "= new BE" + row.Cells[0].Value.ToString() + "Request();" + Environment.NewLine;
                //            codigoBodyRequest += "        }" + Environment.NewLine;
                //        }
                //        else
                //        {
                //            codigoBodyRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoBodyRequest += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                //        }
                //    }
                //    codigoBodyRequest += "    }" + Environment.NewLine;
                //    codigoBodyRequest += "}" + Environment.NewLine;
                //    CreacionDeArchivos(nombreClaseRequestBE, codigoBodyRequest);
                //    /*fin Generando Clase de los datos de primer nivel*/
                //    /*inicio Generando Clase de 2do nivel*/
                //    if (dgvVariablesListaRequest.RowCount > 0)
                //    {
                //        codigoListaRequest += "using System.Collections.Generic;" + Environment.NewLine;
                //        codigoListaRequest += "using System.Runtime.Serialization;" + Environment.NewLine;
                //        codigoListaRequest += Environment.NewLine;
                //        codigoListaRequest += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                //        codigoListaRequest += "{" + Environment.NewLine;
                //        codigoListaRequest += "    [System.Serializable()]" + Environment.NewLine;
                //        codigoListaRequest += "    [DataContract]" + Environment.NewLine;
                //        foreach (DataGridViewRow row in dgvVariablesRequest.Rows)
                //        {
                //            if (row.Cells[1].Value.ToString() == "List" || row.Cells[1].Value.ToString() == "Object")
                //            {
                //                nombreClaseListaRequestBE = "BE" + row.Cells[0].Value.ToString();
                //                codigoListaRequest += "    public class BE" + row.Cells[0].Value.ToString() + Environment.NewLine;
                //            }
                //        }
                //        codigoListaRequest += "    {" + Environment.NewLine;
                //        foreach (DataGridViewRow row in dgvVariablesListaRequest.Rows)
                //        {
                //            codigoListaRequest += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoListaRequest += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                //        }
                //        codigoListaRequest += "    }" + Environment.NewLine;
                //        codigoListaRequest += "}" + Environment.NewLine;
                //        CreacionDeArchivos(nombreClaseListaRequestBE, codigoListaRequest);
                //    }
                //    /*FIN Generando Clase de 2do nivel*/
                //    #endregion

                //    #region codigosParaResponse
                //    /*Inicio Generando la Clase*/
                //    codigoClaseResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                //    codigoClaseResponse += Environment.NewLine;
                //    codigoClaseResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoClaseResponse += "{" + Environment.NewLine;
                //    codigoClaseResponse += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoClaseResponse += "    [DataContract]" + Environment.NewLine;
                //    codigoClaseResponse += Environment.NewLine;
                //    codigoClaseResponse += "    public class " + txtNombreClaseResponse.Text + "Response" + Environment.NewLine;
                //    codigoClaseResponse += "    {" + Environment.NewLine;
                //    codigoClaseResponse += "        [DataMember(Name = \"MessageResponse\")]" + Environment.NewLine;
                //    codigoClaseResponse += "        public MessageResponse" + txtNombreClaseResponse.Text + " MessageResponse { get; set; }" + Environment.NewLine;
                //    codigoClaseResponse += "        public " + txtNombreClaseResponse.Text + "Request()" + Environment.NewLine;
                //    codigoClaseResponse += "        {" + Environment.NewLine;
                //    codigoClaseResponse += "            MessageResponse = new MessageResponse" + txtNombreClaseResponse.Text + "();" + Environment.NewLine;
                //    codigoClaseResponse += "        }" + Environment.NewLine;
                //    codigoClaseResponse += "    }" + Environment.NewLine;
                //    codigoClaseResponse += "}" + Environment.NewLine;
                //    CreacionDeArchivos(txtNombreClaseResponse.Text + "Response", codigoClaseResponse);
                //    /*Fin generar Clase*/

                //    /*Inicio Generando ClaseMesageRequest*/
                //    codigoMesageResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                //    codigoMesageResponse += Environment.NewLine;
                //    codigoMesageResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoMesageResponse += "{" + Environment.NewLine;
                //    codigoMesageResponse += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoMesageResponse += "    [DataContract]" + Environment.NewLine;
                //    codigoMesageResponse += "    public class MessageResponse" + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoMesageResponse += "    {" + Environment.NewLine;
                //    codigoMesageResponse += "        [DataMember(Name = \"Header\")]" + Environment.NewLine;
                //    codigoMesageResponse += "        public DataPowerRest.HeadersResponse Header { get; set; }" + Environment.NewLine;
                //    codigoMesageResponse += "        [DataMember(Name = \"Body\")]" + Environment.NewLine;
                //    codigoMesageResponse += "        public BodyResponse" + txtNombreClaseResponse.Text + " Body { get; set; }" + Environment.NewLine;
                //    codigoMesageResponse += "        public MessageResponse" + txtNombreClaseResponse.Text + "()" + Environment.NewLine;
                //    codigoMesageResponse += "        {" + Environment.NewLine;
                //    codigoMesageResponse += "            Header = new DataPowerRest.HeadersRequest();" + Environment.NewLine;
                //    codigoMesageResponse += "            Body = new BodyResponse" + txtNombreClaseResponse.Text + "();" + Environment.NewLine;
                //    codigoMesageResponse += "        }" + Environment.NewLine;
                //    codigoMesageResponse += "    }" + Environment.NewLine;
                //    codigoMesageResponse += "}" + Environment.NewLine;
                //    CreacionDeArchivos("MessageResponse" + txtNombreClaseResponse.Text, codigoMesageResponse);
                //    /*Fin Generando ClaseMesageRequest*/

                //    /*Inicio Generando Clase BodyResponse*/
                //    codigoBodyResponse += "using System.Collections.Generic;" + Environment.NewLine;
                //    codigoBodyResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                //    codigoBodyResponse += Environment.NewLine;
                //    codigoBodyResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBodyResponse += "{" + Environment.NewLine;
                //    codigoBodyResponse += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoBodyResponse += "    [DataContract]" + Environment.NewLine;
                //    codigoBodyResponse += "    public class BodyResponse" + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBodyResponse += "    {" + Environment.NewLine;
                //    codigoBodyResponse += "        [DataMember(Name = \"" + txtNombreClaseResponse.Text + "\")]" + Environment.NewLine;
                //    codigoBodyResponse += "        public BE" + txtNombreClaseResponse.Text + " " + txtNombreClaseResponse.Text + " { get; set; }" + Environment.NewLine;
                //    codigoBodyResponse += "        public BodyResponse" + txtNombreClaseResponse.Text + "()" + Environment.NewLine;
                //    codigoBodyResponse += "        {" + Environment.NewLine;
                //    codigoBodyResponse += "            " + txtNombreClaseResponse.Text + " = new BE" + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBodyResponse += "        }" + Environment.NewLine;
                //    codigoBodyResponse += "    }" + Environment.NewLine;
                //    codigoBodyResponse += "}" + Environment.NewLine;
                //    CreacionDeArchivos("BodyResponse" + txtNombreClaseResponse.Text, codigoBodyResponse);
                //    /*Fin Generando Clase Clase BodyResponse*/

                //    /*Inicio Generando Clase BE de Response*/
                //    codigoBeClaseResponse += "using System.Collections.Generic;" + Environment.NewLine;
                //    codigoBeClaseResponse += Environment.NewLine;
                //    codigoBeClaseResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBeClaseResponse += "{" + Environment.NewLine;
                //    codigoBeClaseResponse += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoBeClaseResponse += "    [DataContract]" + Environment.NewLine;
                //    codigoBeClaseResponse += "    public class BE" + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBeClaseResponse += "    {" + Environment.NewLine;
                //    codigoBeClaseResponse += "        [DataMember(Name = \"responseStatus\")]" + Environment.NewLine;
                //    codigoBeClaseResponse += "        public BEresponseStatus responseStatus { get; set; }" + Environment.NewLine;
                //    codigoBeClaseResponse += "        [DataMember(Name = \"responseData\")]" + Environment.NewLine;
                //    codigoBeClaseResponse += "        public BEresponseData responseData { get; set; }" + Environment.NewLine;
                //    codigoBeClaseResponse += "        public BE" + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBeClaseResponse += "        {" + Environment.NewLine;
                //    codigoBeClaseResponse += "            responseStatus = new BEresponseStatus();" + Environment.NewLine;
                //    codigoBeClaseResponse += "            responseData = new BEresponseData();" + Environment.NewLine;
                //    codigoBeClaseResponse += "        }" + Environment.NewLine;
                //    codigoBeClaseResponse += "    }" + Environment.NewLine;
                //    codigoBeClaseResponse += "}" + Environment.NewLine;
                //    CreacionDeArchivos("BE" + txtNombreClaseResponse.Text, codigoBeClaseResponse);
                //    /*Fin Generando Clase BE de Response*/

                //    /*Inicio Generando Clase BEresponseStatus*/
                //    codigoBEresponseStatus += "using System.Collections.Generic;" + Environment.NewLine;
                //    codigoBEresponseStatus += Environment.NewLine;
                //    codigoBEresponseStatus += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBEresponseStatus += "{" + Environment.NewLine;
                //    codigoBEresponseStatus += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoBEresponseStatus += "    [DataContract]" + Environment.NewLine;
                //    codigoBEresponseStatus += "    public class BEresponseStatus" + Environment.NewLine;
                //    codigoBEresponseStatus += "    {" + Environment.NewLine;
                //    codigoBEresponseStatus += "         [DataMember(Name = \"idTransaccion\")]" + Environment.NewLine;
                //    codigoBEresponseStatus += "         public string idTransaccion { get; set; }" + Environment.NewLine;
                //    codigoBEresponseStatus += "         [DataMember(Name = \"codigoRespuesta\")]" + Environment.NewLine;
                //    codigoBEresponseStatus += "         public string codigoRespuesta { get; set; }" + Environment.NewLine;
                //    codigoBEresponseStatus += "         [DataMember(Name = \"mensajeRespuesta\")]" + Environment.NewLine;
                //    codigoBEresponseStatus += "         public string mensajeRespuesta { get; set; }" + Environment.NewLine;
                //    codigoBEresponseStatus += "    }" + Environment.NewLine;
                //    codigoBEresponseStatus += "}" + Environment.NewLine;
                //    CreacionDeArchivos("BEresponseStatus", codigoBEresponseStatus);
                //    /*Fin Generando Clase BEresponseStatus*/

                //    /*Inicio Generando Clase BEresponseData*/
                //    codigoBEresponseData += "using System.Collections.Generic;" + Environment.NewLine;
                //    codigoBEresponseData += Environment.NewLine;
                //    codigoBEresponseData += "namespace Claro.SIAC.Entidades." + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoBEresponseData += "{" + Environment.NewLine;
                //    codigoBEresponseData += "    [System.Serializable()]" + Environment.NewLine;
                //    codigoBEresponseData += "    [DataContract]" + Environment.NewLine;
                //    codigoBEresponseData += "    public class BEresponseStatus" + Environment.NewLine;
                //    codigoBEresponseData += "    {" + Environment.NewLine;
                //    foreach (DataGridViewRow row in dgvVariablesResponse.Rows)
                //    {
                //        if (row.Cells[1].Value.ToString() == "List")
                //        {
                //            //nombreDataResponsetBE = "Lista" + txtNombreClaseRequest.Text;
                //            codigoBEresponseData += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoBEresponseData += "        public List<" + row.Cells[0].Value.ToString() + ">" + row.Cells[0].Value.ToString() + "{ get; set; }" + Environment.NewLine;
                //        }
                //        else if (row.Cells[1].Value.ToString() == "Object")
                //        {
                //            //nombreDataResponsetBE = "BodyRequest" + txtNombreClaseRequest.Text;
                //            codigoBEresponseData += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoBEresponseData += "        public " + row.Cells[0].Value.ToString() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                //            codigoBEresponseData += "        public BodyRequest" + txtNombreClaseRequest.Text + "()" + Environment.NewLine;
                //            codigoBEresponseData += "        {" + Environment.NewLine;
                //            codigoBEresponseData += "            " + row.Cells[0].Value.ToString() + "= new " + row.Cells[0].Value.ToString() + "Request();" + Environment.NewLine;
                //            codigoBEresponseData += "        }" + Environment.NewLine;
                //        }
                //        else
                //        {
                //            codigoBEresponseData += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoBEresponseData += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                //        }
                //    }
                //    codigoBEresponseData += "   }" + Environment.NewLine;
                //    codigoBEresponseData += "}" + Environment.NewLine;
                //    CreacionDeArchivos("BEresponseData", codigoBEresponseData);
                //    /*Fin Generando Clase BEresponseData*/

                //    /*Inicio Generando Clase BEresponseDataLista*/
                //    if (dgvVariablesListaResponse.RowCount > 0)
                //    {
                //        codigoListaResponse += "using System.Collections.Generic;" + Environment.NewLine;
                //        codigoListaResponse += "using System.Runtime.Serialization;" + Environment.NewLine;
                //        codigoListaResponse += Environment.NewLine;
                //        codigoListaResponse += "namespace Claro.SIAC.Entidades." + txtNombreClaseRequest.Text + Environment.NewLine;
                //        codigoListaResponse += "{" + Environment.NewLine;
                //        codigoListaResponse += "    [System.Serializable()]" + Environment.NewLine;
                //        codigoListaResponse += "    [DataContract]" + Environment.NewLine;
                //        foreach (DataGridViewRow row in dgvVariablesResponse.Rows)
                //        {
                //            if (row.Cells[1].Value.ToString() == "List" || row.Cells[1].Value.ToString() == "Object")
                //            {
                //                nombreClaseListaRequestBE = "BELista" + row.Cells[0].Value.ToString();
                //                codigoListaResponse += "    public class BELista" + row.Cells[0].Value.ToString() + Environment.NewLine;
                //            }
                //        }
                //        codigoListaResponse += "    {" + Environment.NewLine;
                //        foreach (DataGridViewRow row in dgvVariablesListaResponse.Rows)
                //        {
                //            codigoListaResponse += "        [DataMember(Name = \"" + row.Cells[0].Value.ToString() + "\")]" + Environment.NewLine;
                //            codigoListaResponse += "        public " + row.Cells[1].Value.ToString().ToLower() + " " + row.Cells[0].Value.ToString() + " { get; set; }" + Environment.NewLine;
                //        }
                //        codigoListaResponse += "    }" + Environment.NewLine;
                //        codigoListaResponse += "}" + Environment.NewLine;
                //        CreacionDeArchivos(nombreClaseListaRequestBE, codigoListaResponse);
                //    }
                //    /*Fin Generando Clase BEresponseDataLista*/
                //    #endregion

                //    #region codigosParaMetodoConsumo
                //    codigoMetodoConsumo += "Private Function " + txtNombreMetodo.Text + "(";
                //    foreach (DataGridViewRow row in dgvVariablesListaRequest.Rows)
                //    {
                //        codigoMetodoConsumo += " ByVal " + row.Cells[1].Value.ToString() + " As " + row.Cells[0].Value.ToString();
                //    }
                //    codigoMetodoConsumo += ") As String" + Environment.NewLine;
                //    codigoMetodoConsumo += "    log.Info(\"[Inicio: " + txtNombreMetodo.Text + "]\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "    Dim obj" + txtNombreClaseRequest.Text + "Request As New " + txtNombreClaseRequest.Text + "Carpeta." + txtNombreClaseRequest.Text + Environment.NewLine;
                //    codigoMetodoConsumo += "    Dim obj" + txtNombreClaseResponse.Text + "Request As New " + txtNombreClaseResponse.Text + "Carpeta." + txtNombreClaseResponse.Text + Environment.NewLine;
                //    codigoMetodoConsumo += "    Dim objBEAuditoriaREST As New Claro.SIAC.Entidades.BEAuditoriaRequest" + Environment.NewLine;
                //    codigoMetodoConsumo += "    Dim objHeaderRequest As New DataPowerRest.HeaderRequest" + Environment.NewLine;
                //    codigoMetodoConsumo += "    Dim objAuditRequest As New CancelarSuscripcionAsynClaroVideoRest.BEAuditRequest" + Environment.NewLine;
                //    codigoMetodoConsumo += "    Dim Aqui va la referencia del Servicio" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "    AQUI_DECLARACION_DE_VARIABLE_RESULTADO" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "    Try" + Environment.NewLine;
                //    codigoMetodoConsumo += "        Dim strUser As String = CurrentUser()" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.consumer = ConfigurationManager.AppSettings(\"consumerAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.country = ConfigurationManager.AppSettings(\"countryAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.dispositivo = ConfigurationManager.AppSettings(\"dispositivoAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.language = ConfigurationManager.AppSettings(\"languageAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.modulo = ConfigurationManager.AppSettings(\"strmoduloAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.msgType = ConfigurationManager.AppSettings(\"msgTypeAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.operation = ConfigurationManager.AppSettings(\"strOperationAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.pid = DateTime.Now.ToString(\"yyyyMMddHHmmssfff\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.system = ConfigurationManager.AppSettings(\"systemAMCO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.timestamp = DateTime.Now" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.userId = strUser" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objHeaderRequest.wsIp = GetApplicationIp()" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        obj" + txtNombreClaseRequest.Text + "MessageRequest.Header.HeaderRequest = objHeaderRequest" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        objAuditRequest.idTransaccion = DateTime.Now.ToString(\"yyyyMMddHHmmssfff\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objAuditRequest.ipAplicacion = GetApplicationIp()" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objAuditRequest.nombreAplicacion = ConfigurationManager.AppSettings(\"CodigoAplicacion\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objAuditRequest.usuarioAplicacion = CurrentUser()" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    foreach (DataGridViewRow row in dgvVariablesListaRequest.Rows)
                //    {
                //        codigoMetodoConsumo += "        obj" + txtNombreClaseRequest.Text + ".MessageRequest.Body." + row.Cells[0].Value.ToString() + " = " + row.Cells[0].Value.ToString() + Environment.NewLine;
                //    }
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        obj" + txtNombreClaseRequest.Text + ".MessageRequest.Body.auditRequest = objAuditRequest" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST = New BEAuditoriaRequest" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.idTransaccion = DateTime.Now.ToString(\"yyyyMMddHHmmss\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.ipApplication = ConfigurationManager.AppSettings(\"idtransaccionesb\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.usuarioAplicacion = SIAC_session.CodUsuario" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.nameRegEdit = \"\"" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.applicationCodeWS = ConfigurationManager.AppSettings(\"AQUI_LA_URL_DEL_SERVICIO\")" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.userId = strUser" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.idTransaccionNegocio = objHeaderRequest.pid" + Environment.NewLine;
                //    codigoMetodoConsumo += "        objBEAuditoriaREST.applicationCode = ConfigurationManager.AppSettings(\"codaplicacion\")" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        Dim Log" + txtNombreClaseRequest.Text + "Request As String = New JavaScriptSerializer().Serialize(obj" + txtNombreClaseRequest.Text + "Request)" + Environment.NewLine;
                //    codigoMetodoConsumo += "        log.Info(String.Format(\"Info Log" + txtNombreClaseRequest.Text + "Request : {0}\", Log" + txtNombreClaseRequest.Text + "Request))" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        Dim LogBEAuditoriaREST As String = New JavaScriptSerializer().Serialize(objBEAuditoriaREST)" + Environment.NewLine;
                //    codigoMetodoConsumo += "        log.Info(String.Format(\"Info LogBEAuditoriaREST: {0}\", LogBEAuditoriaREST))" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        obj" + txtNombreClaseResponse.Text + "Response = obj" + txtNombreClaseRequest.Text + ".NOMBRE_DEL_METODO(obj" + txtNombreClaseRequest.Text + "Request, objBEAuditoriaREST)" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "        Dim Log" + txtNombreClaseResponse.Text + "Response As String = New JavaScriptSerializer().Serialize(obj" + txtNombreClaseResponse.Text + "Response)" + Environment.NewLine;
                //    codigoMetodoConsumo += "        log.Info(String.Format(\"Info Log" + txtNombreClaseResponse.Text + "Request : {0}\", Log" + txtNombreClaseResponse.Text + "Response))" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "         If obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.code.Equals(\"0\") Then" + Environment.NewLine;
                //    codigoMetodoConsumo += "             log.Info(String.Format(\"[obj" + txtNombreClaseResponse.Text
                //        + "Response Header HeaderResponse]: Consumer: {0}, Pid: {1}, Status Code: {2}, Status Message: {3}, Status Msgid: {4}, Status Type: {5}, TimeStamp: {6}, VarArg: {7}\", obj"
                //        + txtNombreClaseResponse.Text + ".MessageResponse.Header.HeaderResponse.Consumer, obj"
                //        + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Pid, obj"
                //        + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.code, obj"
                //        + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.message, obj"
                //        + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.msgid, obj"
                //        + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.type, obj"
                //        + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Timestamp, obj"
                //        + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.VarArg))"
                //        + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "             If obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.codigoRespuesta.Equals(\"0\") Then" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "                 log.InfoFormat(\"info [" + txtNombreClaseResponse.Text + "]: po_coderror {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.codigoRespuesta)" + Environment.NewLine;
                //    codigoMetodoConsumo += "                 log.InfoFormat(\"info [" + txtNombreClaseResponse.Text + "]: po_msjerror {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.mensajeRespuesta)" + Environment.NewLine;
                //    codigoMetodoConsumo += "                 AQUI_DECLARACION_DE_VARIABLE_RESULTADO = obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.mensajeError.ToString()" + Environment.NewLine;
                //    codigoMetodoConsumo += "             Else" + Environment.NewLine;
                //    codigoMetodoConsumo += "                 log.ErrorFormat(\"error [" + txtNombreClaseResponse.Text + "]: {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Body.codigoRespuesta)" + Environment.NewLine;
                //    codigoMetodoConsumo += "             End If" + Environment.NewLine;
                //    codigoMetodoConsumo += "         Else" + Environment.NewLine;
                //    codigoMetodoConsumo += "             log.ErrorFormat(\"Error [" + txtNombreClaseResponse.Text + "]: {0} \", obj" + txtNombreClaseResponse.Text + "Response.MessageResponse.Header.HeaderResponse.Status.message)" + Environment.NewLine;
                //    codigoMetodoConsumo += "         End If" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "    Catch ex As Exception" + Environment.NewLine;
                //    codigoMetodoConsumo += "        log.ErrorFormat(\"Error [CancelarSuscripcionAsyn]: {0} \", ex.Message)" + Environment.NewLine;
                //    codigoMetodoConsumo += "    Finally" + Environment.NewLine;
                //    codigoMetodoConsumo += "        log.Info(\"[CancelarSuscripcionAsyn] Fin\")" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "    End Try" + Environment.NewLine;
                //    codigoMetodoConsumo += "    Return AQUI_DECLARACION_DE_VARIABLE_RESULTADO" + Environment.NewLine;
                //    codigoMetodoConsumo += Environment.NewLine;
                //    codigoMetodoConsumo += "End Function" + Environment.NewLine;
                //    #endregion
            }
            catch (Exception ex)
            {
                //    MessageBox.Show(ex.Message);
            }
            ////txtClaseRequest.Text = codigoRequest + codigoRequestLista;
            //txtClaseRequest.Text = codigoClaseRequest + Environment.NewLine + codigoMesageRequest + Environment.NewLine + codigoBodyRequest + Environment.NewLine + codigoListaRequest;
            //txtClaseResponse.Text = codigoClaseResponse + Environment.NewLine + codigoMesageResponse + Environment.NewLine + codigoBodyResponse + Environment.NewLine + codigoBeClaseResponse + Environment.NewLine + codigoListaResponse + Environment.NewLine + codigoBEresponseStatus + Environment.NewLine + codigoBEresponseData;
            //txtMetodoConsumo.Text = codigoMetodoConsumo;

        }
    }
}