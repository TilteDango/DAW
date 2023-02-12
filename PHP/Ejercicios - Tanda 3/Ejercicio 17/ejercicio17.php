<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 17</title>
</head>
<body>
    <p>Este programa te suma los 100 números siguientes al número introducido</p>

    <form action="ejercicio17.php" method="post">

        Introduce el número: <input type="number" name="val"><br>
        <input type="submit" value="Calcular"><br>

        <?php
        if (isset($_POST['val'])) {
            $base = $_POST['val'];
            if ($base >= 0) {
                $aux = $base;
                for ($i=$aux +1; $i < $aux + 100; $i++) {                     
                    $base += $i;            
                }
                
                echo $base;
            }else{
                echo "Número introducido no válido"; 
            }
            

    } 
        ?>
    </form>
</body>
</html>