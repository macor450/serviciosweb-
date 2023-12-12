using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace serviciosweb
{
    /// <summary>
    /// Descripción breve de demo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class demo : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Que quiere hacer";
        }
        [WebMethod]

        public int suma(int num1, int num2)
        {
            return num1 + num2; 
        }
    }
}
