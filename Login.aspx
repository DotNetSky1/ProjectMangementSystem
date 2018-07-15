<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectManagmentSystem.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-t-85 p-b-20">
				<form class="login100-form validate-form">
					<span class="login100-form-title p-b-70">
						Welcome
					</span>
					<span class="login100-form-avatar">
						<img src="images/avatar-01.jpg" alt="AVATAR">
                        
					</span>
                     <asp:Label ID="Label1" runat="server" class="m-b-80" Font-Bold="True" 
                        ForeColor="#FF3300"></asp:Label>
					<div class="wrap-input100 validate-input m-t-85 m-b-35">
						<%--<input class="input100" type="text" name="username">--%>
						
                     <%--   <input type="text" id="membershipno" value="" class="input100" style="border:1px solid black">--%>

                        <asp:TextBox ID="txtUserName"  runat="server" class="input100"></asp:TextBox>
                        <span class="focus-input100" data-placeholder=""></span>

					</div>

					<div class="wrap-input100 validate-input m-b-50" data-validate="Enter password">
				
                           <asp:TextBox ID="txtPassword" runat="server" class="input100"></asp:TextBox>
						<span class="focus-input100" data-placeholder=""></span>
					</div>

					

                    <div class="container-login100-form-btn">
						
					<asp:Button ID="Button1" class="login100-form-btn"  runat="server" Text="Login" 
                            onclick="Button1_Click" />
						<%----%>
					</div>
                <p><asp:CheckBox ID="CheckBoxRemember" runat="server" /> Remeber me!</p>
                <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Red"></asp:Label>
				</form>
			</div>
		</div>
	</div>
    <div id="div2"></div>
</asp:Content>
