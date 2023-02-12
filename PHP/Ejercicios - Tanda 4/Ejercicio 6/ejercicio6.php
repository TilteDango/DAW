<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 6</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <p>El programa consiste en coger números y poner de color rojo los impares y en verde los pares</p>

    <form action="ejercicio6.php" method="post">

        Número: <input type="number" name="n1">
        <input type="submit" value="Enviar"><br>
   
    <?php 
            if (isset($_POST['n1'])) {
                $n = $_POST['n1'];
                $cont = $_POST['cont'];
                $lista = $_POST['lista'];

                $cont += 1;
                if ($cont == 8) {
                    $lista .= $n;
                    $array = explode(',', $lista);

                    foreach ($array as $value) {

                        if ($value % 2 == 0) {
                           
                            echo "<span class='verde'> $value </span>";
                        }else{
                            echo "<span class='rojo'> $value </span>";
                        }
                    }
                }else{
                    $lista .= $n. ",";
                    echo '<input type="hidden" value="'.$lista.'" name="lista">';
                echo '<input type="hidden" value="'.$cont.'" name="cont">';
                echo "</form>";
                
                }

                

               
            }else{
                echo '<input type="hidden" value="" name="lista">';
                echo '<input type="hidden" value="0" name="cont">';
                echo "</form>";
                

            }

    
    ?>
</body>
</html>