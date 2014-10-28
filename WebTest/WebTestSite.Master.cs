using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WebApplication1
{
    public partial class WebTestSite : System.Web.UI.MasterPage
    {

        protected void Page_Init(object sender, EventArgs e)
        {
          
            List<WebApplication1.Models.Permissions.Control> controls = new List<Models.Permissions.Control>();

            EventHandler procedure =
                (objsender, obje)
                    =>
                {
                    Server.Transfer("~/Views/Registration.aspx");
                };
                

            List<WebApplication1.Models.Permissions.Control> logcontrols = new List<Models.Permissions.Control>();

            logcontrols.Add(new Models.Permissions.Control("Войти", (objsender, obje)
                    =>
                {
                    Server.Transfer("~/Views/Login.aspx");
                }));

            logcontrols.Add(new Models.Permissions.Control("Зарегистрироваться", (objsender, obje)
                    =>
                {
                    Server.Transfer("~/Views/Registration.aspx");
                }));



            foreach (WebApplication1.Models.Permissions.Control c in controls)
            {
                Button b = new Button();
                b.Text = c.Name;
                b.Style.Add("Display", "block");
                b.BackColor = System.Drawing.Color.Blue;
                b.BorderColor = System.Drawing.Color.Blue;
                b.ForeColor = System.Drawing.Color.White;
                b.Style.Add("Width", "100%");
                b.Style.Add("Margin-top", "1%");
                b.Style.Add("border-radius", "5px");
                b.Style.Add("Height", "30px");
                FindControl("rep").Controls.Add(b);
                b.Click += c.proc;
            }

            foreach (WebApplication1.Models.Permissions.Control c in logcontrols)
            {
                Button b = new Button();
                b.Text = c.Name;
                b.BackColor = System.Drawing.Color.Blue;
                b.BorderColor = System.Drawing.Color.Blue;
                b.ForeColor = System.Drawing.Color.White;
                b.Style.Add("Width", "15%");
                b.Style.Add("Height", "30px");
                b.Style.Add("Margin-left", "1%");
                b.Style.Add("border-radius", "5px");
                FindControl("log").Controls.Add(b);
                b.Click += c.proc;
            }

            HttpWebRequest request = HttpWebRequest.CreateHttp("https://api.vk.com/method/photos.get?owner_id=-77494107&album_id=profile&v=5.24");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader myStream = new StreamReader(stream);
            string JSONString = "";
            for (string line = myStream.ReadLine(); line != null; line = myStream.ReadLine())
            {
                JSONString += line;
            }

            var obj = JsonConvert.DeserializeObject<dynamic>(JSONString);
            int count = obj.response.count;
            logoIm.ImageUrl = obj.response.items[count - 1].photo_130;


        }

        protected void signin_Click(object sender, EventArgs e)
        {

        }

        
    }
}