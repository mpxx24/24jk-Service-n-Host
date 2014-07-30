<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_24jkClient.WebForm1" %>

<!DOCTYPE html>


<!-- scrypt #1 aka openfiledialog -->
<script runat="server">
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
            try
            {
                //to do
                //zmien na byte
                //
                FileUpload1.SaveAs("C:\\24jk\\" + 
                        FileUpload1.FileName);
                //
                //wklep to do (nowej) bd
                //
                Label1.Text = "File name: " +
                        FileUpload1.PostedFile.FileName + "<br>" +
                        FileUpload1.PostedFile.ContentLength + " kb<br>" +
                        "Content type: " +
                        FileUpload1.PostedFile.ContentType;
            }
            catch (Exception ex)
            {
                Label1.Text = "ERROR: " + ex.Message.ToString();
            }
        else
        {
            Label1.Text = "You have not specified a file.";
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 128px">
        
        <asp:FileUpload ID="FileUpload1" runat="server" />
    
        <asp:Image ID="Image1" runat="server" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
