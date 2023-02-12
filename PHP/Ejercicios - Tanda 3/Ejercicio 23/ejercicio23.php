<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 23</title>
</head>
<body>
    <form action="ejercicio23.php" method="post">
    Escriba un número: <input type="text" name="val">
    <input type="submit" value="Calcular"><br>
    

    <?php    
        if (isset($_POST['val'])) {
            $n = intval($_POST['val']);
            $total = intval($_POST['total']);
            $cont = intval($_POST['cont']);


            $total += $n;
            $cont++;
            if ($total < 10000) {

                echo '<input type="hidden" name="cont" value = '.$cont.'>';

                echo '<input type="hidden" name="total" value = '.$total.'>';
            }else{
                echo "El total acumulado es: $total <br>";
                echo 'Te ha costado ' . $cont . " veces para alcanzarlo <br>";
                echo "La media del número es: " . ($total / $cont) . "<br>";
            }
         
            

        }else{
           echo '<input type="hidden" name="cont" value=0>';
           echo '<input type="hidden" name="total" value=0>';
            }
            ?>
    </form>
</body>
</html>