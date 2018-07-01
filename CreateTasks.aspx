<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="CreateTasks.aspx.cs" Inherits="ProjectManagmentSystem.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<div class="container m-t-99">
<form>
     	
        <div class="form-group">
		<label class="control-label " for="name">Task Description</label>
        <asp:TextBox ID="txtTaskDetail" runat="server" class="form-control"></asp:TextBox>
        </div>

        
        <div class="form-group">
        <label class="control-label" for="AssignDate">Assign Date</label><br /><br />
                <div class='input-group date' id='datetimepicker1'>
                 <asp:TextBox ID="txtAssignDate" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                    <span class="input-group-addon">                    
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
            </div>


        <div class="form-group">
        <label class="control-label" for="Deadline">Deadline</label><br /><br />
                <div class='input-group date' id='datetimepicker2'>
                 <asp:TextBox ID="txtDeadline" runat="server" CssClass="form-control" type="date"></asp:TextBox>
                    <span class="input-group-addon">                    
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
            </div>




         <div class="form-group">
		<label class="control-label " for="name">Task Priority</label>
        <asp:TextBox ID="txtPriority" runat="server" class="form-control"></asp:TextBox>
        </div>

<div class="form=group">
<label class="control-label " for="Projectlist">Project Name</label>
<div class="dropdown">
<asp:DropDownList ID="ProjectDropDown" runat="server" class="btn btn-info dropdown-toggle">
</asp:DropDownList>
</div></div>

<div class="form=group">
<label class="control-label " for="Projectlist">Member Name</label>
<div class="dropdown">
<asp:DropDownList ID="MemberDropDown" runat="server" class="btn btn-info dropdown-toggle">
</asp:DropDownList>
</div></div>

<br />
<div class="form-group">

    <asp:Button ID="SubmitTast" runat="server" Text="Create Task" 
        class="btn btn-primary" onclick="SubmitTast_Click"/>
</div>

</form>
</div>


</asp:Content>
