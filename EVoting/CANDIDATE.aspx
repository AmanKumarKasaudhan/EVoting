<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CANDIDATE.aspx.cs" Inherits="EVoting.CANDIDATE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Candidate Page</title>
    <style>
        *{
            margin:0;
            padding:0;
            box-sizing:border-box;
            
        }
        
        
    </style>
</head>
<body>
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
        <p style="margin-right:auto;margin-left:auto;text-align:center">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="Black" Text="MANAGE YOUR CANDIDATE HERE"></asp:Label>
        </p>
        <p>

            &nbsp;</p>
        <p>

            &nbsp;</p>
        <div style="margin-right:auto;margin-left:auto;text-align:center; height: 817px;">

            <asp:Label ID="Label3" runat="server" Text="Candidate ID :" Font-Names="Arial" Font-Size="Large"></asp:Label>
        &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="222px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="Label4" runat="server" Text="Name :" Font-Names="Arial" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="222px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="Label5" runat="server" Text="Age :" Font-Names="Arial" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="25px" Width="222px"></asp:TextBox>
            <br />
            <br />

            <asp:Label ID="Label7" runat="server" Text="Election ID :" Font-Names="Arial" Font-Size="Large"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="25px" Width="222px"></asp:TextBox>
            <br />
            <br />
            <br />

            

            <asp:Button ID="Button1" runat="server" BorderColor="Black" BorderStyle="Double" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Height="35px" Text="ADD" Width="147px" OnClick="Button1_Click" />

            

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BorderColor="Black" BorderStyle="Double" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Height="35px" OnClick="Button2_Click" Text="UPDATE" Width="147px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" BorderColor="Black" BorderStyle="Double" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Height="35px" OnClick="Button3_Click" Text="SELECT" Width="147px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" BorderColor="Black" BorderStyle="Double" Font-Bold="True" Font-Size="Large" Height="35px" OnClick="Button4_Click" Text="DELETE" Width="147px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
