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
	Here are 25 valid ISBNs:
		<?php
		echo("<ul>");
		for ($x=0;$x<25; $x++){
			$isbn = createISBN();
			//echo("<li>" . $isbn . " -  " . verifyISBN($isbn) . "</li>");
			echo("<li>" . $isbn . "</li>");
		}
		echo("</ul>");
		?>
	</div>
	<div class="button"><a href="index.php">Parse another ISBN &raquo;</a></div><div class="button"><a href="createISBN.php">Create an ISBN &raquo;</a></div>
</body>
</html>