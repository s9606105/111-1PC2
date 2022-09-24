using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC2
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_In = 66377;
            double d_Ou = (double)i_In * 9 / 5 + 32;
            Response.Write("攝氏 "+i_In + " 度<br>" + 
                "華氏 "+ d_Ou.ToString("0.##") + " 度");
        }
    }
}