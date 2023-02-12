<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 18</title>
</head>
<body>
    <p>Este programa te calcula los números de 7 en 7 del menor al mayor</p>

    <form action="ejercicio18.php" method="post">

        Introduce un número: <input type="number" name="n1"><br>
        Introduce otro número: <input type="number" name="n2"><br>
        <input type="submit" value="Calcular"><br>

        <?php
        if (isset($_POST['n1'])) {
            $n1 = $_POST['n1'];
            $n2 = $_POST['n2'];
            
            if ($n1 != $n2) {
                if ($n1 > $n2) {
                    $aux = $n2;
                    for ($i=$n2; $i < $n1; $i++) { 
                        if ($aux + 7 <= $n1) {
                            echo $aux + ", ";
                        }
                    }
                }else{
                    $aux = $n1;
                    for ($i=$n1; $i < $n2; $i++) { 
                        if ($aux + 7 <= $n2) {
                            echo $aux + ", ";
                        }
                    }
                }
            }else{
                echo "Los números son iguales";
            }               
    } 
        ?>
    </form>
</body>
</html>