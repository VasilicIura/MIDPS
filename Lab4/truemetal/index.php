<!DOCTYPE html> 
<html>
	<head>
	
		<?php 
			$title = "TrueMetal";
			//require_once "functions/functions.php";
			//$tracks = getTracks (100);
		?>
			<meta charset="utf-8">
			
			<title> <?=$title?> </title>
			
			<link href="css/style.css" rel="stylesheet" type="text/css">
			
	</head>
	
	<body background = "image/metal1.jpg" bgproperties="fixed">
		
		<header>
			
			<div id="WelcomeMessage">
				<a href="index.php" title="Main page."> 
					<div>Welcome! Are you True Metal???</div>
				</a>
			</div>
										
			
	
		</header>
		
		<div id="MusicPage">
				<a href="pages/music.php" title="Music page"> 
					<div>Music</div>
				</a>
		</div>
		
		<div id="History">
				<a href="pages/history.php" title="History"> 
					<div>History</div>
				</a>
		</div>
		
		<div id="Cloud">
				<a href="pages/cloud.php" title="SoundCloud"> 
					<div>SoundCloud's true metal</div>
				</a>
		</div>
		
		<footer>
		
			<div id="FooterText"> 
				True Metal
			</div>
			
		</footer>
		
	</body>
</html>
