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
        </asp:Chart>
    </td>
</tr>
</table>


</div>
<div class="col-lg-6 col-md-6">
<h1>Calender</h1>


</div>
</div>

</div>


</asp:Content>
