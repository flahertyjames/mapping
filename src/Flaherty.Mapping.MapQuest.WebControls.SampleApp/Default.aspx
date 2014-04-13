<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Flaherty.Mapping.MapQuest.WebControls.SampleApp.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <mapping:Map ID="Map" runat="server"
        License="Open" MapType="OpenStreetMap" AutomaticBoundary="true"
        ShowMapTypeControl="true" ShowPanControl="true" ShowZoomControl="true"
        Width="800" Height="600">
        <Pins>
            <mapping:Pin Position="45.5,-122.5" Color="Green1" Text="1">
                <InfoText>
                    <b>Portland, OR</b><br/>
                    45.5,-122.5
                </InfoText>
            </mapping:Pin>
            <mapping:Pin Position="39.97,-75.12" Color="Yellow1" Text="2">
                <InfoText>
                    <b>Philadelphia, PA</b><br/>
                    39.97,-75.12
                </InfoText>
            </mapping:Pin>
        </Pins>
    </mapping:Map>
    </form>
</body>
</html>
