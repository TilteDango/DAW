<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ejercicio 13</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
<?php 

$bidime = [[]];
$repe = [];

for ($i=0; $i < 9; $i++) { 
    for ($k=0; $k < 6; $k++) { 
        $r = rand(100,999);
        if (!in_array($r, $repe)) {
            $bidime[$i][$k] = $r;
            array_push($repe, $r);
        }else{
            $k--;
        }
    }
}

$min = 1000;
$diagantant;
$diagantpos; 
$diagposant;
$diagpospos;

$diag1 = false;
$diag2 = false;
$diag3 = false;
$diag4 = false;

for ($i=0; $i < 9; $i++) {
    for ($k=0; $k < 6; $k++) { 
        if ($min > $bidime[$i][$k]) {
            if ($i -1 >= 0 && $k - 1 >= 0) {
                $diagantant = $bidime[$i -1][$k -1];
                $diag1 = true;
            }
            if ($i -1 >= 0 && $k + 1 < 6) {
                $diagantpos = $bidime[$i -1][$k +1];
                $diag2 = true;
            }
            if ($i + 1 < 9 && $k - 1 >= 0) {
                $diagposant = $bidime[$i +1][$k -1];
                $diag3 = true;
            }
            if ($i + 1 < 9 && $k + 1 < 6) {
                $diagpospos = $bidime[$i + 1][$k + 1];
                $diag4 = true;
            }

            $min = $bidime [$i][$k];
        }

    }
}

echo "<table border='1'>";
for ($i=0; $i < 9; $i++) {

    echo "<tr>"; 
    for ($k=0; $k < 6; $k++) {
        $aux1 = false;
        $aux2 = false;
        $aux3 = false;
        $aux4 = false;
        if ($diag1) {
            if ($diagantant == $bidime[$i][$k]){
                echo "<td style='color:green;'>".$bidime[$i][$k]."</td>";
                $aux1 = true;
            }
       
        }       
    if ($diag2) {
        if ($diagantpos == $bidime[$i][$k] && $diag2){
            echo "<td style='color:green;'>".$bidime[$i][$k]."</td>";
            $aux2 = true;
        }
        
    }
    if ($diag3) {
        if ($diagposant == $bidime[$i][$k] && $diag3){
            echo "<td style='color:green;'>".$bidime[$i][$k]."</td>";
            $aux3 = true;
        }
        
    }
        
    if($diag4){
         if ($diagpospos == $bidime[$i][$k] && $diag4){
                echo "<td style='color:green;'>".$bidime[$i][$k]."</td>";
                $aux4 = true;
         }
     }
     if ($min == $bidime[$i][$k]){
        echo "<td class='blue'>".$bidime[$i][$k]."</td>";
    }
        else{
            if (!$aux1 && !$aux2 && !$aux3 && !$aux4) {
                echo "<td>".$bidime[$i][$k]."</td>";
            }  
        }  
    }
    echo "</tr>";
}

echo $min;



?>
</body>
</html>
