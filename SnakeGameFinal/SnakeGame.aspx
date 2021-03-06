﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SnakeGame.aspx.cs" Inherits="SnakeGameFinal.WebForm2" %>

<!DOCTYPE html>
<html>
    <head>
        <title>Snake, the Game.</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Raleway">
  <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.2/jquery.min.js"></script>
  <script type='text/javascript'>
  	$(document).ready(function(){
    var canvas = document.getElementById('c'),
        c = canvas.getContext('2d'),
        height, width, pixelsize, rate,
        dir, newdir, snake = [], food = [], score,
        gstarted = false, gpaused = false;
    
    function setup(h, w, ps, r) {
        height = 50;
        width = 50;
        pixelsize = ps;
        rate = 50;
        canvas.height = 500;
        canvas.width = 500;
        $(document).keydown(function (e) {
            switch(e.which) {
                case 38:
                    if(dir != 2) {
                        newdir = 0;
                    }
                    break;
                case 39:
                    if(dir != 3) {
                        newdir = 1;
                    }
                    break;
                case 40:
                    if(dir != 0) {
                        newdir = 2;
                    }
                    break;
                case 37:
                    if(dir != 1) {
                        newdir = 3;
                    }
                    break;
                case 32:
                    if(!gstarted) {
                        startGame();
                    }
                    else {
                        togglePause();
                    }
                    break;
            }
        });
        showIntro();
    }
    
    function showIntro() {
        c.fillStyle = '#000';
        c.fillRect(0, 0, width*pixelsize, height*pixelsize);
        c.fillStyle = '#fff';
        c.font = '30px sans-serif';
        c.textAlign = 'center';
        c.fillText('Welcome To Snake!!!!', width/2*pixelsize, height/4*pixelsize, width*pixelsize);
        c.font = '12px sans-serif';
        c.fillText('Space = start/pause.', width/2*pixelsize, height/1.5*pixelsize);
    }
    
    function startGame() 
    {
        var x = Math.floor(width/2), y = Math.floor(height/2);
        genFood();
        snake = [
            [x, y],
            [x, y],
            [x, y],
            [x, y]
        ];
        dir = 1;
        newdir = 1;
        score = 0;
        gstarted = true;
        gpaused = false;
        frame();
    }
    
    function endGame() {
        gstarted = false;
        deleteScore();
        c.fillStyle = 'rgba(0,0,0,0.8)';
        c.fillRect(0, 0, width*pixelsize, height*pixelsize);
        c.fillStyle = '#f00';
        c.font = '20px sans-serif';
        c.textAlign = 'center';
        c.fillText('Game Over', width/2*pixelsize, height/2.3*pixelsize);
        c.fillStyle = '#fff';
        c.font = '14px sans-serif'
        c.fillText('Please enter your Name down below to save your score to the ScoreBoard!!', width / 2 * pixelsize, height / 1.9 * pixelsize);
        c.font = '12px sans-serif';
        c.fillText('Press Space to Play Again!!',width/2*pixelsize, height/1.6*pixelsize);
        c.fillStyle = '#fff';
        c.font = '12px sans-serif';
        //c.fillText('Score: ' + score, width / 2 * pixelsize, height / 1.4 * pixelsize);
        var scoreLabel = document.getElementById('displayScore');
        scoreLabel.value = scoreLabel.value + score;
            }
   
    
    function togglePause() {
        if(!gpaused) {
            gpaused = true;
            c.fillStyle = '#fff';
            c.font = '20px sans-serif';
            c.textAlign = 'center';
            c.fillText('Paused', width/2*pixelsize, height/2*pixelsize);
        }
        else {
            gpaused = false;
            frame();
        }
    }
    
    function frame() {
        if(!gstarted || gpaused) {
            return;
        }
        var x = snake[0][0], y = snake[0][1];
        switch(newdir) {
            case 0:
                y--;
                break;
            case 1:
                x++;
                break;
            case 2:
                y++;
                break;
            case 3:
                x--;
                break;
        }
        if(testCollision(x, y)) {
            endGame();
            return;
        }
        snake.unshift([x, y]);
        if(x == food[0] && y == food[1]) 
        {	
        	score++;
        	deleteScore();
        	drawScore(); 
            genFood();   

        }
        else {
            snake.pop();
        }

        dir = newdir;
        c.fillStyle = '#000'; 
        c.fillRect(0, 0, width*pixelsize, height*pixelsize);
        c.fillStyle = '#fff';
        drawFood();
        drawSnake();
        var dif = document.getElementById("Dificulty");
        dif = dif.value;
        if (dif == "Easy") 
        {
        	rate = 150;
        }
        else if (dif == "Medium") 
        {
        	rate = 85;
        }
        else if (dif == "Hard") 
        {
        	rate = 35;
        }
        setTimeout(frame, rate); 
    }
   
   

    function genFood() {
        var x, y;
        do {
            x = Math.floor(Math.random()*(width-1));
            y = Math.floor(Math.random()*(height-1));
        } while(testCollision(x, y));
        food = [x, y];
    }
   
    function drawScore() 
    {
  		var scoreLabel = document.getElementById("scoreLabel");
  		var text = document.createTextNode(""+score);
  		scoreLabel.appendChild(text);
	}
	function oldScore()
	{
		document.getElementById('scoreLabel');
	}

	function deleteScore()
	{
		document.getElementById('scoreLabel').innerHTML = "";
	}
    
    function drawFood() {
        c.beginPath();
        c.fillStyle = 'green';
        c.arc((food[0]*pixelsize)+pixelsize/2, (food[1]*pixelsize)+pixelsize/2, pixelsize/2, 0, Math.PI*2, false);
        c.fill();
    }
    
    function drawSnake() {
        var i, l, x, y;
        for(i = 0, l = snake.length; i < l; i++) {
            x = snake[i][0];
            y = snake[i][1];
            c.fillStyle = 'blue';
            c.fillRect(x*pixelsize, y*pixelsize, pixelsize, pixelsize);
        }
    }
    
    function testCollision(x, y) {
        var i, l;
        if(x < 0 || x > width-1) {
            return true;
        }
        if(y < 0 || y > height-1) {
            return true;
        }
        for(i = 0, l = snake.length; i < l; i++) {
            if(x == snake[i][0] && y == snake[i][1]) {
                return true;
            }
        }
        return false;
    }
    
    setup(25, 25, 10, 200);
});
  </script>
