<?php 

    $n = $_POST['n'];
    $rev = strrev($n);
    if ($n >= 0) {
        if ($n == $rev) {
            echo "El número es capicua";
        }else{
            echo "El núemro no es capicua";
        }
    }else{
        echo "El número no puede ser negativo";
    }
    
?>