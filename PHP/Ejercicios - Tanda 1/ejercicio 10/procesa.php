<?php 

$e = $_POST['euros'];

$conversor_pesetas = 1024;


echo "$e Mb en Kb son " . $e * $conversor_pesetas . " Kb";
?>