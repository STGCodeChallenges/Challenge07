<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>ISBN Checker</title>
<link href="css/styles.css" rel="stylesheet" type="text/css">
<?php include ("functions.php"); ?>
</head>
<body>
<div class="input">
	<h3>ISBN Checker</h3>
	<p>This form will verify an ISBN is valid.</p>
	<form method="post" action="result.php">
			<label>Enter ISBN</label><br>
			<textarea name="stringtoparse" id="stringtoparse"></textarea><br>
			<input type="submit" name="Submit" value="Submit"/>
	</form>
</div>
</body>
</html>
