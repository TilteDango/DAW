<?php 


if (isset($_POST['n'])) {
    $n = $_POST['n'];

    if (esCapicua($n)) {
        echo "El número es capicúa";
    }else{
        echo "El número no es capicúa";
    }
        echo "<br>";
    if (esPrimo($n)) {
        echo "El número es primo";
    }else{
        echo "El número no es primo";
    }
    echo "<br>";

   echo "El siguiente primo es: ". siguientePrimo($n). "<br>"; 

   echo "El número elevado a 4 es: " . potencia($n, 4);

   echo "<br> El número tiene " . digitos($n) . " digitos";

   echo "<br> El número dado la vuelta es: " . voltea($n);

   echo "<br> La primera cifra del número es: " .digitoN($n, 0);

   if (posicionDeDigito($n, 2) != -1) {
        echo "<br> El número 2 se encuentra en la posción " . (posicionDeDigito($n, 2) +1);
   }else{
        echo "<br> El número 2 no esta en este número";
   }

   echo "<br> Si le quitamos la última cifra es: " . quitaPorDetras($n, 1);

   echo "<br> Si le quitamos la primera cifra es: " . quitaPorDelante($n, 1);

   echo "<br> Si le añadimos un 1 al final del número es: " . pegaPorDetras($n, 1);
   echo "<br> Si le añadimos un 1 al principio del número es: " . pegaPorDelante($n, 1);

   if ($n >= 100 || $n < -100) {
        echo "<br> Si  cogemos las cifras del medio es: " . trozoDeNumero($n, 1, strlen($n) -1);
   }else{
    echo "<br>El número es muy pequeño para poder probarlo correctamente";
   }

   echo "<br> Si le pegamos al número 314 es: " . juntaNumeros($n, 314);


}else{
    ?>
    <form action="Ejercicios1-14.php" method="post">
    <input type="number" name="n">
    <input type="submit" value="Enviar">
    </form>
<?php
}

function esCapicua($n){

    $aux = strrev($n);

    if ($aux == $n) {
        $capicua = true;
    }else{
        $capicua = false;
    }

    return $capicua;
}

function esPrimo($n){

    $primo = true;
    for ($i=2; $i < $n -1; $i++) { 
        if ($n % $i == 0) {
            $primo = false;
        }
    }

    return $primo;
}

function siguientePrimo($n){
    $primo = false;
    $i = $n + 1;
    while (!$primo) {
        $i++;
        if (esPrimo($i)) {      
            $primo = true;
        }  
    }

    return $i;
}

function potencia($n, $exponente){

    $aux = 1;
    for ($i=0; $i < $exponente; $i++) { 
        $aux *= $n;
    }

    return $aux;
}

function digitos($n){
    if ($n >= 0) {
        $aux = strlen($n);
    }else{
        $aux = strlen($n) -1;
    }

    return $aux;
}

function voltea($n){
    return strrev($n);
}

function digitoN($n, $pos){
    return $n[$pos];
}

function posicionDeDigito($n, $digito){
    $aux = -1;
    for ($i=0; $i < strlen($n); $i++) { 
        if ($n[$i] == $digito) {
            $aux = $i;
            $i = strlen($n);
        }
    }

    return $aux;
}

function quitaPorDetras($n, $cantidad){
    $aux = "";
    for ($i=0; $i < strlen($n) - $cantidad; $i++) { 
        $aux .= $n[$i];
    }

    return $aux;
}

function quitaPorDelante($n, $cantidad){
    $aux = "";
    for ($i=$cantidad; $i < strlen($n); $i++) { 
        $aux .= $n[$i];
    }

    return $aux;
}

function pegaPorDetras($n, $pegado){
    $aux = $n . $pegado;

    return $aux;
}

function pegaPorDelante($n, $pegado){
    $aux = $pegado . $n;

    return $aux;
}

function trozoDeNumero($n, $min, $max){
    $aux = "";

    if ($n < 0) {
        $min += 1;
    }
    for ($i=$min; $i < $max; $i++) { 
        $aux .= $n[$i];
    }

    return $aux; 
}

function juntaNumeros($n, $pegado){
    return $n . $pegado;
}

?>