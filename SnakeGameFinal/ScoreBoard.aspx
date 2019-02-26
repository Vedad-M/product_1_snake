﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreBoard.aspx.cs" Inherits="SnakeGameFinal.ScoreBoard" %>

<!DOCTYPE html>
<html>
<head>
  <title>W3.CSS Template</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
<link rel="stylesheet" href="stylesheet.css" type="text/css">
<style>
body,h1 {font-family: "Raleway", sans-serif}
body, html {height: 100%}
.bgimg {
  background-image: url('mainpagesnake.jpg');
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

<div class="bgimg w3-display-container w3-animate-opacity w3-text-white" >
  <div class="w3-display-topleft w3-padding-large w3-xlarge">
    SNAKE 🐍
  </div>
  <div style="float: right; ">
    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
  </div>>
   
  <div class="w3-display-bottomleft w3-padding-large">
   <a href ="about.html"> Powered by WillCode4Food™️</a>
  </div>
</div>
  <div class="w3-display-bottomright w3-padding-large">
   <a href ="logon.html"> Log In</a>
  </div>

</body>
</html>