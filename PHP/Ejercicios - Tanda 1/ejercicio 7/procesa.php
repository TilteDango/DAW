<?php 

$e = $_POST['euros'];

$conversor_pesetas = 1.21;


echo "$e euros con IVA es " . $e * $conversor_pesetas . " euros";
?>