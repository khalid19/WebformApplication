<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PeronalInformation.aspx.cs" Inherits="WebFormTest.PeronalInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 145px;
        }
        .auto-style4 {
            width: 309px;
        }
        .auto-style5 {
            height: 14px;
        }
        .auto-style6 {
            width: 309px;
            height: 14px;
        }
    </style>
    </head>
<body style="height: 301px;">
    <form id="form1" runat="server">
    <div style="width: 989px; height: 400px; border: 1px royalblue; background-color:lightcyan;">

        
    <table style="height: 190px; margin-right: 116px;">
        <tr><td class="auto-style2"></td>
            <td style="font-size: 20px;" class="auto-style4"> Personal Information</td>
            
        </tr>
       <tr>
           <td class="auto-style2">
             

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Text="First Name :"></asp:Label>
             

           </td>
           <td class="auto-style4">
               <asp:TextBox ID="firstNameTextBox" runat="server" Width="213px"></asp:TextBox>
           </td>
           
       </tr>
        <tr>
           <td class="auto-style2">
             

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label2" runat="server" Text="Last Name :"></asp:Label>
             

           </td>
           <td class="auto-style4">
               <asp:TextBox ID="lastNameTextBox" runat="server" Width="211px"></asp:TextBox>
           </td>
           
       </tr>
        <tr>
           <td class="auto-style2">
             

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" Text="Contact:"></asp:Label>
             

           </td>
           <td class="auto-style4">
               <asp:TextBox ID="contactTextBox" runat="server" Width="213px"></asp:TextBox>
           </td>
           
       </tr>
        <tr>
           <td class="auto-style2">
             

           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label4" runat="server" Text="Address :"></asp:Label>
             

           </td>
           <td class="auto-style4">
               <asp:TextBox ID="addressTextBox" runat="server" Width="213px"></asp:TextBox>
           </td>
           
       </tr>
        <tr>
            <td>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;   <asp:Label ID="Label5" runat="server" Text="Image :"></asp:Label></td>
            <td class="auto-style4">
                <asp:FileUpload ID="FileUpload1" runat="server" /></td>
        </tr>
       <tr>
           <td class="auto-style5">
               <asp:Label ID="Label6" runat="server" Text="Message"></asp:Label>
               <asp:Button ID="Button1" runat="server" Text="Button" />
           </td>
           
           <td class="auto-style6">
               <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
           
               <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" />
           
               <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" />
               
               <asp:Label ID="Label7" runat="server" Text="Search By Id :"></asp:Label>
           </td>
           <td class="auto-style5">
               <asp:TextBox ID="idTextBox" runat="server"></asp:TextBox>
               <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />

           </td>
           
       </tr>
       
       
   

     
    </table>
        <table>
            <tr>
                <td>
                    <asp:Button ID="showButton" runat="server" Text="Show In Grid View" OnClick="showButton_Click" /></td>
                </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
             
    </div>
    </form>
</body>
</html>
