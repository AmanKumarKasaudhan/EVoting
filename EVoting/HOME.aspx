<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HOME.aspx.cs" Inherits="EVoting.HOME" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        *{
            margin:0;
            padding:0;
            box-sizing:border-box;
            
        }
        body{
            background:url("images/flag.jpg");
            background-position :center;
            background-repeat: no-repeat;
            background-attachment: fixed;
            background-size: 100% 100%;
        }
        
    </style>
</head>
<body style="height: 575px;">
    <form id="form1" runat="server">
        <div style="margin-right:auto;margin-left:auto;text-align:center;background-color:aqua";">
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="VOTING PORTAL" Font-Names="Arial" ForeColor="black"></asp:Label>
            <br />
            <br />
        </div>
        <p>

            &nbsp;</p>
        <p>

            &nbsp;</p>
        <p>

            &nbsp;</p>
        <p>

            &nbsp;</p>
        <p>

            &nbsp;</p>
        <p>

            &nbsp;</p>
        <p>

            &nbsp;</p>
        <div style="background-color:white; border:0.5px solid black;height: 400px; width:610px; margin-left:auto;margin-right:auto;text-align:center">

            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label runat="server" Font-Bold="False" Font-Size="Large" Text="USERNAME " Font-Names="Arial"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Height="31px" Width="300px"></asp:TextBox>
&nbsp;<br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Size="Large" Text="PASSWORD" Font-Names="Arial"></asp:Label>
            <br />
&nbsp;<asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" TextMode="Password" Height="31px" Width="300px"></asp:TextBox>
&nbsp;<br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="blue" Font-Names="Arial" Font-Size="Large" Height="30px" Text="LOGIN" Width="104px" OnClick="Button1_Click" />

            <br />
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="* Incorrect UserName or Password" Visible="False"></asp:Label>

            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

        </div>
    </form>
    
</body>
</html>
