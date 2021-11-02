<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inventory.aspx.cs" Inherits="mini_project.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="inventory.css" rel="stylesheet" />
    <title> book inventory </title>
    <script src="inventory.js"></script>
</head>
<body>
    <div class="main">
    <div class="inventory">
        <form id="inventory" runat="server">
    <h2>Book Inventory</h2>
        
        <asp:Label runat="server"> Book Name : </asp:Label>
            <br />
        <asp:Textbox runat="server" CssClass="inp" ID="txtbname">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Book Author : </asp:Label>
            <br />
        <asp:Textbox runat="server" ID="txtbauthor" CssClass="inp">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Book Pages : </asp:Label>
            <br />
        <asp:Textbox runat="server" ID="txtbpages" CssClass="inp">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Book Copies : </asp:Label>
            <br />
        <asp:Textbox runat="server"  ID="txtbcopies" CssClass="inp">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Book Genre : </asp:Label>
            <br />

        <asp:DropDownList ID="txtbgenre" runat="server" CssClass="inp">  
                              
                            <asp:ListItem Text="History" Value="history"></asp:ListItem>  
                            <asp:ListItem Text="Scifi" Value="scifi"></asp:ListItem>  
                            <asp:ListItem Text="Literature" Value="literature"></asp:ListItem>  
                            <asp:ListItem Text="Action and Adventure" Value="AnA"></asp:ListItem>
                            <asp:ListItem Text="Classic" Value="classic"></asp:ListItem>
                            <asp:ListItem Text="Comic" Value="comic"></asp:ListItem>
        </asp:DropDownList>
            <br /><br />
        <asp:Label runat="server"> Book ID : </asp:Label>
            <br />
        <asp:Textbox runat="server" ID="txtbID" CssClass="inp">  </asp:Textbox>
            <br /><br />

            
            <asp:Button CssClass="submit" runat="server" Text="Add Book" OnClick="add_Click" />
            <br />
            <asp:Button CssClass="submit" runat="server" ID="btndel" Text="Delete Book" OnClick="btndel_Click" />
            <br />
            
           
        </form>
    </div>    
        
    </div>
   
 
</body>
</html>
