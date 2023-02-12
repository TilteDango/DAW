<?php 

$hora = $_POST['n'];

$dias = ["lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo"];

if ($hora > 0 && $hora < 8) {
    echo "El día de la semana es: " . $dias[$hora - 1];
}else{
    echo "Número incorrecto";
}

?>