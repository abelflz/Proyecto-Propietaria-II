using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Proyecto_Propietaria_II
{
    /// <summary>
    /// Summary description for CheckList
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CheckListM : System.Web.Services.WebService
    {

        [WebMethod]
        public string TandaDeEstudio(String tanda) {

            return tanda;
        }
    }
}
