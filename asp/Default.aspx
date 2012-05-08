<%@ Page Language="C#" Inherits="asp.Default" %>
<!DOCTYPE html>
<html>
<head>
	<title>A simple dotNet Cloud Foundry test</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
</head>
<body style="text-align: center; font-size: 150%; font-family: sans-serif;">
	This is really simple - don't expect anything too exciting...
		
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>
		
	<div style="font-size: 50%; color: grey; padding: 20px;">
		This instance running at: <asp:Label id="ipaddr" runat="server"/>
	</div>
		
	<div style="font-size: 50%; color: grey;">
        Powered by Cloud Foundry and Uhuru<br/>
			<a href="http://cloudfoundry.org"><img height="35" width="187" src="cf_logo_tagline.png" /></a>
	</div>

</body>
</html>
