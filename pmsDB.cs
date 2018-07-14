using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProjectManagmentSystem
{
    public class pmsDB
    {
        SqlConnection mySqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

   
        //Login 
        public string Login(string UserName, string Password)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Member_tbl where Mem_id='" + UserName + "'and Mem_pwd='"+Password+"'");           
            cmd.Connection = mySqlConn;
            SqlDataReader reader = cmd.ExecuteReader();
            string output="";        
            if (reader.HasRows)
            {
                while (reader.Read())
                {                    
                    output = "1,"+reader["Mem_id"].ToString() + "," + reader["Mem_type"].ToString();                 
                }
            }
            else
            {
            output="Invalid Id or Password,0";
            }
            reader.Close();
            mySqlConn.Close();

            return output; 
        }



        #region ProjectTable(Retreive,Insert,Update,Delete)

        
        

        public DataTable GetProject_tbl() 
        {   
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select *, DATEDIFF (day,StartDate,GETDATE()) AS TotalDays from Project_tbl;", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }
        
        public DataTable GetProject_tbl(string Project_id)
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select *, DATEDIFF (day,StartDate,GETDATE()) AS TotalDays from Project_tbl where Project_id='" + Project_id + "'", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }

        public string InsertProject_tbl(string Project_Title, string StartDate, string EndDate, string Project_Description, string mem_id, string P_Complete, string Progress)
        {
            
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("insert into Project_tbl(Project_Title,StartDate,EndDate,Project_Description,Mem_id,P_Complete,Progress) VALUES('" + Project_Title + "','" + StartDate + "','" + EndDate + "','" + Project_Description + "','" + mem_id + "','" + P_Complete + "','" + Progress + "')", mySqlConn);
                        
            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch (Exception ex) {
                mySqlConn.Close();
                return ex.Message;
            }


        }

        public string UpdateProject_tbl(string Project_Title, string StartDate, string EndDate, string Project_Description, string mem_id, string CurrentStatus, string P_Complete, string Project_id)
        {
            
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("update Project_tbl set Project_Title='" + Project_Title + "',StartDate='" + StartDate + "',Project_Description='" + Project_Description + "',Mem_id='" + mem_id + "',CurrentStatus='" + CurrentStatus + "',P_Complete='" + P_Complete + "'where Project_id="+Project_id+"'", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch {
                mySqlConn.Close();
                return "0";
            }
        }

        public string DeleteProject_tbl(string Project_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("delete from Project_tbl where Project_id='" + Project_id + "'", mySqlConn);
            
            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch {
                mySqlConn.Close();
                return "0";
            }
        }

        public DataTable DropdownProject()
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select Mem_id,Mem_Name from Member_tbl", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            adap.Fill(dt);
            mySqlConn.Close();
            return dt;

        }
      
        #endregion


        #region MemberTable(Retreive,Insert,Update,Delete)
     
        public DataTable GetMember_tbl() 
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Member_tbl", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
             
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
             
        }

        public DataTable GetMember_tbl(string Mem_id)
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Member_tbl where Mem_id='"+Mem_id+"'", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }

        public string InsertMember_tbl(string Mem_Name, string Mem_Email,string Mem_Designation,string Mem_Dept,string Mem_Phone,string Mem_Pwd,string Mem_Type,string Mem_Image)
        {
            mySqlConn.Open();

            SqlCommand cmd = new SqlCommand("insert into Member_tbl (Mem_Name,Mem_Email,Mem_Designation,Mem_Dept,Mem_Phone,Mem_Pwd, Mem_Type,Mem_Image) VALUES('" + Mem_Name + "','" + Mem_Email + "','" + Mem_Designation + "','" + Mem_Dept + "','" + Mem_Phone + "','" + Mem_Pwd + "','" + Mem_Type + "','"+ Mem_Image +"')", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch (Exception e)
            {
                mySqlConn.Close();
                return e.Message.ToString();
            }
        }

        public string UpdateMember_tbl(string Mem_Name, string Mem_Email, string Mem_Designation, string Mem_Dept, string Mem_Phone, string Mem_Pwd, string Mem_Type,string Mem_id)         
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("update Member_tbl set Mem_Name='" + Mem_Name + "',Mem_Email='" + Mem_Email + "',Mem_Designation='" + Mem_Designation + "',Mem_Dept='" + Mem_Dept + "',Mem_Phone='" + Mem_Phone + "',Mem_Pwd='" + Mem_Pwd + "',Mem_Type='" + Mem_Type + "'where Mem_id=" + Mem_id + "'", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string DeleteMember_tbl(string uID)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("delete from Member_tbl where uID='" + uID + "'", mySqlConn);
            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch (Exception e)
            {
                mySqlConn.Close();
                return e.Message.ToString();
            }
        }

        //public string GetUserType(string Mem_Type)
        //{
        //    mySqlConn.Open();
        //    SqlCommand cmd = new SqlCommand("select Mem_Type from Member_tbl",mySqlConn);
            
        //    cmd.Parameters.AddWithValue("Mem_Type", Mem_Type);
        //    cmd.Connection = mySqlConn;
          
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //           Mem_Type = reader["Mem_Type"].ToString();
                   
        //        }
        //        mySqlConn.Close();
        //        return Mem_Type;
            
        //    }
        //    else {
        //        mySqlConn.Close();
        //        return "0";
        //    }
          
        //}
        //public string GetUserId(string Mem_id)
        //{
        //    mySqlConn.Open();
        //    SqlCommand cmd = new SqlCommand("select Mem_id from Member_tbl", mySqlConn);

        //    cmd.Parameters.AddWithValue("Mem_id", Mem_id);
        //    cmd.Connection = mySqlConn;

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            Mem_id = reader["Mem_id"].ToString();

        //        }
        //        mySqlConn.Close();
        //        return Mem_id;
        //    }
        //    else
        //    {
        //        mySqlConn.Close();
        //        return "0";
        //    }
        //}
        
        
        #endregion


        #region Task Table(Retrieve,Insert,Update,Delete)

        public DataTable GetTask_tbl()
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Task_tbl", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            adap.Fill(dt);
            mySqlConn.Close();
            return dt;
        }

        public DataTable GetTask_tbl(string Project_id)
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Task_tbl where Project_id='" + Project_id + "'", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }


        public DataTable GetTaskProjects(string Project_id) 
        {

            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Task_tbl where Project_id='" + Project_id + "'", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }


        public string InsertTask_tbl(string Project_id,string Mem_id,string T_Assign_Date,string Task_Detail,string DeadLine,string T_Priority)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("insert into Task_tbl (Project_id,Mem_id,T_Assign_Date,Task_Detail,DeadLine,T_Priority) VALUES('" + Project_id + "','" + Mem_id + "','" + T_Assign_Date + "','" + Task_Detail + "','" + DeadLine + "','" + T_Priority + "')", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string UpdateTask_tbl(string Project_id, string Mem_id, string T_Assign_Date, string Task_Detail, string DeadLine, string T_Priority,string Task_id) {
            
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("update Task_tbl set Project_id='" + Project_id + "',Mem_id='" + Mem_id + "',T_Assign_Date='" + T_Assign_Date + "',Task_Detail='" + Task_Detail + "',DeadLine='" + DeadLine + "',T_Priority='" + T_Priority + "'where Task_id=" + Task_id + "'", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string DeleteTask_tbl(string Task_id) {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("delete from Task_tbl where Task_id='" + Task_id + "'", mySqlConn);
            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch(Exception ex)
            {
                mySqlConn.Close();
                return ex.Message.ToString();
            }
        }

        #endregion


        #region TeamMember Table(Retrieve,Insert,Update,Delete)
        
        public string GetTeamMember_tbl()
        {       
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from TeamMember_tbl", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return "1";
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string GetTeamMember_tbl(string TeamMem_id)
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from TeamMember_tbl where TeamMem_id='" + TeamMem_id + "'", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return "1";
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string InsertTeamMember_tbl(string Project_id, string Mem_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("insert into TeamMember_tbl (Project_id,Mem_id) VALUES('" + Project_id + "','" + Mem_id + "')", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string UpdateTeamMember_tbl(string Project_id, string Mem_id, string TeamMem_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("update TeamMember_tbl set Project_id='" + Project_id + "',Mem_id='" + Mem_id + "'where TeamMem_id=" + TeamMem_id + "'", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string DeleteTeamMember_tbl(string TeamMem_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("delete from TeamMember_tbl where TeamMem_id='" + TeamMem_id + "'", mySqlConn);
            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }
        
        #endregion


        #region Communication_Log(Retrieve,Insert,Update,Delete)

        public DataTable GetCommunication_Log()
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Communication_Log", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }

        public DataTable GetCommunication_Log(string Task_id)
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Communication_Log where Task_id='" + Task_id + "'", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }

        public string InsertCommunication_Log(int Task_id,string Updatee,string Status)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("insert into Communication_Log (Task_id,Updatee,Status) VALUES('" + Task_id + "','" + Updatee + "','"+Status+"')", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string UpdateCommunication_Log(string Task_id, string Updatee, string UpdateDate, string Status,string Comm_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("update TeamMember_tbl set Task_id='" + Task_id + "',Updatee='" + Updatee + "',UpdateDate='" + UpdateDate + "',Status='"+Status+"' where Comm_id=" + Comm_id + "'", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string DeleteCommunication_Log(string Comm_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Communication_Log where Comm_id='" + Comm_id + "'", mySqlConn);
            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }

        #endregion


        #region Attachments(Retrieve,insert,Update,Delete)

        public DataTable GetAttachments()
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Attachments", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }

        public DataTable  GetAttachments(string Comm_id)
        {
            mySqlConn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from Attachments where Comm_id='" + Comm_id + "'", mySqlConn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            try
            {
                adap.Fill(dt);
                mySqlConn.Close();
                return dt;
            }
            catch (Exception)
            {
                mySqlConn.Close();
                return null;
            }
        }

        public string InsertAttachments(int Comm_id, string File_Description,string Attachment)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("insert into Attachments (Comm_id,File_Description,Attachment) VALUES('" + Comm_id + "','" + File_Description + "','"+Attachment+"')", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch (Exception ex)
            {
                mySqlConn.Close();
                return ex.Message.ToString();
            }
        }

        public string UpdateAttachments(string Comm_id, string File_Description, string Attachment, string Attachment_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("update Attachments set Comm_id='" + Comm_id + "',File_Description='" + File_Description + "',Attachment='" + Attachment + "' where Attachment_id=" + Attachment_id + "'", mySqlConn);

            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }

        public string DeleteAttachments(string Attachment_id)
        {
            mySqlConn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Attachments where Attachment_id='" + Attachment_id + "'", mySqlConn);
            try
            {
                cmd.ExecuteNonQuery();
                mySqlConn.Close();
                return "1";
            }
            catch
            {
                mySqlConn.Close();
                return "0";
            }
        }

        #endregion

    }
}    
    



