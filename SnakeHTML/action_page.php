<?php

$username = filter_input(INPUT_POST, 'username');
$password = filter_input(INPUT_POST, 'password');
if(!empty($username)){
	if (!empty($password)) {
		$host = "localhost:3306";
		$dbusername = "FOODadmin";
		$dbpassword = "!!Cis440";
		$dbname = "snakegame";

		// connection
		$connection = new mysqli($host, $dbusername, $dbpassword, $dbname);
		if(mysqli_connect_error())
		{
			die('Connect Error ('. mysqli_connect_errno() .')'
				. mysqli_connect_error()); 
		}
		else
		{
			$sql = "INSERT INTO users (username, password)
			values ('$username', '$password')";
			if($connection->query($sql)){
				echo "new record is insertedd successfully";
			}else{
				echo "Error: ". $sql ."<br>". $connection->error;
			}
			
			$connection->close();
		}
	
	}
	else{ 
		echo "password should not be empty"
		die();
	}
}else{ echo "username should not be empty"; 
		die();
}

?>