using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Register.Style.Add("Width", "50%");
            Register.Style.Add("border-radius", "5px");
            Register.Style.Add("Height", "40px");
            Register.BackColor = System.Drawing.Color.Blue;
            Register.BorderColor = System.Drawing.Color.Blue;
            Register.ForeColor = System.Drawing.Color.White;
        }

        protected void VCon_Click(object sender, EventArgs e)
        {
            
        }
    }
}