<?php 

    $n = $_POST['n'];

    if ($n % 2 == 0) {
        echo "El numero es par";
    }elseif($n % 5 == 0){
        echo "El número es divisible de 5";
    }else{
        echo "El número no es par ni divisible de 5";
    }
?>