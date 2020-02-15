<%@ Page Title="" Language="C#" MasterPageFile="~/MainHead.Master" AutoEventWireup="true" CodeBehind="ClassInfo.aspx.cs" Inherits="OnlineTeaching.Class.ClassInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top:20px">
        <div style="float:right;width:300px;height:300px;text-align:center">
        <div>
            <h4 id="CName">课程名称</h4>
            <h4 id="CTeacher">任课老师</h4>
            <h4 id="CPrice">课程价格</h4>
            <h4 id="StudentSum">可报名人数</h4>
            <h4 id="StudentNum">已报名人数</h4>
            <div><asp:Button ID="btnBuy" runat="server" Text="购买课程" OnClick="btnBuy_Click" /></div>
            
            
        </div>
    </div>
     <div style="text-align:center;float:right;margin-right:80px"><asp:Image ID="CPhoto" runat="server" src="../images/20200101.png" Height="500px" ImageUrl="~/images/2_55.png" Width="500px"/></div>

    </div>
        
</asp:Content>
