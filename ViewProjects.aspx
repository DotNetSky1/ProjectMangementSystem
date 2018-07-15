<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="ViewProjects.aspx.cs" Inherits="ProjectManagmentSystem.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




  <br />
  <div class="box">
            
            <!-- /.box-header -->
            <div class="box-body">
              <table id="example1" class="table table-bordered table-striped table-hover">  
    <thead>
   
      
      <tr>      
        <th>Project Title</th>
        <th>Start Date</th>
        <th>DeadLine</th>        
        <th>Total Days</th>
        <th>Project Description</th>
        <th>Progress</th>
        <th>Completed</th>
        <th>Assign To</th>
        <th>View Tasks</th>
        <th>Delete</th>
      </tr>
    </thead>
    <tbody>
   <H2>Projects</H2>
       <asp:Label ID="lblViewProject" runat="server" Text=""></asp:Label> 
             
    </tbody>
  </table></div>
  </div>



 
</asp:Content>
