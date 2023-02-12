<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 16</title>
</head>
<body>
    <p>Este programa te dice si un número es primo o no</p>

    <form action="ejercicio16.php" method="post">

        Introduce el número: <input type="number" name="val"><br>
        <input type="submit" value="Calcular"><br>

        <?php
        if (isset($_POST['val'])) {
            $base = $_POST['val'];
            $primo = true;
            for ($i=2; $i < $base - 1; $i++) {                     
                if ($base % $i == 0 ) {
                    $primo = false;
                }             
            }
            
            if ($primo) {
                echo "El número es primo";
            }else{
                echo "El número no es primo";
            }

    } 
        ?>
    </form>
</body>
</html>