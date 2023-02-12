<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 15</title>
</head>
<body>
    <p>Este programa te calcula un número introduciendo su base y exponente</p>

    <form action="ejercicio15.php" method="post">

        Introduce la base: <input type="number" name="base"><br>
        Introduce el exponente: <input type="number" name="exp"><br>
        <input type="submit" value="Calcular"><br>

        <?php
        if (isset($_POST['base'])) {
            $base = $_POST['base'];
            $expo = $_POST['exp'];
            $mult = $base;
                echo "$mult elevado a 1  = ". $mult . "<br>";

                for ($i=1; $i < $expo; $i++) { 
                    echo "$mult elevado a ".($i+1)." = ".$base * $mult . "<br>";  
                    $base *= $base;             
                }

    } 
        ?>
    </form>
</body>
</html>