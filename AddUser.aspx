<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="ProjectManagmentSystem.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form>
		<h2>Create User</h2><br />
		<%--<p class="hint-text">Create your account. It's free and only takes a minute.</p>--%>
        <div class="form-group">
		<div class="input-group">
				<span class="input-group-addon"><i class="fa fa-user"></i></span>	
		<%--<input type="text" class="form-control" name="first_name" placeholder="Name" required="required">--%>
            <asp:TextBox ID="NameTextBox" runat="server" class="form-control" name="first_name" placeholder="Name" required="required"></asp:TextBox>
				<%--<div class="col-xs-6"><input type="text" class="form-control" name="last_name" placeholder="Last Name" required="required"></div>--%>
			     </div>  	
        </div>
        
        <div class="form-group">
        	<%--<input type="email" class="form-control" name="email" placeholder="Email" required="required">--%>
            <div class="input-group">
				<span class="input-group-addon"><i class="fa fa-paper-plane"></i></span>
            <asp:TextBox ID="EmailTextBox" runat="server" class="form-control" name="email" 
                placeholder="Email" required="required" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        </div>
		</div>
        <div class="form-group">
          <div class="input-group">
				<span class="input-group-addon"><i class="fa fa-lock"></i></span>
           <%-- <input type="password" class="form-control" name="password" placeholder="Password" required="required">--%>
            <asp:TextBox ID="PasswordTextBox" runat="server" class="form-control" name="password" placeholder="Password" required="required"></asp:TextBox>
        </div>
		</div>

        <div class="form-group">
        <div class="input-group">
				<span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
         <%--   <input type="text" class="form-control" name="Mem_Designation" placeholder="Designation" required="required">--%>
            <asp:TextBox ID="DesignationTextBox" runat="server" class="form-control" name="Mem_Designation" placeholder="Designation" required="required"></asp:TextBox>
        </div>    
        </div>
        
        <div class="form-group">
        <div class="input-group">
				<span class="input-group-addon"><i class="glyphicon glyphicon-home"></i></span>
            <%--<input type="text" class="form-control" name="Mem_Dept" placeholder="Department" required="required">--%>
            <asp:TextBox ID="DepartTextBox" runat="server" class="form-control" name="Mem_Dept" placeholder="Department" required="required"></asp:TextBox>
        </div>    
        </div>
         
         
         <div class="form-group">
         <div class="input-group">
				<span class="input-group-addon"><i class="glyphicon glyphicon-earphone"></i></span>
            <%--<input type="text" class="form-control" name="Mem_Phone" placeholder="Phone" required="required">--%>
            <asp:TextBox ID="PhoneTextBox" runat="server" class="form-control" name="Mem_Phone" placeholder="Phone" required="required"></asp:TextBox>
        </div>
        </div>
            
             <div class="form-group">
         <div class="input-group">
				<span class="input-group-addon"><i class="glyphicon glyphicon-king"></i></span>
            <%--<input type="text" class="form-control" name="Mem_Phone" placeholder="Phone" required="required">--%>
            <asp:TextBox ID="MemTypeTextBox" runat="server" class="form-control" name="Mem_Type" placeholder="Member Type" required="required"></asp:TextBox>
        </div>
        </div>



     <div class="form-group">            
        <asp:FileUpload ID="FileUpload1" runat="server" /> <br />
             </div>

       <%-- <div class="form-group">
		<label class="checkbox-inline"><input type="checkbox" required="required"> I accept the <a href="#">Terms of Use</a> &amp; <a href="#">Privacy Policy</a></label>
		</div>--%>

		<div class="form-group">            
            <asp:Button ID="Add" runat="server" Text="Add User" 
                class="btn btn-success btn-lg btn-block" onclick="Button1_Click"/>
            </form>

</div>





</asp:Content>
