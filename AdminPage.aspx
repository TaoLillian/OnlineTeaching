<%@ Page Title="" Language="C#" MasterPageFile="~/MainHead.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="OnlineTeaching.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:1000px" id="control" runat="server">
            <h4 style="text-align:left;color:navy">课程购买</h4>

            <div style="width:250px;height:250px;float:left;margin-right:20px;text-align:center">
                <div><asp:Image ID="Image1" runat="server" src="images/20200101.png" Height="200px" ImageUrl="~/images/2_55.png" Width="200px"/></div>
                <div style="margin-top:20px"><asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">一年级语文</asp:LinkButton></div>
            </div>

            <div style="width:250px;height:250px;float:left;margin-right:20px;text-align:center">
                <div><asp:Image ID="Image2" runat="server" src="images/20200102.png" Height="200px" Width="200px"/></div>
                <div style="margin-top:20px"><asp:LinkButton ID="LinkButton7" runat="server">一年级语文</asp:LinkButton></div>
            </div>

            
        </div>
    
</asp:Content>
