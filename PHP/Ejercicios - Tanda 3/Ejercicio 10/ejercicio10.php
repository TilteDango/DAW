<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 8</title>
</head>
<body>
    <form action="ejercicio10.php" method="post">
    Escriba un número: <input type="text" name="val">
    <input type="submit" value="Calcular">
    </form>

    <?php 
     
    
        if (isset($_POST['val'])) {
            $n = $_POST['val'];
            $suma = 0;
            $intentos = 0;
            if ($n >= 0) {
                 $suma += $n;                 
            }else{
                $cantidad++;
                echo "La media de las notas es: " . $total / $cantidad;
            } 

            $total += $suma;
            $cantidad = $cantidad++;
        }    
        
           
        
    ?>
</body>
</html>