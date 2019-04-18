<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ISBN.aspx.cs" Inherits="ISBN.ISBN" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        tr{
           
        }
        td{
            width:50%;
            padding-top:10px;
        }
        .button{
            width:100px;
            height:25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:100%;text-align:center;padding-top:100px;">
             <h1>Standard ISBN-10 Conversion</h1>
            <table style="width:50%; margin:auto;">
                <tr>
                    <td>
                        Product ID :
                    </td>
                    <td style="text-align:left;">
                        <asp:TextBox ID="ProductIDTextBox" runat="server" MaxLength="12" Width="150px"></asp:TextBox>
                        <asp:Label ID="LabelError" runat="server" Font-Size="XX-Small" ForeColor="Red" Text="12 digits only" Visible="False"></asp:Label>
            <br />
                    </td>
                </tr>
               
                <tr>
                    <td>
                        <asp:Label ID="LabelISBN" runat="server" Text="ISBN-10 :" Visible="False"></asp:Label>
                    &nbsp;</td>
                    <td style="text-align:left;">
                        <asp:Label ID="ISBNnum" runat="server" Visible="False"></asp:Label>
                    </td>
                </tr>
                 <tr>
                    <td style="text-align:right;padding-right:30px;">
                         <asp:Button ID="ButtonConvert" class="button" runat="server" OnClick="ButtonConvert_Click" Text="Convert" />
                    </td>
                    <td style="text-align:left;padding-left:30px;">
                        <asp:Button ID="ButtonClear" class="button" runat="server" Text="Clear" OnClick="ButtonClear_Click" />

                    </td>
                </tr>
            </table>
            
            <br />
            
        </div>
    </form>
</body>
</html>
