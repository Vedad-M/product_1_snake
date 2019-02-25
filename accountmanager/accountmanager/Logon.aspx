<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="SnakeGameFinal.LogOn" %>
<!DOCTYPE html>
<html>

<head>
    <title>Log On</title>
<link rel="stylesheet" href="stylesheet.css" type="text/css">
 </head>  
<body>
    <nav>
		    <ul>
  <li><a href="Home.aspx">Home</a></li>
  <li><a href="Scoreboard.aspx">Scoreboard</a></li>
  <li><a href="About.aspx">About</a></li>
  <li><a href="Contact.aspx">Contact Us!</a></li>
</ul> 
	</nav>

<form id="form" runat="server">
<asp:TextBox  id="txtUser" runat="server" >USERNAME:  </asp:TextBox>
<asp:TextBox  id="txtPassword" runat="server">PASSWORD:  </asp:TextBox> 
    <asp:Button runat="server" OnClick="LogOn_Click" Text="Submit"/>
<%--<button onclick ="LogOn_Click">Submit</button>--%>
      <asp:Label runat="server" id="label1"></asp:Label>
</form>
<div class="parallax">
	<img src="mainpagesnake.jpg" data-speed="1"class="img-parallax" alt ="parallax">
	 <h2 id="parallaxMsg" style="text-align:center;">Welcome!</h2>
	</div>
    <div class="parallax"></div>
    <footer>
 	<div class="mainFooter">
  <p>Powered by WillCode4Food™️</p>
  <p>Contact information: <a href="mailto:someone@example.com"> someone@example.com</a>.</p>
    </div>
 </footer> 
</body>
</html>
        

