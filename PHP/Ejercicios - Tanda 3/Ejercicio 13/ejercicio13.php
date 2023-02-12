<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 13</title>
</head>
<body>
    <p>Leera 10 números y te dira cuantos son positivos y cuantos son negativos</p>
    <form action="ejercicio13.php" method="post">
    <?php 
            if (isset($_POST['val'])) {
                $n = $_POST['val'];
                $intentos = $_POST['num'];
                $pos = $_POST['positiv'];
                $neg = $_POST['negativ'];
                if ($n > 0) {
                    $pos++;
                }elseif($n < 0){
                    $neg++;
                }
                $intentos++;
                if ($intentos <= 10) {
                    
                echo 'Introduce el número <input type="number" name="val">';
                echo '<input type="hidden" name="num" value="'.$intentos.' ">';
                echo '<input type="hidden" name="positiv" value = "'.$pos.' ">';
                echo '<input type="hidden" name="negativ" value = "'.$neg.' ">';
                echo '<input type="submit" value="Enviar">'; 
                }else{
                    echo "Tienes $pos números positivos y $neg números negativos";
                }
            }else{
                ?>
                    Introduce el número <input type="number" name="val">
                        <input type="hidden" name="num" value="0">
                        <input type="hidden" name="positiv" value = "0">
                        <input type="hidden" name="negativ" value = "0">
                        <input type="submit" value="Enviar">
                <?php
            }
    ?>
     </form>
</body>
</html>