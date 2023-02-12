<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 27</title>
</head>
<body>
    <form action="ejercicio27.php" method="post">
    Escriba un número: <input type="text" name="val">
    <input type="submit" value="Calcular"><br>
    

    <?php    
        if (isset($_POST['val'])) {
            $n = $_POST['val'];
            $aux = 0;
            $cont = 0;
           for ($i=1; $i < $n ; $i++) { 
            if ($i % 3 == 0) {
                echo "$i sumado a lo anterior: " . $aux += $i;
                echo "<br>";
                $cont += 1;
            }
           
           }
           echo "----------------------------------- <br>";
           echo "Hay $cont números entre 1 y $n";
        }
            ?>
    </form>
</body>
</html>