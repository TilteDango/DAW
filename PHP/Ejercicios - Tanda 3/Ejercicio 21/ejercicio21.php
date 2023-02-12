<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 21</title>
</head>
<body>
    <form action="ejercicio21.php" method="post">
    Escriba un número: <input type="text" name="val">
    <input type="submit" value="Calcular"><br>
    

    <?php    
        if (isset($_POST['val'])) {
            $n = intval($_POST['val']);
            $impares = intval($_POST['impares']);
            $pares = intval($_POST['pares']);
            $total = intval($_POST['total']);

            if ($n > 0) {
                if ($n > $pares) {
                    $pares = $n;
                  }
        
                  $impares += $n;
        
                  $total++;

                  echo '<input type="hidden" name="impares" value='.$impares.'>';

                echo '<input type="hidden" name="pares" value = '.$pares.'>';

                echo '<input type="hidden" name="total" value = '.$total.'>';
            }else{
                echo "El mayor número par es $pares <br>";
                echo "La media de los números impares es" .($impares / $total)."<br>";
            }
         
            

        }else{
           echo '<input type="hidden" name="impares" value=0>';
           echo '<input type="hidden" name="pares" value=0>';
           echo '<input type="hidden" name="total" value=0>';
            }
            ?>
    </form>
</body>
</html>