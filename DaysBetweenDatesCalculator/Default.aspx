<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DaysBetweenDatesCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<h4>Days Between Dates Calculator</h4>
		Select a date:<br />
		<asp:Calendar ID="firstCalendar" runat="server"></asp:Calendar>
		<br />
		Select a second date:<asp:Calendar ID="secondCalendar" runat="server">
		</asp:Calendar>
		<br />
		<asp:Button ID="calculateButton" runat="server" OnClick="calculateButton_Click" Text="Calculate" />
		<br />
		<br />
		<asp:Label ID="resultLabel" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
