<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Adivina</title>
</head>
<body>
    <p>Consiste en adivinar un número entre el 1 y el 100</p>
    <form action="Adivina.php" method="post">
        Introduzca un número positivo <input type="number" name="n" min ="0" max ="100">
        <input type="submit" value="Comprobar números">
   


    <?php
        if (isset($_POST['n'])) {
            $n = $_POST['n'];
            $r = $_POST['secret'];
            $min = $_POST['min'];
            $max = $_POST['max'];

           if ($n == "") {
            echo "No se ha escrito ningún número";
            echo '<input type="hidden" name="min" value= 1>';
            echo '<input type="hidden" name="max" value= 100>';
            $r = rand(1, 100);
            echo '<input type="hidden" name="secret" value= '.$r.'>';
           }else{
            if ($n < 0) {
                echo "No se ha escrito un número entero positivo";
            }

            if ($n == $r) {
                echo "<br>Felicidades el número era: $r";
                echo "<br>"; 
                echo '<input type="hidden" name="min" value= 1>';
                echo '<input type="hidden" name="max" value= 100>';
                $r = rand(1, 100);
                echo '<input type="hidden" name="secret" value= '.$r.'>';
                echo '<center><button onclick="location.reload()">¡¡¡ Adivina otra vez !!!</button></center>';
                echo "<br>";
            }else{
               
                if ($n > $r) {
                    $max = $n;
                 echo "<br>El número es demasiado grande";
   
                }else{
                    if ($n < $r) {
                        $min = $n;
                        echo "<br>El número es demasiado pequeño";
                    }
                }
    
                echo '<input type="hidden" name="secret" value= '.$r.'>';
                echo '<input type="hidden" name="min" value= '.$min.'>';
                echo '<input type="hidden" name="max" value= '.$max.'>';
                echo "<br>El número esta entre $min y $max <br>";
            }      
        }
        }else{
            $r = rand(1, 100);
            echo '<input type="hidden" name="secret" value= '.$r.'>';
            echo '<input type="hidden" name="min" value= 1>';
            echo '<input type="hidden" name="max" value= 100>';
        }
    
    ?>
    </form>

</body>
</html>