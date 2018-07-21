<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="ProjectManagmentSystem.WebForm1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">






<div class="container">

<div class="row">

<div class="col-lg-6 col-md-6">
   <table style="font-family: Arial">
<tr>
    <td>
        <h5>Select Chart Type:</h5>
    </td>
    <td>
    <div class="dropdown">
  
       <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>  
  
  
  </div>
    
    
    </td>
</tr>

<tr>
    <td colspan="2">
         <div class="box box-primary">
            <div class="box-header with-border">
              <h3 class="box-title">Project Performance Chart</h3>

              <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i>
                </button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-times"></i></button>
              </div>
            </div>
            <div class="box-body">
              <div class="chart">
        <asp:Chart ID="Chart1" runat="server" Width="550px">
            <Titles>
                <asp:Title Text="Projects progress">
                </asp:Title>
            </Titles>
            <Series>
                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Column">
     
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Project Name">
                    </AxisX>
                    <AxisY Title="Total Progress">
                    </AxisY>
                    <Area3DStyle Enable3D="True" WallWidth="10"></Area3DStyle>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart></div></div></div>
    </td>
</tr>
</table>


</div>



</div>


<div class="row">
<div class="col-lg-6 col-md-6">
  <div class="panel panel-success">
    <div class="panel-heading">Send Email</div>
    <div class="panel-body">
    
  
     <div class="form-group">
    <label for="exampleInputEmailTO">To:</label>
    <asp:TextBox ID="EmailTo" class="form-control" placeholder="Enter Email" runat="server"></asp:TextBox>
  </div>
        

  <div class="form-group">
    <label for="exampleInputEmailFROM">From:</label>
    <asp:TextBox ID="Emailfrom" class="form-control" placeholder="Enter Email" runat="server"></asp:TextBox>
  </div>

  <div class="form-group">
    <label for="exampleInputEmailSUBJECT">Subject:</label>
    <asp:TextBox ID="EmailSubject" runat="server" class="form-control"  placeholder="Enter Subject"></asp:TextBox>
  </div>

  <br />
  <div class="form-group">
    
    <%--<textarea class="form-control" id="exampleFormControlTextarea1"  ></textarea>--%>
      <asp:TextBox ID="EmailBody" class="form-control" placeholder="Email Body" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
  </div>


        <asp:Button ID="Button1" runat="server" Text="Send" class="btn btn-primary" 
            onclick="Button1_Click"/>


    
    
    
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>


    
    
    
    
    </div>
  
</div>
</div>
</div>
</div>



</asp:Content>