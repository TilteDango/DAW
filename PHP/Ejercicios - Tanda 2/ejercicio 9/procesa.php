<?php 

    $n1 = $_POST['n'];
    $n2 = $_POST['n2'];
    $n3 = $_POST['n3'];

    echo "El resultado sería: " . -$n2 + (sqrt(($n2 * $n2) - (4 * $n1 * $n3)) / 2) . "<br>";
    echo "O: " . (-$n2) - ((sqrt(($n2 * $n2) - 4 * $n1 * $n3)) / (2 * $n1))


?>