using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Proyecto_Propietaria_II.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost, ActionName("Index")]
        public ActionResult IndexPost(string UserName, string Password)
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                ViewBag.User = "Debe llenar todos los campos";
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=ABEL-PC;Initial Catalog=Banking;Integrated Security=True";
                    con.Open();

                    string query = "select COUNT(Cedula_usuario) from USUARIO where Usuario = @a and Clave = @b";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@a", UserName));
                    cmd.Parameters.Add(new SqlParameter("@b", Password));

                    int verificar = Convert.ToInt32(cmd.ExecuteScalar());

                    if (verificar == 1)
                    {
                        con.Close();
                        return View("");
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
                        {
                            return View("~/Views/Shared/Error.cshtml");
                        }
                    }
                }
                catch (Exception)
                {
                    return View("~/Views/Shared/Error.cshtml");
                }
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ADO.NET Stuff
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}