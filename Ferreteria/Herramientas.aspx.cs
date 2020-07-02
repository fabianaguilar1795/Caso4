using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseDatos;
using BaseDatos.Entidades;

namespace Ferreteria
{
    public partial class Herramientas : System.Web.UI.Page
    {
        GestionBD objBD;
        List<EstadoHerramienta> estadoHerramientas;
        List<TipoHerramienta> tipoHerramientas;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                cargarcmbEstado();
                cargarcmbTipo();
            }
        }

        void cargarcmbEstado()
        {
            objBD = new GestionBD();
            estadoHerramientas = objBD.listaEstados();

            cmdIdEstado.DataSource = estadoHerramientas;
            cmdIdEstado.DataTextField = "desEstado";
            cmdIdEstado.DataValueField = "IdEstado";
            cmdIdEstado.DataBind();

            //foreach (EstadoHerramienta item in estadoHerramientas)
            //{
            //    cmdIdEstado.Items.Add(item.desEstado);
            //}
        }

        void cargarcmbTipo()
        {
            objBD = new GestionBD();
            tipoHerramientas = objBD.listaHerramienta();

            cmbcodTipo.DataSource = tipoHerramientas;
            cmbcodTipo.DataTextField = "desTipo";
            cmbcodTipo.DataValueField = "codTipo";
            cmbcodTipo.DataBind();

        }

        
        protected void BtnRegistrar_Click1(object sender, EventArgs e)
        {
            objBD = new GestionBD();
            BaseDatos.Entidades.Herramientas objHerramienta = new BaseDatos.Entidades.Herramientas();
            //objHerramienta.codHerramienta = Convert.ToString(txtidHerramienta.Text);
            objHerramienta.nomHerramienta = txtnomHerramienta.Text;

            bool resultado = objBD.registroHerramienta(objHerramienta);

            if (resultado)
            {
                //mostrar alerta de informacion
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "alert('Resgistro existoso')", true);
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "scr1", "alert('Resgistro fallo')", true);
            }
        }
    }
 }
    
