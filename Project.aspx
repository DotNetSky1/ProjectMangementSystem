<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="ProjectManagmentSystem.WebForm1" %>


<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">






<div class="container">


   <table style="font-family: Arial">
<tr>
    <td>
        <b>Select Chart Type:</b>
    </td>
    <td>
    <div class="dropdown">
  <button class="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
       <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server"
            OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>  
  </button>
  
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
                <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Pie">
     
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">
                    <AxisX Title="Project Name">
                    </AxisX>
                    <AxisY Title="Total Progress">
                    </AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td>
</tr>
</table>





</div>


</asp:Content>
