<?php 

    $hora = $_POST['n'];


    if ($hora <= 40) {
        echo "Lo que cobras esta semana es: " . $hora * 12;
    }else{
      
        echo "Lo que cobras esta semana es: " . (($hora - 40) * 16) + (40 * 12);  
    }

?>