using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProjectManagmentSystem
{
    public partial class WebForm2 : System.Web.UI.Page
    {
     
        pmsDB dbClass = new pmsDB();
      
       

        protected void Page_Load(object sender, EventArgs e)
        {
      
        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
              string reply="";
              reply = dbClass.Login(TextBox1.Text, TextBox2.Text);
              string[] o = reply.Split(',');
            
            Response.Write(o[0]);
            
            if (o[0].Equals("1"))
            {
                Session["User_id"] = o[1];
                Session["User_Type"] = o[2];
                Response.Redirect("Project.aspx");
            }
           
            
        }
    }
}