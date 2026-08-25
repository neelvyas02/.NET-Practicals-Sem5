<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Calender.aspx.cs"
    Inherits="Practical_5.Calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Apply Leave</title>
</head>

<body>
    <form id="form1" runat="server">

        <asp:Calendar ID="Calendar1" runat="server"
            BackColor="Yellow"
            ForeColor="Black"
            BorderColor="Black"
            BorderWidth="1px"
            DayNameFormat="Short"
            OnSelectionChanged="Calendar1_SelectionChanged">
        </asp:Calendar>

        <br />

        <asp:Label ID="lblselectedDt" runat="server"
            Text="Selected Date: ">
        </asp:Label>

        <br />

        <asp:Button ID="btnApplyLeave" runat="server"
            Text="Apply Leave"
            OnClick="btnApplyLeave_Click" />

    </form>
</body>
</html>