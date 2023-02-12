<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pares y Nones</title>
    <link rel="stylesheet" href="examen.css">
</head>
<body>
    <h1>PARES Y NONES</h1>
   
    <pre>
                              Jugador 1              Jugador 2
                               (Pares)                (Nones)
    </pre>
    
    <?php 
    
    $images = ['0.svg', '1.svg', '2.svg', '3.svg', '4.svg', '5.svg'];
    $resultado = ['gana.svg', 'pierde.svg'];

    $ri = rand(0,5);
    $rd = rand(0,5);
    $res = $ri + $rd;

    if ($res % 2 == 0) {
        echo "<tr>";
        echo '<td><img src="'.$resultado[0].'" alt="5" height="200"></td>';
        echo '<td><img src="'.$images[$ri].'" alt="3" height="200"></td>';
        echo '<td><img src="'.$images[$rd].'" alt="5" height="200"></td>';
        echo '<td><img src="'.$resultado[1].'" alt="5" height="200"></td>';
        echo '</tr>';

    }else{
        echo "<tr>";
        echo '<td><img src="'.$resultado[1].'" alt="5" height="200"></td>';
        echo '<td><img src="'.$images[$ri].'" alt="3" height="200"></td>';
        echo '<td><img src="'.$images[$rd].'" alt="5" height="200"></td>';
        echo '<td><img src="'.$resultado[0].'" alt="5" height="200"></td>';
        echo '</tr>';
    }
    echo "<br>"; 
    echo "<br>"; 
echo '<center><button onclick="location.reload()">Nueva partida</button></center>';
echo "<br>";
    ?>
</body>
</html>