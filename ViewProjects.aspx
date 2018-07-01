<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="ViewProjects.aspx.cs" Inherits="ProjectManagmentSystem.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="container">        
 <input class="form-control m-t-60" id="myInput" type="text" placeholder="Search.." >
  <br />
  <table class="table table-hover  table-striped">
    <thead>
   
      
      <tr>      
        <th>Project Title</th>
        <th>Start Date</th>
        <th>DeadLine</th>        
        <th>Total Days</th>
        <th>Project Description</th>
        <th>Current Status</th>
        <th>Completed</th>
        <th>Assign To</th>
        <th>View Tasks</th>
        <th>Delete</th>
      </tr>
    </thead>
    <tbody id="myTable">
   <H2>Projects</H2>
       <asp:Label ID="lblViewProject" runat="server" Text=""></asp:Label> 
             
    </tbody>
  </table>

</div>
 
</asp:Content>
