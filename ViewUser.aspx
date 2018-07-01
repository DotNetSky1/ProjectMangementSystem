<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="ProjectManagmentSystem.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="container">      
<input class="form-control m-t-60" id="myInput" type="text" placeholder="Search..">
  <br>  
  <table class="table table-hover  table-striped" id="tbl1">
    <thead>
      <tr>
       
        <th>Name</th>
        <th>Email</th>
        <th>Designation</th>
        <th>Department</th>
        <th>Phone</th>
        <th>Member Type</th>
        <th>Photo</th>
        <th>View Projects</th>
        <th>Delete</th>
     
     
        
      </tr>
    </thead>
    <tbody id="myTable">
   
       <asp:Label ID="tbl" runat="server" Text=""></asp:Label> 
       
    </tbody>
  </table>
</div>










</asp:Content>

