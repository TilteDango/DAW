<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 8</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <p>El programa consiste en coger números, montar un array y mostrarlo por pantalla</p>

    <form action="ejercicio8.php" method="post">

        Número: <input type="number" name="n1">
        <input type="submit" value="Enviar"><br>
   
    <?php 
            if (isset($_POST['n1'])) {
                $n = $_POST['n1'];
                $cont = $_POST['cont'];
                $lista = $_POST['lista'];

                $cont += 1;
                if ($cont == 10) {
                    echo "</form>";
                    $lista .= $n;
                    $array = explode(',', $lista);
                    echo "Array inicial";
                    echo "<table border='1'>";
                    echo "<tr>";
                   for ($i=1; $i <= 10 ; $i++) { 
                    echo "<td> $i </td>";
                   }
                    echo "</tr>";
                    echo "<tr>";
                    foreach ($array as $key => $value) {
                        echo "<td>" . $value ."</td>";                      
                    }
                    echo "</tr> </table> <br>";

                    echo "Array final";
                    $aux = [];
                    $noprimo = [];

                    foreach ($array as $value) {
                        $primo = true;
                        for ($i=2; $i < $value -1; $i++) { 
                            if ($value % $i == 0) {
                                $primo = false;
                            }
                        }

                        if ($primo) {
                            array_push($aux, $value);
                        }else{
                            array_push($noprimo, $value);
                        }
                    }
                    echo "<table border ='1'>";
                    echo "<tr>";
                    for ($i=1; $i <= 10 ; $i++) { 
                        echo "<td> $i </td>";
                    }
                    echo "</tr><tr>";
                    foreach ($aux as  $value) {
                        echo "<td> $value </td>";
                    }

                    foreach ($noprimo as $value) {
                        echo "<td> $value </td>";
                    }
                    echo "</tr>";
                    echo "</table>";
                   
                }else{
                    $lista .= $n. ",";
                    echo '<input type="hidden" value="'.$lista.'" name="lista">';
                echo '<input type="hidden" value="'.$cont.'" name="cont">';
                echo "</form>";
                
                }

                

               
            }else{
                echo '<input type="hidden" value="" name="lista">';
                echo '<input type="hidden" value="0" name="cont">';
                echo "</form>";
                

            }

    
    ?>
</body>
</html>