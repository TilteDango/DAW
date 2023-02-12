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
    Traduce esta palabra: 
    <?php 
     $array = ["Hola" => "Hello", "Adios" => "Bye", "Perro" => "Dog", "Gato" => "Cat", "Coche" => "Car", "Botella" => "Bottle", "Ordenador" => "Computer", "Silla" => "Chair", "Movil" => "Mobile", "Conejo" => "Rabbit", "Mesa" => "Desktop", "Camiseta" => "T-Shirt", "Pantalones" => "Trousers", "Lapiz" => "Pencil", "Boligrafo" => "Pen", "Calcetines" => "Socks", "Zapatos" => "Shoes", "Pantalla" => "Screen", "Teclado" => "Keyboard", "Ratón" => "Mouse"];

     $aux = [];
     $cad = "";
     for ($i=0; $i < 5; $i++) { 
        $r = array_rand($array);
        if (!in_array($r, $aux)) {

            array_push($aux, $r);
            if ($i == 5) {
                $cad .= $r;
            }else{
                $cad .= $r . " ";
            }
            if ($i == 0) {
                echo $cad . "<br>";
            }
        }else{
            $i--;
        }
     }

     if (isset($_POST['val'])) {
        $val = $_POST['val'];
        $cad = $_POST['cad'];
        $cont = $_POST['cont'];
        $aciertos = $_POST['aciertos'];

        $cadena = explode(' ', $cad);
        unset($cadena[5]);

    }else{
      echo '<input type="hidden" name="aciertos" value="0">';
      echo '<input type="hidden" name="cont" value="0">';
      echo '<input type="hidden" name="cad" value="'.$cad.'">';
    }
    
    ?>
    <input type="text" name="val">
    <input type="submit" value="Enviar">
   

    <?php

       


    ?>
   
     </form>
</body>
</html>