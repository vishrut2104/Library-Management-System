<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_page.aspx.cs" Inherits="mini_project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Login page </title>
    <link href="login.css" rel="stylesheet" />
    <script src="login.js"></script>
</head>
<body>
   
    <img src="imgs/home-bg.jpg"  style="margin:0 auto; width:100%; height:40%"/>
    
    <div class="main">


    <div class="login">
    <h2>Login</h2>
        <form id="login" runat="server">

        <asp:Label runat="server"> Username : </asp:Label>
            <br />
        <asp:Textbox ID="txtUname" runat="server" CssClass="inp">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Password : </asp:Label>
            <br />
        <asp:Textbox runat="server" ID="txtpass" CssClass="inp">  </asp:Textbox>
            <br /><br />
         <asp:DropDownList ID="txttype" runat="server" CssClass="inp">  
                              
                            <asp:ListItem Text="Member" Value="Member"></asp:ListItem>
                            <asp:ListItem Text="Visitor" Value="Visitor"></asp:ListItem>
                            <asp:ListItem Text="Admin" Value="Admin"></asp:ListItem>
                        
         </asp:DropDownList> 
             
            <br />
            <br />
            <asp:Button CssClass="submit" runat="server" ID="btnlogin" Text="Submit" OnClick="btnlogin_Click"  />
            <br />
            
            
           <a href="reg_page.aspx" class="reglink"> Not a member? Register here </a>
            
        </form>
    </div>    
        
    </div>
    
</body>
</html>
