<?php
	$servername = "localhost";
	$username = "host";
	$password = "thiSIsasimPlePassowRd87";
	$dbName = "XProjectOne";
	// Create connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	// Check connection
	if ($conn->connect_error) 
	{
		die("Connection failed: " . $conn->connect_error);
	}
?>