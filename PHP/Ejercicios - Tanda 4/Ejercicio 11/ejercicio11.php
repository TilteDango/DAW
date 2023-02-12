<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 11</title>
    <p>Elige entre una de estas</p>
</head>
<body>
    <form action="ejercicio11.php" method="post">
    <input type="text" name="val">
    <input type="submit" value="Enviar">
    </form>

    <?php 
    
        $array = ["Hola" => "Hello", "Adios" => "Bye", "Perro" => "Dog", "Gato" => "Cat", "Coche" => "Car", "Botella" => "Bottle", "Ordenador" => "Computer", "Silla" => "Chair", "Movil" => "Mobile", "Conejo" => "Rabbit", "Mesa" => "Desktop", "Camiseta" => "T-Shirt", "Pantalones" => "Trousers", "Lapiz" => "Pencil", "Boligrafo" => "Pen", "Calcetines" => "Socks", "Zapatos" => "Shoes", "Pantalla" => "Screen", "Teclado" => "Keyboard", "Ratón" => "Mouse"];


        if (isset($_POST['val'])) {
            $val = $_POST['val'];
            foreach ($array as $key => $value) {
                if ($key == $val) {
                    echo $key . " => " . $value;
                }
            }
        }else{
            echo "<ol>";
            foreach ($array as $key => $value) {
                echo "<li> $key </li>";
            }
            echo "</ol>";
        }
    
    
    
    ?>
</body>
</html>