<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 29</title>
</head>
<body>
    <form action="ejercicio29.php" method="post">
    Escriba un número: <input type="text" name="val"><br>
    Escriba un número divisible: <input type="text" name="pos"><br>
    <input type="submit" value="Calcular"><br>
    

    <?php    
        if (isset($_POST['val'])) {
            $n = $_POST['val'];
            $div = $_POST['pos'];
        
           for ($i=1; $i < $n; $i++) { 
            if ($i % $div != 0) {
                echo $i . "<br>";
            }
           }
        }
            ?>
    </form>
</body>
</html>