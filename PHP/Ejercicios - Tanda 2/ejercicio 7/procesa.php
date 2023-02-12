<?php 

    $n1 = $_POST['n'];
    $n2 = $_POST['n2'];
    $n3 = $_POST['n3'];

    echo "La nota media sería: " . round(($n1 + $n2 + $n3) / 3, 2);


?>