<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 1</title>
</head>
<body>
    <?php 
    $numeros = [];
    $cuadrado = [];
    $cubo = [];

    for ($i=0; $i < 20; $i++) { 
        $r = rand(0,100);

        array_push($numeros, $r);
        array_push($cuadrado, ($r * $r));
        array_push($cubo, ($r * $r * $r));
    }
    echo "<pre>";
    print_r($numeros);
  
    print_r($cuadrado);

    print_r($cubo);

    echo "</pre>";
    
    ?>
</body>
</html>