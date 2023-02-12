<?php 

    $n1 = $_POST['n'];
    $n2 = $_POST['n2'];
    $n3 = $_POST['n3'];

    $media = round(($n1 + $n2 + $n3) / 3, 2);

    if ($n1 > 10 ||$n2 > 10 || $n3 > 10 || $n1 < 0 ||$n2 < 0 || $n3 < 0) {
        echo "Notas no válidas";
    }else{
        if ($media < 5) {
            echo "Insuficiente: $media";
        }elseif($media < 6){
            echo "Suficiente: $media";
        }elseif($media < 7){
            echo "Bien: $media";
        }elseif($media < 9){
            echo "Notable: $media";
        }elseif($media <= 10){
            echo "Sobresaliente $media";
        }else{
            echo "Notas introducidas erroneamente";
        }
    }

?>