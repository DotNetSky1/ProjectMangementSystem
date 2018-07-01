using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectManagmentSystem
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        pmsDB dbclass = new pmsDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String savePath = @"C:\Users\Imran Rizvi\Desktop\images\";
            String fileName = FileUpload1.FileName;
            if (FileUpload1.HasFile)
            {
             Response.Write(savePath += fileName);
                FileUpload1.SaveAs(savePath);
            }
            dbclass.InsertMember_tbl(NameTextBox.Text, EmailTextBox.Text, DesignationTextBox.Text, DepartTextBox.Text, PhoneTextBox.Text, PasswordTextBox.Text, MemTypeTextBox.Text,fileName);

            NameTextBox.Text = "";
            EmailTextBox.Text= ""; DesignationTextBox.Text= ""; DepartTextBox.Text= ""; PhoneTextBox.Text= ""; PasswordTextBox.Text= ""; MemTypeTextBox.Text= "";
            fileName="";
        }
    }
}