<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true"
    CodeBehind="ViewTaskDescription.aspx.cs" Inherits="ProjectManagmentSystem.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br />
        <br />
        <table class="table">
            <tr>
                <td>
                    <p>
                        <b>Tasks Description: </b>
                        <asp:Label ID="TxtDescription" runat="server" Text=""></asp:Label></p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        <b>Assign Date: </b>
                        <asp:Label ID="txtAssignDates" runat="server" Text=""></asp:Label></p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        <b>Deadline Date: </b>
                        <asp:Label ID="txtDeadLine" runat="server" Text=""></asp:Label></p>
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        <b>Add Attachment: </b>
                    </p>
                    <asp:FileUpload ID="txtAnyFile" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <p>
                        <b>File Description:</b></p>
                    <asp:TextBox ID="TxtFileDesc" runat="server" BorderWidth="1px" TextMode="MultiLine"
                        Rows="2" Width="300px"></asp:TextBox>
                    <br />
                    <asp:Button ID="btnUpload" runat="server" Text="Upload" type="button" class="btn btn-info custom"
                        OnClick="btnUpload_Click" />
                </td>
            </tr>
        </table>
    </div>
    <br />
    <div class="container">
        <div class="row bootstrap snippets">
            <div class="col-md-6 col-lg-12 col-sm-12">
                <div class="comment-wrapper">
                    <div class="panel panel-danger">
                        <div class="panel-heading">
                            Communication Log
                        </div>
                        <div class="panel-body">
                            <asp:TextBox ID="txtPostQuestion" runat="server" TextMode="MultiLine" Rows="3" class="form-control"
                                placeholder="Write a Question..."></asp:TextBox>
                            <br>
                            <asp:Button ID="btnPost" runat="server" Text="Post" type="button" class="btn btn-info pull-right"
                                OnClick="btnPost_Click" />
                            <div class="clearfix">
                            </div>
                            <hr>
                            <asp:Label ID="CommunicationLog" runat="server" Font-Bold="True"></asp:Label>
                            <asp:FileUpload ID="FileUploadComm" runat="server" Multiple="Multiple" />
                            <asp:Button ID="btnUplaod"  runat="server" Text="Upload" type="button" class="btn btn-info custom"  /><br />
                            <hr />
                            
                            <!---
                            <asp:Repeater ID="Repeater1" runat="server" 
                                onitemcommand="Repeater1_ItemCommand">
                                <ItemTemplate>
                                  <b>  <div runat="server" innerText='<%#Eval("Updatee") %>'></div> </b><br />
                                    <asp:FileUpload ID="fu" runat="server" style="float:right"/><br />
                                     <asp:Button ID="btn"  CommandName="buy" runat="server" Text="Add" type="button" class="btn btn-info custom"   />
                                    <hr />
                                </ItemTemplate>           
                            </asp:Repeater>
                            --->
                             
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
