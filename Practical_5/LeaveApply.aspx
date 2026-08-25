<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="LeaveApply.aspx.cs"
    Inherits="Practical_5.LeaveApply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>
</head>

<body>
    <form id="form1" runat="server">

        <h2>Leave Application</h2>

        <asp:Label ID="lblEmployeeName" runat="server"
            Text="Employee Name: ">
        </asp:Label>

        <asp:TextBox ID="txtEmployeeName" runat="server">
        </asp:TextBox>

        <br />
        <br />

        <asp:Label ID="lblLeaveDateTitle" runat="server"
            Text="Leave Date: ">
        </asp:Label>

        <asp:Label ID="lblLeaveDate" runat="server"
            Text="">
        </asp:Label>

        <br />
        <br />

        <asp:Label ID="lblLeaveType" runat="server"
            Text="Leave Type: ">
        </asp:Label>

        <asp:DropDownList ID="ddlLeaveType" runat="server">
            <asp:ListItem Text="Medical Leave" Value="Medical Leave"></asp:ListItem>
            <asp:ListItem Text="Personal Leave" Value="Personal Leave"></asp:ListItem>
            <asp:ListItem Text="Emergency Leave" Value="Emergency Leave"></asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />

        <asp:Label ID="lblReason" runat="server"
            Text="Reason: ">
        </asp:Label>

        <asp:TextBox ID="txtReason" runat="server"
            TextMode="MultiLine"
            Rows="4"
            Columns="30">
        </asp:TextBox>

        <br />
        <br />

        <asp:CheckBox ID="chkRememberName" runat="server"
    Text="Remember my name" />

       <br />
       <br />

        <asp:Button ID="btnSubmit" runat="server"
            Text="Submit"
            OnClick="btnSubmit_Click" />

        <br />
        <br />

        <asp:Label ID="lblMessage" runat="server" Text="">
        </asp:Label>

    </form>
</body>
</html>