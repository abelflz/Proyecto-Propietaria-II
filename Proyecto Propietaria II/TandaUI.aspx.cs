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

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            CheckList.CheckListSoapClient selectorTanda = new
                CheckList.CheckListSoapClient ();

            if (RadioButton1.Checked)
            {
                Seleccion.Text = selectorTanda.TandaDeEstudio(Convert.ToString(RadioButton1.Text));
            }
            else if (RadioButton2.Checked)
            {
                Seleccion.Text = selectorTanda.TandaDeEstudio(Convert.ToString(RadioButton1.Text));
            }
            else {
                Seleccion.Text = selectorTanda.TandaDeEstudio(Convert.ToString(RadioButton1.Text));
            }
            
        }
    }
}