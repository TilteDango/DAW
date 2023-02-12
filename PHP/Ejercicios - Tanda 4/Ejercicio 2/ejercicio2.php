<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 2</title>
</head>
<body>
    <p>Pide 10 números y calcula máximo y minimo</p>

    Introduce un número <input type="number" name="n">
    <input type="hidden" name="cont">
    <input type="hidden" name="cadn">


    <?php 
    
        if (isset($_POST['n'])) {
            $n = $_POST['n'];
            $cont = $_POST['cont'];
            $cadn = $_POST['cadn'];
        }else{
            $cont = 0;
            $cadn = "";
        }

        if ($cont == 10) {
            echo "";
        }else{
            
        }
    
    
    ?>
</body>
</html>