using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using System.Web.UI.WebControls;

namespace Proyecto_Propietaria_II
{
    public partial class TandaUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            CheckList.CheckListSoapClient selectorTanda = new CheckList.CheckListSoapClient();

            if (RadioButton1.Checked)
            {

                Seleccion.Text = "Matutino";
            }
            else if (RadioButton2.Checked)
            {
                Seleccion.Text = "Mixto";
            }
            else if (RadioButton3.Checked)
            {
                Seleccion.Text = "Nocturno";
            }

        }

    }
}