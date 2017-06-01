<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true"
    CodeBehind="First Page.aspx.cs" Inherits="Blog.First_Page" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Left" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Right" runat="server">
    <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <div id="c-right">
                <div class="Page">
                    <h3>
                        <a href='<%#Eval("new_id","Next.aspx?id={0}") %>'target="_blank"><%#Eval("Title") %></a>
                    </h3>
                    <div class="content">
                        <p class="botime">
                            <%#Eval("AddDate") %></p>
                        <p class="bod">
                            <%#Eval("Body").ToString() %></p>
                    </div>
                    <div>
                        <div class="footer">
                            <ul>
                                <li class="readmore">浏览[<%#Eval("Click") %>]|评论[<%#Eval("Re") %>]</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
