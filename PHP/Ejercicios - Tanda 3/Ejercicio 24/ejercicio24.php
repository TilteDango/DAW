<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 24</title>
</head>
<body>
    <p>Este ejercicio nos permitira pintar una piramide con el icono que el usuario decida</p>

    <form action="ejercicio24.php" method="post">
    Elija el número de columnas <input type="number" name="col">
    <input type="submit" value="Construir"><br>
    </form>

    <?php 
    
    if (isset($_POST['col'])) {
        $col = $_POST['col'];

        echo "<pre>";
        $espacios = $col;
      
        for ($i=0; $i < $col * 2; $i+= 2) { 
            $cont = 2;
            for ($j=0; $j < $espacios; $j++) { 
                echo " ";
            }
            for ($k=0; $k < $i ; $k++) {   
                if ($k > $col) {
                    echo $k - $cont;
                    $cont+= 2;
                }  else{
                    echo $k; 
                } 
                           
            }
            $espacios--;
            echo "<br>";
        }
        for ($i=0; $i < $col; $i++) { 
            echo $i;
        }
        for ($i=$col; $i > 0; $i--) { 
            echo $i;
        }
        echo "</br>";

    }
    
    
    ?>
    
</body>
</html>