<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 26</title>
</head>
<body>
    <form action="ejercicio26.php" method="post">
    Escriba un número: <input type="text" name="val"><br>
    Escriba una posición: <input type="text" name="pos"><br>
    <input type="submit" value="Calcular"><br>
    

    <?php    
        if (isset($_POST['val'])) {
            $n = $_POST['val'];
            $pos = $_POST['pos'] -1;
        
           echo $n[$pos];
        }
            ?>
    </form>
</body>
</html>