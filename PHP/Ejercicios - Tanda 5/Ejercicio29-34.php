<?php 

$array = generaArrayBiInt(6,9,100,200);

echo "<pre>";
print_r($array);
echo "</pre>";

$aux = filaDeArrayBiInt($array, 1);
echo "<pre>";
print_r($aux);
echo "</pre>";

$aux = columnaDeArrayBiInt($array, 1);
echo "<pre>";
print_r($aux);
echo "</pre>";

echo coordenadasArrayBiInt($array, 110);

if (esPuntoDeSilla($array, $array[0][0], 0, 0)) {
    echo "<br>Es punto de silla";
}else{
    echo "<br>No es punto de silla";
}

$diagonal = diagonal($array, "nose");
echo "<pre>";
print_r($diagonal);
echo "</pre>";


function generaArrayBiInt($n, $m, $min, $max){
        $array = [[]];
        for ($i=0; $i < $n; $i++) { 
            for ($k=0; $k < $m; $k++) { 
                $r = rand($min, $max);
                $array[$i][$k] = $r;
            }
        }
        return $array;
}

function filaDeArrayBiInt($array, $i){
    $aux = [];
for ($k=0; $k < count($array[$i]); $k++) { 
    array_push($aux, $array[$i][$k]);
}
return $aux;
}

function columnaDeArrayBiInt($array, $k){
    $aux = [];
for ($i=0; $i < count($array); $i++) { 
    array_push($aux, $array[$i][$k]);
}
return $aux;
}

function coordenadasArrayBiInt($array, $elemento){
    $esta = false;
    for ($i=0; $i < count($array); $i++) { 
        for ($k=0; $k < count($array[0]); $k++) { 
            if ($array[$i][$k] == $elemento) {
                $aux = "{".$i.",".$k."}";
                $esta = true;
                $i = count($array);
                $k = count($array[0]);
            }
        }
    }

    if (!$esta) {
        $aux = "{-1,-1}";
    }

    return $aux;
   
}

function esPuntoDeSilla($array, $n, $fila, $columna){
    $filas = filaDeArrayBiInt($array, $fila);
    $columnas = columnaDeArrayBiInt($array, $columna);
    $min = true;
    $max = true;

    for ($i=0; $i < count($filas); $i++) { 
        if ($n > $filas[$i]) {
            $min = false;
        }
    }

    for ($i=0; $i < count($columnas); $i++) { 
        if ($n < $columnas[$i]) {
            $max = false;
        }
    }

    if ($max && $min) {
        return true;
    }else{
        return false;
    }
}

function diagonal($array, $cadena){
    if ($cadena == "nose") {
        $aux = [];
        for ($i=0; $i < count($array); $i++) { 
            for ($k=0; $k < count($array[0]); $k++) { 
                if ($i == $k) {
                    array_push($aux, $array[$i][$k]);
                }
                
            }
        }
    }else{
        $aux = [];
        for ($i=count($array); $i > 0; $i--) { 
            for ($k=count($array[0]); $k > 0; $k--) { 
                if ($i == $k) {
                    array_push($aux, $array[$i][$k]);
                }               
            }
        }
    }

    return $aux;
    
    
}
