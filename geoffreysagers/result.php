<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>ISBN Checker</title>
<link href="css/styles.css" rel="stylesheet" type="text/css">
<?php include('functions.php'); ?>
</head>
<body>
	<div class="results">
		<?php
			$stringtoparse = $_POST['stringtoparse'];
			echo("<p>The number: <br /><br /><em>" .  ucwords($stringtoparse) . "</em><br /><br /><strong>");
			if(verifyISBN($stringtoparse) == true){
				echo ("is");
				}
				else{
				echo ("is not");	
					}
			echo("</strong> a valid ISBN number</p>");
			
		?>
	</div>
	<div class="button"><a href="index.php">Parse another ISBN &raquo;</a></div><div class="button"><a href="createISBN.php">Create an ISBN &raquo;</a></div>
</body>
</html>