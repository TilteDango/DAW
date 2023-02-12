<?php 


$horas = $_POST['day'];
$minutos = $_POST['month'];

$s_totales = 86400;


echo "Los segundos que faltan hasta media noche son: " . $s_totales - (($horas * 60 * 60) + ($minutos * 60));





?>