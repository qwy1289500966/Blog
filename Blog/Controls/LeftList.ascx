<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeftList.ascx.cs" Inherits="Blog.Controls.LeftList" %>
<h3>最 新 文 章</h3>
<div class="content">
<asp:Repeater ID="Repeater1" runat="server">
<HeaderTemplate>
    <ul class="linklist"></ul>
</HeaderTemplate>
<ItemTemplate>
    <li><a href='<%#Eval("news_id","Next.aspx?id={0}") %>'><%#Eval("Title") %></a></li>
</ItemTemplate>
<FooterTemplate></ul></FooterTemplate>
</asp:Repeater>
</div>
<h3>友 情 链 接</h3>
<div class="content">
<ul class="linklist">
<li><a href="http://cn.yahoo.com">雅虎</a></li>
<li><a href="http://www.qq.com">腾讯</a></li>
<li><a href="http://www.baidu.com">百度</a></li>
<li><a href="http://www.sina.com.cn">新浪</a></li>
</ul>
</div>