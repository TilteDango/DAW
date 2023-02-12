<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 10</title>
</head>
<body>
    <?php     
        $puntos = ['As' => 11, 'Dos' => 0, 'Tres' => 10, 'Cuatro' => 0, 'Cinco' => 0,
        'Seis' => 0, 'Siete' => 0, 'Sota' => 2, 'Caballo' => 3, 'Rey' => 4];

        $palo = ['Oros', 'Copas', 'Espadas', 'Bastos'];

        $figura =  ['As', 'Dos', 'Tres', 'Cuatro', 'Cinco', 'Seis', 'Siete', 'Sota', 'Caballo', 'Rey'];
        $total = 0;
        $existentes = [];
        for ($i=0; $i < 10; $i++) { 
            $r = rand(0,3);
            $carta_palo = $palo[$r];

            $r2 = rand(0,9);
            $carta_figura = $figura[$r2];

           
            $carta = $carta_figura . " de " . $carta_palo . "<br>";
            if (!in_array($carta, $existentes)) {
                $total += $puntos[$carta_figura];
                echo $carta; 
                array_push($existentes, $carta);      
            }else{
                $i -= 1;
            }                  
        }
  
        echo "<br>El total de puntos es: $total";
    ?>
</body>
</html>