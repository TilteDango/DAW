<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 7</title>
</head>
<body>
    <?php 
    
    $array = [];
    for ($i=0; $i < 20; $i++) { 
        $r = rand(0,100);

        array_push($array, $r);
    }
    $aux = [];
    foreach ($array as $n) {
        if ($n % 2 == 0) {
            array_push($aux, $n);
        }
    }

    foreach ($array as $n) {
        if ($n % 2 == 1) {
            array_push($aux, $n);
        }
    }

    echo "<pre>";
    print_r($array);
    print_r($aux);
    echo "</pre>";
    
    ?>
</body>
</html>