<?php 

$e = $_POST['euros'];

$conversor_pesetas = 1024;


echo "$e Kb en Mb son " . $e / $conversor_pesetas . " Mb";
?>