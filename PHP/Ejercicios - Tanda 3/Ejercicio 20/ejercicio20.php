<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 20</title>
</head>
<body>
    <p>Este ejercicio nos permitira pintar una piramide con el icono que el usuario decida</p>

    <form action="ejercicio20.php" method="post">
    Elija el número de columnas <input type="number" name="col">
    Elija el icono a usar: <select name="icon">
        <option value="0">*</option>
        <option value="1">©</option>
        <option value="2">֍</option>
        <option value="3">▓</option>
        <option value="4">☺</option>
    </select>
    <input type="submit" value="Construir"><br>
    </form>

    <?php 
    
    if (isset($_POST['col'])) {
        $array = ["*", "©", "֍", "▓", "☺",];
        $col = $_POST['col'];
        $icon = $array[$_POST['icon']];
        echo "<pre>";
        $espacios = $col;
      
        for ($i=0; $i < $col * 2; $i+= 2) { 
            for ($j=0; $j < $espacios; $j++) { 
                echo " ";
            }
            for ($k=0; $k < $i ; $k++) { 
              if ($k ==0 | $k == $i -1) {
                echo $icon;
              }else{
                echo " ";
              }
                
            }
            $espacios--;
            echo "<br>";
        }
        for ($i=0; $i < $col * 2; $i++) { 
            echo $icon;
        }
        echo "</br>";

    }
    
    
    ?>
    
</body>
</html>