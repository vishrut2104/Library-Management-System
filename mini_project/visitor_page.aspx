<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="visitor_page.aspx.cs" Inherits="mini_project.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="visitor_page.css" rel="stylesheet" />
    <title>visitor page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <h1>Visitor Page</h1>
    <div> Welcome to our digital library. Here is a list of all the books that we have!</div>
        <br />
        <br />
    </div>
        <br />
        <br />

        <asp:GridView ID="GridView1" runat="server" Height="150px" Width="310px" AutoGenerateColumns="False">
             <EditRowStyle BackColor="#2461BF" />  
     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />  
     <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />  
     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />  
     <RowStyle BackColor="#EFF3FB" />  
     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />  
     <SortedAscendingCellStyle BackColor="#F5F7FB" />  
     <SortedAscendingHeaderStyle BackColor="#6D95E1" />  
     <SortedDescendingCellStyle BackColor="#E9EBEF" />  
     <SortedDescendingHeaderStyle BackColor="#4870BE" /> 
            <Columns>
                <asp:BoundField DataField="bauthor" HeaderText="bauthor" SortExpression="bauthor" />
                <asp:BoundField DataField="bpages" HeaderText="bpages" SortExpression="bpages" />
                <asp:BoundField DataField="bcopies" HeaderText="bcopies" SortExpression="bcopies" />
                <asp:BoundField DataField="bgenre" HeaderText="bgenre" SortExpression="bgenre" />
                <asp:BoundField DataField="ID" HeaderText="bID" ReadOnly="True" SortExpression="bID" />
                <asp:BoundField DataField="bname" HeaderText="bname" SortExpression="bname" />
            </Columns>
        </asp:GridView>
 
     
    </form>
</body>
</html>
