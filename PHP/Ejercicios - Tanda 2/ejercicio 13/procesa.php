<?php 

    $n1 = $_POST['n'];
    $n2 = $_POST['n2'];
    $n3 = $_POST['n3'];

    $nums = [$n1, $n2, $n3];

    sort($nums);

    print_r($nums);


?>