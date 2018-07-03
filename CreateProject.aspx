<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="CreateProject.aspx.cs" Inherits="ProjectManagmentSystem.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container" id="ProjectForm">
<form>

	<div class="form-group">
		<label class="control-label " for="name">Project Title</label>
		<asp:TextBox ID="txtProjectTitle" runat="server" class="form-control"></asp:TextBox>
	</div>
	
 	
        <div class="form-group">
        <label class="control-label" for="startdate">Start Date</label><br /><br />
                <div class='input-group date' id='datetimepicker1'>
                 <asp:TextBox ID="txtStartDate" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                    <span class="input-group-addon">                    
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
            </div>


             <div class="form-group">
        <label class="control-label" for="startdate">End Date</label><br /><br />
                <div class='input-group date' id='datetimepicker2'>
                 <asp:TextBox ID="txtEndDate" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                    <span class="input-group-addon">
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
            </div>


	<div class="form-group"> 
		<label class="control-label " for="Description">Description</label>
        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" class="form-control"></asp:TextBox>
	</div>
	



<div class="form-group"> 
<label class="control-label " for="AssignTo">Assign To:(Member)</label>
<div class="dropdown">

<asp:DropDownList ID="DropDownList1" runat="server" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
   class="btn btn-info dropdown-toggle"> </asp:DropDownList>
</div>
</div>

	

    
    <div class="form-group"> 
		<label class="control-label " for="CurrentStatus">Progress</label>
        <asp:TextBox ID="txtCurrentStatus" runat="server" class="form-control"></asp:TextBox>
	</div>


    	<div class="form-group"> 
		<label class="control-label " for="Completed">Completed</label>
        <asp:TextBox ID="txtCompleted" runat="server" class="form-control"></asp:TextBox>
	</div>


	<div class="form-group">
        <asp:Button ID="SubmitProject" runat="server" Text="Create" 
            class="btn btn-primary" name="submit" onclick="SubmitProject_Click" />
	</div>
	
</form>	

</div>



</asp:Content>
