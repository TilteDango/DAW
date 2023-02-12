<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 8</title>
</head>
<body>
    <form action="ejercicio11.php" method="post">
    Escriba un número: <input type="text" name="val">
    <input type="submit" value="Calcular">
</form>

    <?php           
          if (isset($_POST['val'])) {
            $n = $_POST['val'];
            echo "<table border = '1'>";
            echo "<tr>";
            echo "<th> Número </th><th>Cuadrado</th><th>Cubo</th></tr>";
          
          for ($i=$n; $i < $n + 5; $i++) { 
            echo "<tr>";
                echo "<td> $i </td>";
                echo "<td>". $i * $i . "</td>";
                echo "<td>" . $i * $i * $i . "</td>";
          }
          echo "</table>";
          }
          
    ?>
    
</body>
</html>