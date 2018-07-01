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
    public partial class WebForm9 : System.Web.UI.Page
    {
        pmsDB dbClass = new pmsDB();


        protected void Page_Load(object sender, EventArgs e)
        {


            string data2 = dbClass.DeleteTask_tbl(Request.QueryString["TaskID"]);
            
            DataTable data = dbClass.GetTask_tbl(Request.QueryString["ProjectID"]);

            DataTable data3 = dbClass.GetProject_tbl(Request.QueryString["ProjectID"]);


            string Task_ID;
            string Project_ID;
            string Member_ID;
            DateTime Task_AssignDate;
            DateTime DeadLine;
            string Task_Description;
            string Task_Priority;
            string tID;


            string Project_Title;
            DateTime EndDate;
            string projectId;

            foreach (DataRow rows in data3.Rows)
            {
                Project_Title = rows["Project_Title"].ToString();
                EndDate = DateTime.Parse(rows["EndDate"].ToString());
                projectId = rows["Project_id"].ToString();
                Label1.Text = Label1.Text + "<tr><td>" + Project_Title + "</td><td>" + EndDate.ToShortDateString() + "</td></tr>";
            }

            foreach (DataRow row in data.Rows)
            {

                Task_ID = row["Task_id"].ToString();
                Project_ID = row["Project_id"].ToString();
                Member_ID = row["Mem_id"].ToString();

                Task_AssignDate = DateTime.Parse(row["T_Assign_Date"].ToString());
                DeadLine = DateTime.Parse(row["DeadLine"].ToString());

                Task_Description = row["Task_Detail"].ToString();
                Task_Priority = row["T_Priority"].ToString();
                tID = row["tID"].ToString();


                // lblTask.Text = lblTask.Text + "<tr><td>" + Project_ID + "</td><td>" + Member_ID + "</td><td>" + Task_AssignDate.ToShortDateString() + "</td><td>" + DeadLine.ToShortDateString() + "</td><td>" + Task_Priority + "</td><td><div class='dropdown'>  <button class='btn btn-secondary dropdown-toggle' type='button' id='dropdownMenuButton' data-toggle='dropdown'>    View Description  <span class='caret'></span> </button>  <div class='dropdown-menu'>" + Task_Description + "</div></div></td><td><a href='ViewTasks.aspx?TaskID=" + tID + "'><span class='glyphicon glyphicon-trash text-danger'></span></a></td></tr>";


                lblTask.Text = lblTask.Text + "<tr><td>" + Project_ID + "</td><td>" + Member_ID + "</td><td>" + Task_AssignDate.ToShortDateString() + "</td><td>" + DeadLine.ToShortDateString() + "</td><td>" + Task_Priority + "</td><td> <a class='btn btn-large btn-info' href='ViewTaskDescription.aspx?ProjectID=" + Project_ID + "'>View Description</a></td><td><a href='ViewTasks.aspx?TaskID=" + tID + "'><span class='glyphicon glyphicon-trash text-danger'></span></a></td></tr>";
            }
        }
    }
}