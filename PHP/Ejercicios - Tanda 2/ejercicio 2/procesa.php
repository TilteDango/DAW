<?php 

$hora = $_POST['n'];


if ($hora >= 6 && $hora < 12) {
    echo "Buenos días";
}elseif($hora >= 12 && $hora < 20){
    echo "Buenas tardes";
}elseif($hora >= 20 && $hora < 24 || $hora < 6){
    echo "Buenas noches";
}else{
    echo "Hora incorrecta";
}


?>