<?php 

$respuestas = [$_POST['p1'], $_POST['p2'], $_POST['p3'], $_POST['p4'], $_POST['p5'], $_POST['p6'], $_POST['p7'], $_POST['p8'], $_POST['p9'], $_POST['p10']];

$aciertos = 0;

foreach ($respuestas as $respuesta) {
    if ($respuesta == "true") {
        $aciertos+= 3;
    }
}

if ($aciertos <= 10) {
    echo "¡Enhorabuena! Tu pareja parece ser totalmente fiel";
}elseif($aciertos <= 21){
    echo "Quizás exista el peligro de otra persona en su vida o en su mente, aunque seguramente será algo sin importancia. No bajes la guardia.";
}else{
    echo "Tu pareja tiene todos los ingredientes de estar viviendo un romance con otra persona. Te aconsejamos que indagues un poco más y averigües qué es lo que está pasando por su cabeza.";
}


?>