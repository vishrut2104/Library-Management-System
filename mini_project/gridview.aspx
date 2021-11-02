<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gridview.aspx.cs" Inherits="mini_project.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div>
       
        <div class="grdview">
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        
                        <asp:BoundField DataField="bauthor" HeaderText="Book author" />  
                        <asp:BoundField DataField="bpages" HeaderText="Book pages" />  
                        <asp:BoundField DataField="bcopies" HeaderText="Book copies" />  
                        <asp:BoundField DataField="bgenre" HeaderText="Book genre" />  
                        <asp:BoundField DataField="bname" HeaderText="Book name" /> 
                        <asp:BoundField DataField="ID" HeaderText="Book ID" /> 
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" /> </Columns>  
                </asp:GridView>  
            </div>  
            <div>  
                <asp:Label ID="ID" runat="server"></asp:Label>  

               
    
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=LAPTOP-3K3Q7FR7;Initial Catalog=accounts;Persist Security Info=True;User ID=sa;Password=sa@123" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [bauthor], [bpages], [bcopies], [bgenre], [ID], [bname] FROM [books]"></asp:SqlDataSource>
        
       </div>
  
    
    </div>
    </form>
</body>
</html>
