<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm9.aspx.cs" Inherits="mini_project.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> member page </title>
    <link href="member_page.css" rel="stylesheet" />
    <script src="member_page.js"></script>

</head>
<body>
    <img src="imgs/home-bg.jpg"  style="margin:0 auto; width:100%; height:400px" />
    <form id="login" runat="server">
      <div class="main">


    <div class="login">
        <div id="showbox" runat="server" visible="false" > 
    <h2>Issue Book</h2>
        

        <asp:Label runat="server"> Username : </asp:Label>
            <br />
        <asp:Textbox ID="txtusername" runat="server" CssClass="inp">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Book ID : </asp:Label>
            <br />
        <asp:Textbox runat="server" ID="txtbID" CssClass="inp">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server">Member Name : </asp:Label>
            <br />
        <asp:Textbox runat="server" ID="txtname" CssClass="inp">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Issue date(DD-MM-YY) :</asp:Label>
            <br />
        <asp:Textbox runat="server" ID="txtdate" CssClass="inp">  </asp:Textbox>
            <br /><br />
        
        
       </div>     
             <br />
            
            
            <asp:Button CssClass="submit" runat="server" ID="btnissue" Text="Issue Book" OnClick="btnissue_Click" />
            <br />
            <br />
            <asp:Button CssClass="submit" runat="server" ID="btnreturn" Text="Return" OnClick="btnreturn_Click" />
             <br />
            <br />
            <asp:Button CssClass="submit" runat="server" ID="btninventory" Text="View Books" OnClick="btninventory_Click"  />
             <br />
            <br />       
            
            <asp:Button CssClass="submit" runat="server" ID="btnview" Text="View issues" OnClick="btnview_Click" />
            <br />
            
            <br />
            
            <br />
            <br />
        
          
         </div>    
        
    </div>
        <br />
            <br />
            <br />

         <div class="grid">
        <asp:GridView ID="GridView1" Cssclass="grdview" runat="server" AutoGenerateColumns="False"
           CellPadding="10" ForeColor="#333333" GridLines="None" DataSourceID="SqlDataSource1" CellSpacing="10" Width="50%">
             

            <Columns>
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" ItemStyle-Width="500px" ItemStyle-VerticalAlign="Top"  />
                <asp:BoundField DataField="bID" HeaderText="bID" SortExpression="bID" />
                <asp:BoundField DataField="member_name" HeaderText="member_name" SortExpression="member_name" />
                <asp:BoundField DataField="issue_date" HeaderText="issue_date" SortExpression="issue_date" />
            </Columns>
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
        </asp:GridView>
      
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbconnection %>" SelectCommand="SELECT * FROM [issue] WHERE ([username] = @username)">
                 <SelectParameters>
                     <asp:FormParameter FormField="@username" Name="username" Type="String" />
                 </SelectParameters>
             </asp:SqlDataSource>
      
       </div>
                <br />
            <br />
            <br />
            <div class="grid">
        <asp:GridView ID="GridView2" Cssclass="grdview" runat="server" AutoGenerateColumns="true"
           CellPadding="7" ForeColor="#333333" GridLines="None" >
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
        </asp:GridView>
      
       </div>


        </form>
   
    
</body>
</html>
