<?php 

    $n = $_POST['n'];

    if ($n >= 0) {
        echo strlen($n);
    }else{
        echo strlen($n) -1;
    }
    
?>