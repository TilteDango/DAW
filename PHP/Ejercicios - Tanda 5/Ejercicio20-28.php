<?php 

$array = generaArray(10, 100, 200);

echo "<pre>";
print_r($array);
echo "</pre>";

echo "<br>El mínimo es: " . minimoArrayInt($array);
echo "<br>El maximo es: " . maximoArrayInt($array);
echo "<br>La media es: " . mediaArrayInt($array);
if (estaArrayInt($array, 110)) {
    echo "<br>Esta el número 110 <br>";
    echo "El número 110 esta en la posición: " . posicionArrayInt($array, 110);
}else{
    echo "<br>No esta el número 110";
}

$reverse = volteaArrayInt($array);
echo "<pre>";
print_r($reverse);
echo "</pre>";

$reverse = rotaDerechaArrayInt($array, 2);
echo "<pre>";
print_r($reverse);
echo "</pre>";

$reverse = rotaIzquierdaArrayInt($array, 2);
echo "<pre>";
print_r($reverse);
echo "</pre>";


function generaArray($n, $min, $max){

    $array = [];
    for ($i=0; $i < $n; $i++) { 
        $r = rand($min, $max);
        array_push($array, $r);
    }

    return $array;
}

function minimoArrayInt($n){
    return min(($n));
}

function maximoArrayInt($n){
    return max(($n));
}

function mediaArrayInt($n){
    return array_sum($n) / count($n);
}

function estaArrayInt($n, $contains){
    return in_array($contains, $n);
}

function posicionArrayInt($n, $contains){
    return array_search($contains, $n);
}

function volteaArrayInt($n){
    return array_reverse(($n));
}

function rotaDerechaArrayInt($n, $pos){
    $aux = [];

    for ($i=count($n) - $pos; $i < count($n); $i++) { 
       array_push($aux, $n[$i]);
    }

    for ($i= 0; $i < count($n) - $pos; $i++) { 
        array_push($aux, $n[$i]);
     }

    return $aux;
}

function rotaIzquierdaArrayInt($n, $pos){
    $aux = [];

    for ($i= 0 + $pos; $i < count($n); $i++) { 
        array_push($aux, $n[$i]);
     }

    for ($i=0; $i < $pos; $i++) { 
       array_push($aux, $n[$i]);
    }

   

    return $aux;
}




?>