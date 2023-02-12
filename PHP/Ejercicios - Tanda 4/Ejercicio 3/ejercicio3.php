<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 3</title>
</head>
<body>
    <p>Pide 10 números y calcula máximo y minimo</p>

    <form action="ejercicio3.php" method="post">

    
    Introduce un número <input type="number" name="n">
    <input type="submit" value="Enviar"><br>
    

    <?php 
    
        if (isset($_POST['n'])) {
            $n = $_POST['n'];
            $cont = $_POST['cont'];
            $cadn = $_POST['cadn'];
        }else{
            $cont = -1;
            $cadn ="";
            $n = "";
        }
        $cont += 1;
        $cadn .= "$n";
        if ($cont >= 15) {
            echo $cadn . "<br>";
            
            $array = explode(" ", $cadn);
            $aux = [];
            for ($i=0; $i < count($array) ; $i++) { 
               if ($i == count($array) -1) {
                array_push($aux, $array[0]);
               }else{
                array_push($aux, $array[$i +1]);
               }
            }
            echo "<pre>";
            print_r($array);
            print_r($aux);
            echo "</pre>";
        }else{
            if ($cont != 0) {
                $cadn .= "$n ";
            }
            

            echo '<input type="hidden" name="cont" value="'.$cont.'">';
            echo '<input type="hidden" name="cadn" value="'.$cadn.'">';
        }   
    ?>
    </form>
</body>
</html>