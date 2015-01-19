<?php
//To verify an ISBN you :-
// obtain the sum of 10 times the first digit, 9 times the second digit, 8 times the third digit... all the way till you add 1 times the last digit.
// If the sum leaves no remainder when divided by 11 the code is a valid ISBN.

function verifyISBN($input){
	$input = preg_replace("/[^A-Za-z0-9]/", '', $input);
	$ISBN = str_split($input,1);
	if(count($ISBN)!=10){
		return false;
		}
	$y=10;
	$sum=0;
	for($x=0;$x<count($ISBN);$x++){
		if($ISBN[$x] = "X"){
			$ISBN[$x] = 10;
			}
		$sum = $sum + $ISBN[$x]*$y;
		$y--;
		}
	if($sum % 11 == 0){
		return true;
		}
		else{
		return false;
		}
	}
	
function createISBN(){
	$ISBN=array();
	for($z=0;$z<9;$z++){
		$ISBN[$z] = rand(0,9);
		}
	$y=10;
	$sum=0;
	for($x=0;$x<count($ISBN);$x++){
		$sum = $sum + $ISBN[$x]*$y;
		$y--;
		}
	if ((11 - ($sum % 11)) % 11 == 10){
		$ISBN[10] = "X";
		}
	else{
		$ISBN[10] = (11 - ($sum % 11)) % 11;
	}
	
	$new_isbn = implode("",$ISBN);
	return($new_isbn);
	}	
?>