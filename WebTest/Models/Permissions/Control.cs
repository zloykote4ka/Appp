using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApplication1.Models.Permissions
{
    public class Control
    {
        public string Name { get; set; }
        public EventHandler proc { get; set; }

        public Control(String Name, EventHandler p)
        {
            this.proc = p;
            this.Name = Name;
        }
    }
}