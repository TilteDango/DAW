<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 5</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <p>El programa consistira en generar 100 números aleatorios y cambiar los marcados por un input por otros</p>

    <form action="ejercicio5.php" method="post">

        Temperatura media del mes: <input type="number" name="n1">
        <input type="submit" value="Enviar"><br>
    
   
    <?php 
            if (isset($_POST['n1'])) {
                $temeratura = $_POST['n1'];
                $lista = $_POST['lista'];
                $cont = $_POST['cont'];
                $cont += 1;
                if ($cont == 12) {
                    $lista .= $temeratura . ",";
                    $array = explode(',', $lista);
                    $meses = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", ""];
                    $i = 0;
                    foreach ($array as $value) {
                        echo $meses[$i] . " ";
                        for ($k=0; $k < $value; $k++) { 
                            echo "#";
                        }
                        echo "<br>";
                        $i += 1;
                    }
                }else{
                    
                    $lista .= $temeratura . ",";
                    echo '<input type="hidden" value="'.$lista.'" name="lista">';
                    echo '<input type="hidden" value="'.$cont.'" name="cont">';
                    echo '<form>';
                }
            }else{
                echo '<input type="hidden" value="" name="lista">';
                echo '<input type="hidden" value="0" name="cont">';
                echo '<form>';
                
            }
    ?>
</body>
</html>