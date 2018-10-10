<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Friends.aspx.cs" Inherits="PluralSightBookWebsite.Friends" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Friends</h1>
    <p>
        You have no fiends.
    </p>
    <a href="AddFriend.aspx">Add Friend</a>
    <asp:GridView ID="GridView1" runat="server"
        SelectMethod="GridView1_GetData" DataKeyNames="Id" AutoGenerateColumns="false">
        <EmptyDataTemplate>
            <p>
                You have no friends.
            </p>
        </EmptyDataTemplate>
        <Columns>
            <asp:BoundField HeaderText="Friends Email" DataField="Email" />
            <asp:CommandField HeaderText="Remove" ButtonType="Link" ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
</asp:Content>
