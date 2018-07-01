using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace ProjectManagmentSystem
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        pmsDB dbClass = new pmsDB();


        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable dts = dbClass.GetCommunication_Log();
            DataView dv2 = new DataView(dts);
            Repeater1.DataSource = dv2;
            Repeater1.DataBind();

            DataTable data = dbClass.GetTask_tbl(Request.QueryString["ProjectID"]);

            string Task_Description;
            DateTime Task_AssignDate;
            DateTime DeadLine;
            string Tid;




            foreach (DataRow row2 in dts.Rows)
            {
                
                CommunicationLog.Text = CommunicationLog.Text + " (" + Session["User_Type"] + ")" + "<br>";
                CommunicationLog.Text = CommunicationLog.Text + row2["UpdateDate"].ToString() + "<br>" + row2["Updatee"].ToString() + "<br>" + "<hr>";
                DataTable dt2 = dbClass.GetAttachments(row2["Comm_id"].ToString());

                foreach (DataRow row3 in dt2.Rows)
                {
                    CommunicationLog.Text = CommunicationLog.Text + "<a href=Attachments\\" + row3["Attachment"].ToString() + ">" + row3["Attachment"].ToString() + "</a><br>";
                }
                CommunicationLog.Text = CommunicationLog.Text + "<a class='btn btn-primary pull-right' href='AddMoreAttach.aspx'>Add More Attachments</a>" + "<br>";
            }


            foreach (DataRow row in data.Rows)
            {

                Tid = row["tID"].ToString();
                Task_Description = row["Task_Detail"].ToString();
                Task_AssignDate = DateTime.Parse(row["T_Assign_Date"].ToString());
                DeadLine = DateTime.Parse(row["DeadLine"].ToString());

                TxtDescription.Text += Task_Description;
                txtAssignDates.Text = Task_AssignDate.ToShortDateString();
                txtDeadLine.Text = DeadLine.ToShortDateString();

            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {

            String savePath = @"E:\ProjectManagmentSystem\ProjectManagmentSystem\Attachments\";
            String fileName = txtAnyFile.FileName;
            if (txtAnyFile.HasFile)
            {
                Response.Write(savePath += fileName);
                txtAnyFile.SaveAs(savePath);
            }
            dbClass.InsertAttachments(20, TxtFileDesc.Text, fileName);
        }



        protected void btnPost_Click(object sender, EventArgs e)
        {
            dbClass.InsertCommunication_Log(1, txtPostQuestion.Text, "okay");
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

    }
}