<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Scoreboard.aspx.cs" Inherits="accountmanager.WebForm3" %>
<!DOCTYPE html>
<html>
<head>
  <title>Snake Game - Scoreboard</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<link rel="stylesheet" href="mainStyleSheet.css" type="text/css">
<style>
body,h1 {font-family: "Raleway", sans-serif}
body, html {height: 100%}
.bgimg {
  background-image: url('Resources/mainpagesnake.jpg');
  min-height: 100%;
  background-position: center;
  background-size: cover;
}
table, th,td
{
    border: 1px solid white;
    border-collapse:collapse;
}
table
{
    width:750px;
    margin-top:200px; 
    margin-right: 550px;
    background: black;
}
</style>

</head>

<body>
       <nav>
     <ul>
  <li><a href="Home.aspx">Home</a></li>
    <li><a href="Game.aspx">The Game</a></li>
  <li><a href="Scoreboard.aspx">Scoreboard</a></li>
  <li><a href="About.aspx">About</a></li>
  <li><a href="Contact.aspx">Contact Us!</a></li>
</ul> 
  </nav>
<div class="bgimg w3-display-container w3-animate-opacity w3-text-white" >
  <div class="w3-display-topleft w3-padding-large w3-xlarge">
    SNAKE 🐍
  </div>
  <div style="float: right; ">
     <table>
        <tr >
            <th>Ranking</th>
            <th>Player Name</th>
            <th>Score</th>
        </tr>
    </table>
  </div>>
   
  <div class="w3-display-bottomleft w3-padding-large">
   <a href ="About.aspx"> Powered by WillCode4Food™️</a>
  </div>
</div>
  <div class="w3-display-bottomright w3-padding-large">
   <a href ="Logon.aspx"> Log In</a>
  </div>

</body>
</html>
