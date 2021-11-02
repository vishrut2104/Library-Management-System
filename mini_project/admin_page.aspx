
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_page.aspx.cs" Inherits="mini_project.WebForm6" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title></title>
    <link href="new_admin_page.css" rel="stylesheet" />
    
    </head>
    <body>
        <form id="form1" runat="server">
            <img src="imgs/in-homepage-banner.jpg" style="margin:0px 0px 0px 0px; width:100%; height:40%"  />
   
        
    <div class="main">
    <div class="login">
    

    <h2>Admin Page</h2>
    <h4>Welcome <asp:Label ID="lb1"  runat="server"></asp:Label></h4>
    
        <hr />
        <br />
        <br />
        <br />
         <asp:Button CssClass="submit" runat="server" ID="btnadd" Text="Add Admin" OnClick="btnadd_Click"/>
            <br />
        <br />
        <br />
            <asp:Button CssClass="submit" runat="server" ID="btninventory" Text="Add/Delete Book" OnClick="btninventory_Click" />
            <br />
        <br />
       
            
        <br />
        <br />
        <asp:Button CssClass="submit" runat="server" ID="btnview" Text="View Inventory" OnClick="btnview_Click"  />
            <br />
         <br />
        <br />
        <asp:Button CssClass="submit" runat="server" ID="btnaccounts" Text="View Accounts" OnClick="btnaccounts_Click" />
            <br />
             </div>
   <div class="grid">

       <asp:GridView ID="grdinv" runat="server" AutoGenerateColumns="false" 
           DataKeyNames="id" OnPageIndexChanging="Grdinv_PageIndexChanging" OnRowCancelingEdit="Grdinv_RowCancelingEdit" OnRowDeleting="Grdinv_RowDeleting" 
           OnRowEditing="Grdinv_RowEditing" OnRowUpdating="Grdinv_RowUpdating">  
                   
             <Columns>  
                        
                        <asp:BoundField DataField="bauthor" HeaderText="Book author" />  
                        <asp:BoundField DataField="bpages" HeaderText="Book pages" />  
                        <asp:BoundField DataField="bcopies" HeaderText="Book copies" />  
                        <asp:BoundField DataField="bgenre" HeaderText="Book genre" />  
                        <asp:BoundField DataField="bname" HeaderText="Book name" /> 
                        <asp:BoundField DataField="ID" HeaderText="Book ID" /> 
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" /> 

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
       <asp:Label ID="ID" runat="server"></asp:Label>   
   </div>  

      
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=LAPTOP-3K3Q7FR7;Initial Catalog=accounts;Persist Security Info=True;User ID=sa;Password=sa@123" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [bauthor], [bpages], [bcopies], [bgenre], [bID], [bname] FROM [books]"></asp:SqlDataSource>
     
   <div class="grid2">


       <asp:GridView ID="grdaccount" runat="server" AutoGenerateColumns="false"
            DataKeyNames="username" OnPageIndexChanging="Gridacc_PageIndexChanging" OnRowCancelingEdit="Gridacc_RowCancelingEdit" OnRowDeleting="Gridacc_RowDeleting" 
           OnRowEditing="Gridacc_RowEditing" OnRowUpdating="Gridacc_RowUpdating">  



                    <Columns>  
                        
                        <asp:BoundField DataField="username" HeaderText="username" />  
                        <asp:BoundField DataField="password" HeaderText="password" />  
                        <asp:BoundField DataField="age" HeaderText="age" />  
                        <asp:BoundField DataField="email" HeaderText="email" />  
                        <asp:BoundField DataField="gender" HeaderText="gender" /> 
                        <asp:BoundField DataField="type" HeaderText="type" /> 
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" /> </Columns>  
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
                <asp:Label ID="username" runat="server"></asp:Label>   
            </div>  
           
                 

               
    
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=LAPTOP-3K3Q7FR7;Initial Catalog=accounts;Persist Security Info=True;User ID=sa;Password=sa@123" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [username], [password], [age], [email], [gender], [type] FROM [account_info]"></asp:SqlDataSource>
        
      
        
       </div>
    </form>
        
</body>
</html>
