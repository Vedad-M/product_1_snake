<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="accountmanager.WebForm1" %>

<!DOCTYPE html>
<html>

<head>
  <title>Snake Game</title>
 <style>
body,h1 {font-family: "Raleway", sans-serif}
body, html {height: 100%}
.bgimg {
  background-image: url('Resources/mainpagesnake.jpg');
  min-height: 100%;
  background-position: center;
  background-size: cover;
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
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<link rel="stylesheet" href="mainStyleSheet.css" type="text/css">


<div class="bgimg w3-display-container w3-animate-opacity w3-text-white">
  <div class="w3-display-topleft w3-padding-large w3-xlarge">
    SNAKE 🐍
  </div>
  <div class="w3-display-middle">
    <h1 class="mainTitle">Snake </h1>
    <h1 class ="subTitle"> The Game </h1>

    <hr class="w3-border-grey" style="margin:auto;width:40%">
    <p class="w3-large w3-center">
      <a href ="Game.aspx" >Begin</a>
  </div>
  <div class="w3-display-bottomleft w3-padding-large">
   <a href ="about.html"> Powered by WillCode4Food™️</a>
  </div>
</div>
    <div>
  <div class="w3-display-bottomright w3-padding-large">
   <a href ="logon.html"> Log In</a>
  </div>
</div>

</body>
</html>
