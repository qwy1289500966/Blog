<%@ Page Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Blog.aspx.cs"
    Inherits="Blog.Blog" %>

<asp:Content ID="Content3" ContentPlaceHolderID="Right" runat="server">
    <asp:Repeater ID="Repeater1" runat="server" 
        onitemcommand="Repeater1_ItemCommand">
        <ItemTemplate>
            <div class="Page">
                <h3>
                    <a href='<%#Eval("news_id","Next.aspx?id={0})")%>' target="_blank">
                        <%#Eval("Title") %></a>
                </h3>
                <p class="bottime">
                    <%#Eval("AddDate") %></p>
                <p class="bod" <%#BindBody(Eval("Body").ToString()) %>>
                </p>
                <p class="show">浏览[<%#Eval("Click") %>]|评论<%#Eval("Re") %></p><br />
            </div>
        </ItemTemplate>
    </asp:Repeater><br />
    共<asp:Label ID="lb_page" runat="server" Text="Label"></asp:Label>页
    当前第<asp:Label ID="lb_currentpage" runat="server" Text="1"></asp:Label>页
    <asp:LinkButton ID="lbtn_frist" runat="server" onclick="lbtn_frist_Click">首页</asp:LinkButton>
    <asp:LinkButton ID="lbtn_up" runat="server" onclick="lbtn_up_Click">上一页</asp:LinkButton>
    <asp:LinkButton ID="lbtn_down" runat="server" onclick="lbtn_down_Click">下一页</asp:LinkButton>
    <asp:LinkButton ID="lbtn_last" runat="server" onclick="lbtn_last_Click">尾页</asp:LinkButton>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
</asp:Content>
