using Kpop_Ztation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kpop_Ztation.View
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../View/ArtistDetail.aspx");
        }
    }
}