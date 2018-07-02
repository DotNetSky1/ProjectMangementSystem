using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Globalization;

namespace ProjectManagmentSystem
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        pmsDB dbClass = new pmsDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            
                string data1 = dbClass.DeleteProject_tbl(Request.QueryString["ProjectID"]);

                DataTable data = dbClass.GetProject_tbl(Request.QueryString["UserId"]);

                string Project_id;
                string Project_Title;
                DateTime StartDate;
                DateTime EndDate;
                string Project_Description;
                string Progress;
                string P_Complete;
                string Mem_id;
                string TotalDays;
                string pID;



                foreach (DataRow row in data.Rows)
                {
                    Project_id = row["Project_id"].ToString();
                    Project_Title = row["Project_Title"].ToString();
                    StartDate = DateTime.Parse(row["StartDate"].ToString());
                    EndDate = DateTime.Parse(row["EndDate"].ToString());
                    Project_Description = row["Project_Description"].ToString();
                    Progress = row["Progress"].ToString();
                    P_Complete = row["P_Complete"].ToString();
                    Mem_id = row["Mem_id"].ToString();
                    TotalDays = row["TotalDays"].ToString();
                    pID = row["pID"].ToString();


                    lblViewProject.Text = lblViewProject.Text + "<tr><td>" + Project_Title + "</td><td>" + StartDate.ToShortDateString() + "</td><td>" + EndDate.ToShortDateString() + "</td><td>" + TotalDays + "</td><td>" + Project_Description + "</td><td><div class='progress'><div class='progress-bar progress-bar-striped active' role='progressbar' aria-valuemin='0' aria-valuemax='100' style='width:70%'>"+ Progress+"%"+" </div></div></td><td>" + P_Complete + "</td><td>" + Mem_id + "</td><td><a href='ViewTasks.aspx?ProjectID=" + Project_id + "'><span class='glyphicon glyphicon-search'></span></a> </td> <td><a href='ViewProjects.aspx?ProjectID=" + pID + "'><span class='glyphicon glyphicon-trash text-danger'></span></a></td> </tr>";
                    
                                      
                }
            }
        }        
    }