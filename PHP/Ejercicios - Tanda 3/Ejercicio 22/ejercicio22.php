<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 22</title>
</head>
<body>
    <p>Este ejercicio nos permitira calcular todos los números primos del 2 al 100</p>

    <?php 
        $valido = true; 
            for ($i=2; $i <= 100; $i++) { 
                $valido = true;
                for ($k=2; $k < $i -1; $k++) { 
                    if ($i % $k == 0) {
                        $valido = false;
                    }
                }
                if ($valido) {
                    if ($i == 97) {
                        echo $i;
                    }else{
                        echo $i . ", ";
                    }
                    
                }
            }
    ?>
    
</body>
</html>