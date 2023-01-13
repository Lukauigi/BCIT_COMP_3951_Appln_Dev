<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvestmentCalculator.aspx.cs" Inherits="InvestmentCalculator.InvestmentCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheetInvestmentCalculator.css" rel="stylesheet" runat="server" />
    <style type="text/css">
        .auto-style1 {
            height: 101px;
            width: 102px;
        }
        .auto-style2 {
            width: 50%;
            border: 1px solid #66FFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <img class="auto-style1" src="Images/goat_logo.png" />
    <h1> Investment Calculator</h1>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="monthlyInvestmentLabel" runat="server" Text="Monthly Investment"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="monthlyInvestmentOptionDropdown" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="AnnualInvestmentLabel" runat="server" Text="Annual Investment Rate"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="investmentRateTextBox" runat="server">2.5</asp:TextBox>
                        <asp:RangeValidator ID="investmentRateValidator" runat="server" ErrorMessage="Interest must range from 1 to 12" ControlToValidate="investmentRateTextBox" MaximumValue="12.0" MinimumValue="1.0" Type="Double"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="numOfYearsLabel" runat="server" Text="Number of Years"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="yearsTextBox" runat="server">20</asp:TextBox>
                        <asp:RangeValidator ID="yearsValidator" runat="server" ErrorMessage="Number of years should be between 1 and 45" ControlToValidate="yearsTextBox" MaximumValue="45" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="futureValueLabel" runat="server" Text="Future Value"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="valueLabel" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="calculateButton" runat="server" Text="Calculate" OnClick="ButtonCalculate" />
                    </td>
                    <td>
                        <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="ButtonClear" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
