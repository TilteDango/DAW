<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Procesa</title>
    <link rel="stylesheet" href="examen.css">
</head>
<body>
    
</body>
</html>

<?php 

if (!isset($_POST['n'])) {
    echo "No se han pasado parametros";
}else{
    $n = $_POST['n'];
    $palo = $_POST['palo'];
    $ruta = ['d', 'c', 't', 'p'];
    $palos = ['diamantes', 'copas', 'treboles', 'picas'];
    
    
    
    if ($n > 12 || $n < 3) {
        echo "El número de cartas introducido no es válido";
    }else{
        echo '<h1>MUESTRA CARTAS (RESULTADO)</h1>';
        echo '<h2> '. $n . " cartas de ". $palos[$palo]. "</h2><br>";
        $ant = 0;
        $esta = false;
        for ($i=0; $i < $n; $i++) { 
            
            $r = rand(1,10);
            echo '<img src="img/'.$ruta[$palo].$r.'.svg" alt="3" width="100">';
            if ($r == $ant) {
                $esta = true;
            }
            $ant = $r;
        }
        
        if ($esta) {
            echo "<p>Hay cartas iguales seguidas</p>";
        }
    }
    echo '<br><a href="index.html">Volver al formulario</a>';
}





?>