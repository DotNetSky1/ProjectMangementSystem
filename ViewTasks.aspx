﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="ViewTasks.aspx.cs" Inherits="ProjectManagmentSystem.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




<div class="row">

  <table class="table table-hover">
  <thead>
  <tr>
  <th class="info">Project Name</th>
  <th class="danger">Project Deadline</th>
  </tr>
  </thead>
  <tbody>
<asp:Label ID="Label1" runat="server" Text=""></asp:Label>  
  </tbody>
  </table>
  </div>
    
  <br>
    <div class="box">
            
            <!-- /.box-header -->
            <div class="box-body">
              <table id="example1" class="table table-bordered table-striped table-hover">  

    <thead>
     <tr>
      <th>Project ID</th>
        <th>Member ID</th>
        <th>Task Assign Date</th>
        <th>DeadLine</th>        
        <th>Task Priority</th>
        <th>View Description</th>
        <th>Delete</th>
     </tr>
    </thead>
    <tbody>
    
        <h2>Tasks</h2>
       <asp:Label ID="lblTask" runat="server" Text=""></asp:Label> 
    
    </tbody>
  </table>
  </div></div>



</asp:Content>
