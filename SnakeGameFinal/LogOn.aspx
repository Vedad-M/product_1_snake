<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOn.aspx.cs" Inherits="SnakeGameFinal.LogOn" %>
<!DOCTYPE html>
<html>

<head>
    <title>Log On</title>
<link rel="stylesheet" href="mainStyleSheet.css" type="text/css">
      <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">

    <style>

  form {
    position: relative;
    z-index: 1;
    background: white;
    max-width: 360px;
    margin: 0 auto 100px;
    padding: 45px;
    text-align: center;
    box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
    font-size: 12px;
    opacity: .85;
    
    }

    form input {
        font-family: "Raleway", sans-serif;
        text-transform: uppercase;
        outline: 0;
        background: #4CAF50;
        width: 100%;
        border: 0;
        padding: 12px;
        color: #FFFFFF;
        font-size: 14px;
        -webkit-transition: all 0.3 ease;
        transition: all 0.3 ease;
        cursor: pointer;
        opacity: .5;
        margin: 10px
    }

    form button {
        font-family: "Raleway", sans-serif;
        padding: 12px;
        color: #d3d3d3;
        margin: 10px;
        background: white;
        opacity: .5;
        border: 2px dotted #4CAF50;
    }
    </style>
   
 </head>  
<body>
    <nav>
		 <ul>
  <li><a href="Home.aspx">Home</a></li>
  <li><a href="ScoreBoard.aspx">Scoreboard</a></li>
  <li><a href="About.aspx">About</a></li>
  <li><a href="Contact.aspx">Contact Us!</a></li>
</ul> 
	</nav>
  
    <div class="parallax">
	<img src="mainpagesnake.jpg" data-speed="1"class="img-parallax" alt ="parallax">
	 <h2 id="parallaxMsg" align="center">Welcome!</h2>

    <form id="form" runat="server">
<p>Username: </p><asp:TextBox  id="txtUser" runat="server" >  </asp:TextBox>
<p>Password: </p><asp:TextBox  id="txtPassword" runat="server"> </asp:TextBox> 
    <asp:Button runat="server" OnClick="LogOn_Click" Text="Submit"/>
<button onclick ="LogOn_Click">Submit</button>
         
      <asp:Label runat="server" id="label1"></asp:Label>
</form>
   
        <div class="parallax"></div>
    <footer>
 	<div class="mainFooter">
  <p>Powered by WillCode4Food™️</p>
    </div>
 </footer> 
</body>
</html>
        

<%--  --%>