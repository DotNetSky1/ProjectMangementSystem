<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="ProjectManagmentSystem.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<%--
<input class="form-control m-t-60" id="myInput" type="text" placeholder="Search..">--%>
  <br>  
 <%-- <table class="table table-hover  table-striped" id="tbl1">--%>
            <div class="box">
            <div class="box-header">
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <table id="example1" class="table table-bordered table-striped table-hover">
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
    <%--<tbody id="myTable">--%>
   <tbody>
       <asp:Label ID="tbl" runat="server" Text=""></asp:Label>  
    </tbody>
    </table>
    </div>
    </div>
  











</asp:Content>

