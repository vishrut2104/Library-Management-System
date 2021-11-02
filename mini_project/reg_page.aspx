<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reg_page.aspx.cs" Inherits="mini_project.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <link href="reg_page.css" rel="stylesheet" />
    <script src="reg_page.js"></script>
</head>
<body>
    
    <div class="main">
    <div class="registration">
    <h2>Register Here</h2>
        <form id="register" runat="server">
        <asp:Label runat="server"> Username : </asp:Label>
            <br />
        <asp:Textbox runat="server" class="inp" ID="txtusername">  </asp:Textbox>
            <br /><br />
        <asp:Label runat="server"> Password : </asp:Label>
            <br />
        <asp:Textbox runat="server" class="inp" ID="txtpass">  </asp:Textbox>
            <br /><br />
            <asp:Label runat="server">Age : </asp:Label>
            <br />
        <asp:Textbox runat="server" CssClass="inp" ID="txtage">  </asp:Textbox>

            <br /><br />
            <asp:Label runat="server">Email Adress : </asp:Label>
            <br />

        <asp:Textbox runat="server" CssClass="inp" ID="txtemail">  </asp:Textbox>
            <br /><br />
            <asp:Label runat="server">Gender : </asp:Label>
            <br />

        <asp:DropDownList ID="txtgender" runat="server" CssClass="inp">  
                              
                            <asp:ListItem Text="Male" Value="Male"></asp:ListItem>  
                            <asp:ListItem Text="Female" Value="Female"></asp:ListItem>  
                            <asp:ListItem Text="Other" Value="Other"></asp:ListItem>  
        </asp:DropDownList>  
 
            <br /><br />
            <asp:Label runat="server">Account Type : </asp:Label>
            <br />
            
            <asp:DropDownList class="inp" runat="server" ID="txttype">  
                            <asp:ListItem Text="Member"  Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="Visitor" ></asp:ListItem>  
                            </asp:DropDownList>  

            <br />
            <br />
            <br />
            <asp:Button class="submit" runat="server" Text="Submit" OnClick="submit_Click"  />
        </form>
    </div>    
    </div>
    
</body>
</html>
