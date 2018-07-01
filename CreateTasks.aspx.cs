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
    public partial class WebForm8 : System.Web.UI.Page
    {
        pmsDB dbClass = new pmsDB();

        protected void Page_Load(object sender, EventArgs e)
        {
           
                DataTable data = dbClass.GetProject_tbl();
                string ID;
                string Name;

                foreach (DataRow row in data.Rows)
                {
                    ID = row["Project_id"].ToString();
                    Name = row["Project_Title"].ToString();
                    ProjectDropDown.Items.Add(ID);
                    ProjectDropDown.DataBind();
                }

                DataTable data1 = dbClass.GetMember_tbl();
                string M_ID;
                string M_Name;

                foreach (DataRow row in data1.Rows)
                {
                    M_ID = row["Mem_id"].ToString();
                    M_Name = row["Mem_Name"].ToString();
                    MemberDropDown.Items.Add(M_ID);
                    MemberDropDown.DataBind();
                }

            
        }
        protected void SubmitTast_Click(object sender, EventArgs e)
        {
            dbClass.InsertTask_tbl(ProjectDropDown.SelectedItem.Value, MemberDropDown.SelectedItem.Value, txtAssignDate.Text, txtTaskDetail.Text, txtDeadline.Text, txtPriority.Text);
        }
    }
}