<style>
body,h1 {font-family: "Raleway", sans-serif}
body, html {height: 100%}
.bgimg {
  background-image: url("mainpagesnake.jpg");
  min-height: 100%;
  background-position: center;
  background-size: cover;
}
#nameLabel{
    margin-left:20px;
}
#score{
   display:inline;
   margin-left: 40px;
}
#btnSubmit{
    margin-left:50px;
    font-size: 12px;
    width:90px;
    height:25px;
    
}

</style>
    </head>
<body>

<div class="bgimg w3-display-container w3-animate-opacity w3-text-white">
  <div class="logoSpace">
    Snake, The Game.
   
  </div>
<div style="text-align: center; margin-top: 10px; margin-right: 375px;">
	<p style="display: inline; margin-left: 80px">Dificulty:</p>
  	<select  id="Dificulty" style="display: inline;">
  		<option id="Dificulty" value="Easy">Easy</option>
  		<option id="Dificulty" value="Medium">Medium</option>
  		<option id="Dificulty" value="Hard">Hard</option>
  	</select>
  	<p style="display: inline; margin-left: 10px;"> Score: <p id="scoreLabel" style="display: inline;">0</p></p>
</div>
  <div class="w3-display-middle">
  	 <canvas id="c" width="800px" height="500px"></canvas> 
      <form runat="server" style ="margin-top:50px;">
        <asp:Label runat="server" ID="nameLabel">Enter Your Name:</asp:Label>
        <asp:TextBox runat="server" ID="nameText" Height="20px"></asp:TextBox>
          <asp:Label runat="server" ID="score" >Your Score is:</asp:Label>       
        <asp:Textbox runat="server" ID="displayScore" ReadOnly="true"></asp:Textbox>
         <asp:Label runat="server" ID="messageBox"></asp:Label>
          <asp:Button runat="server" text="Submit Score" ID="btnSubmit" OnClick="btnSubmit_Click"/>
    </form>
  </div>
   
  <div class="w3-display-bottomleft w3-padding-large">
    Powered by WillCode4Food™️
  </div>
</div>
</body>
</html>