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
    public partial class WebForm4 : System.Web.UI.Page
    {
        pmsDB dbClass = new pmsDB();

        protected void Page_Load(object sender, EventArgs e)
        {
           

                string data2 = dbClass.DeleteMember_tbl(Request.QueryString["UserId"]);


                DataTable data = dbClass.GetMember_tbl();

                string ID;
                string Name;
                string Email;
                string Designation;
                string Depart;
                string Phone;
                string MemType;
                string image;
                string uID;
                foreach (DataRow row in data.Rows)
                {

                    ID = row["Mem_id"].ToString();
                    Name = row["Mem_Name"].ToString();
                    Email = row["Mem_Email"].ToString();
                    Designation = row["Mem_Designation"].ToString();
                    Depart = row["Mem_Dept"].ToString();
                    Phone = row["Mem_Phone"].ToString();
                    MemType = row["Mem_Type"].ToString();
                    uID = row["uID"].ToString();
                    image = "<img width=100 height=100 src=/imagesz/" + row["Mem_Image"].ToString() + ">";

                    tbl.Text = tbl.Text + "<tr><td>" + Name + "</td><td>" + Email + "</td><td>" + Designation + "</td><td>" + Depart + "</td><td>" + Phone + "</td><td>" + MemType + "</td><td>" + image + "</td><td><a href='ViewProjects.aspx?UserId=" + ID + "'><span class='glyphicon glyphicon-search'></span></a> </td><td><a href='ViewUser.aspx?UserId=" + uID + "'><span class='glyphicon glyphicon-trash text-danger'></span></a></td></tr>";


                }

            }
        }        
    
    }
