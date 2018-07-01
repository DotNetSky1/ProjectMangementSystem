using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
namespace ProjectManagmentSystem
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        pmsDB dbClass = new pmsDB();
       
        protected void Page_Load(object sender, EventArgs e)
        {

          DataTable data = dbClass.GetMember_tbl();
         string ID;
         string Name;

            foreach (DataRow row in data.Rows)
            {
                ID = row["Mem_id"].ToString();
                Name = row["Mem_Name"].ToString();
                DropDownList1.Items.Add(ID);
                DropDownList1.DataTextField = Name;
                DropDownList1.DataBind();
            }
            
        }

        protected void SubmitProject_Click(object sender, EventArgs e)
        {

            dbClass.InsertProject_tbl(txtProjectTitle.Text,txtStartDate.Text, txtEndDate.Text, txtDescription.Text, DropDownList1.SelectedItem.Value, txtCurrentStatus.Text, txtCompleted.Text);        
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}