<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Picture.aspx.cs" Inherits="Lab3.Picture" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Panel ID="Panel1" runat="server" Height="779px">
            <asp:Button ID="First" runat="server" Text="首页" ForeColor="Red" OnClick="Button1_Click" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Former" runat="server" Text="上一张" OnClick="Former_Click" />
            &nbsp; &nbsp;<asp:Button ID="Next" runat="server" OnClick="Next_Click" style="margin-left: 0px" Text="下一张" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Last" runat="server" Text="尾页" ForeColor="Red" OnClick="Last_Click" style="width: 40px" />
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="图片"></asp:Label>
            <br />
            <asp:Image ID="Image1" runat="server" Height="600px" Width="800px" />
            <br />
            <br />
            <br />
            <asp:FileUpload ID="Upload" runat="server" Height="18px" Width="320px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
         
        </asp:Panel>
    </form>
</body>
</html>
