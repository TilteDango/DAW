<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 12</title>
</head>
<body>
    <form action="ejercicio12.php" method="post">
        Escriba un número: <input type="text" name="val">
        <input type="submit" value="Calcular">
    </form>

        <?php 
        if (isset($_POST['val'])) {
        
            $n = $_POST['val']; 

            if ($n >= 0) {
                $aux = 1;
                $ant = 0;
                echo $ant . ", ";
                echo $aux . ", ";
                echo $aux . ", ";
                $ant++;

                for ($i=3; $i < $n ; $i++) { 
                    if ($i != $n -1) {
                        echo $aux + $ant . ", ";
                    }else{
                        echo $aux + $ant;
                    }
                
                $aux2 = $aux;
                $aux += $ant;
                $ant = $aux2;
                }
            }
        }
        
        ?>
</body>
</html>