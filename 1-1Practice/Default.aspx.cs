using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_1Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            mt_GetString();
            Response.Write("<br />" + Math.Floor(1000 * 3.1415923) / 1000);
        }
    }
}