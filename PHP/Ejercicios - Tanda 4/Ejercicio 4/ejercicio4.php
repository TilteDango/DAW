<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 4</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <p>El programa consistira en generar 100 números aleatorios y cambiar los marcados por un input por otros</p>

    <form action="ejercicio4.php" method="post">

        Número a cambiar<input type="number" name="n1">
        Número cambiado <input type="number" name="ncambio">
        <input type="submit" value="Enviar"><br>
   
    <?php 
            if (isset($_POST['n1'])) {
                $n = $_POST['n1'];
                $cambio = $_POST['ncambio'];
                $lista = $_POST['lista'];

                $array = explode(' ', $lista);

                foreach ($array as $value) {

                    if ($n == $value) {
                       
                        echo "<span class='verde'> $cambio </span>";
                    }else{
                        echo "$value ";
                    }
                }



            }else{
                $aux = "";
                for ($i=0; $i < 100 ; $i++) { 
                    $r = rand(0, 20);
                    $aux .= $r . " ";
                }

                echo '<input type="hidden" value="'.$aux.'" name="lista">';
                echo "</form>";
                $array = explode(' ', $aux);
                echo "<table border = '1'>";
                $i = 1;
                foreach ($array as $value) {
                    if ($i % 10 == 0) {
                        echo "<tr>";
                    }
                    echo "<td> $value </td>";

                    if ($i % 10 == 0) {
                        echo "</tr>";
                    }
                    $i += 1;
                }
                echo "</table>";
            }

    
    ?>
</body>
</html>