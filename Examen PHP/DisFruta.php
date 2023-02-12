<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 1</title>
</head>
<body>
    <center><h1>DisFruta con PHP</h1></center>
</body>
</html>
<?php 

$frutas = [];
$r = rand(7,20);

for ($i=0; $i < $r; $i++) { 
    $rand = rand(127815,127827);

    $fruta = "&#".$rand;

    array_push($frutas, $fruta);
}

$key = [];
$value = [];
$i = 0;
foreach ($frutas as $fruta) {
  if(in_array($fruta, $key)){
    $i = array_search($fruta, $key);
    $value[$i]++;
  }else{
    array_push($key, $fruta);
    array_push($value, 1);
  }
}

for ($i=0; $i < count($key) ; $i++) { 
    echo "<h2>".count($frutas). " frutas </h2>";

    echo "<p style='font-size: 7rem'>";
    for ($i=0; $i < count($frutas); $i++) { 
        echo $frutas[$i]. " ";
    }
    echo "</p>";
}

echo "<h2> Resutlados </h2>";

for ($i=0; $i < count($key); $i++) { 
    echo '<p>La fruta <span style="font-size: 2rem">'.$key[$i].'</span> está <strong>'.$value[$i].'</strong>';
    if ($value[$i] > 1) {
     echo ' veces en la lista.</p>';
    } else{
      echo ' vez en la lista.</p>';
    }
}

echo "<br>"; 
echo '<center><button onclick="location.reload()">¡¡¡ DisFruta otra vez !!!</button></center>';
echo "<br>";


?>