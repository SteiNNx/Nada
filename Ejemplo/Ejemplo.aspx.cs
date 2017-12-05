using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo
{
    public partial class Ejemplo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rp_padre.DataSource = cargarDatos();
            rp_padre.DataBind();
            
        }

        public List<model.CL_Ejemplo> cargarDatos()
        {
            List<model.CL_Ejemplo> listaEjemplo = new List<model.CL_Ejemplo>();
            #region objetosEjemplo
            model.CL_Ejemplo ejemplo1 = new model.CL_Ejemplo();
            ejemplo1.id = 106;
            ejemplo1.idSubtipo = 28;
            ejemplo1.texto = "Actaulizar contenido en pharos";
            ejemplo1.profundidad = 1;

            model.CL_Ejemplo ejemplo2 = new model.CL_Ejemplo();
            ejemplo2.id = 107;
            ejemplo2.idSubtipo = 28;
            ejemplo2.texto = "publicar not en pharos";
            ejemplo2.profundidad = 1;

            model.CL_Ejemplo ejemplo3 = new model.CL_Ejemplo();
            ejemplo3.id = 483;
            ejemplo3.idSubtipo = 106;
            ejemplo3.texto = "derivar en pharos";
            ejemplo3.profundidad = 2;

            model.CL_Ejemplo ejemplo4 = new model.CL_Ejemplo();
            ejemplo4.id = 484;
            ejemplo4.idSubtipo = 106;
            ejemplo4.texto = "actualizar en pharos";
            ejemplo4.profundidad = 2;

            model.CL_Ejemplo ejemplo5 = new model.CL_Ejemplo();
            ejemplo5.id = 485;
            ejemplo5.idSubtipo = 106;
            ejemplo5.texto = "derivar en pharos";
            ejemplo5.profundidad = 2;

            model.CL_Ejemplo ejemplo6 = new model.CL_Ejemplo();
            ejemplo6.id = 486;
            ejemplo6.idSubtipo = 106;
            ejemplo6.texto = ".derivar cliente en pharos";
            ejemplo6.profundidad = 2;

            model.CL_Ejemplo ejemplo7 = new model.CL_Ejemplo();
            ejemplo7.id = 487;
            ejemplo7.idSubtipo = 107;
            ejemplo7.texto = "crear propuesta en pharos";
            ejemplo7.profundidad = 2;

            model.CL_Ejemplo ejemplo8 = new model.CL_Ejemplo();
            ejemplo8.id = 488;
            ejemplo8.idSubtipo = 107;
            ejemplo8.texto = "Valdiar ortogra propuesta en pharos";
            ejemplo8.profundidad = 2;

            model.CL_Ejemplo ejemplo9 = new model.CL_Ejemplo();
            ejemplo9.id = 488;
            ejemplo9.idSubtipo = 107;
            ejemplo9.texto = "ajustar propuesta en pharos";
            ejemplo9.profundidad = 2;

            model.CL_Ejemplo ejemplo10 = new model.CL_Ejemplo();
            ejemplo10.id = 489;
            ejemplo10.idSubtipo = 107;
            ejemplo10.texto = "crear propuesta validar en pharos";
            ejemplo10.profundidad = 2;

            listaEjemplo.Add(ejemplo1);
            listaEjemplo.Add(ejemplo2);
            listaEjemplo.Add(ejemplo3);
            listaEjemplo.Add(ejemplo4);
            listaEjemplo.Add(ejemplo5);
            listaEjemplo.Add(ejemplo6);
            listaEjemplo.Add(ejemplo7);
            listaEjemplo.Add(ejemplo8);
            listaEjemplo.Add(ejemplo9);
            listaEjemplo.Add(ejemplo10);

            #endregion poblarLista

            return listaEjemplo;
        }

        protected void rp_padre_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //Repeater repeater =(Repeater) e.Item.FindControl("rp_padre");
            //var l_datos = cargarDatos().Where(x => x.profundidad ==?);

            //rp_hijo.DataSource = l_datos.ToList();
            //rp_hijo.DataBind();
        }
    }
}