<?php 

$respuestas = [$_POST['p1'], $_POST['p2'], $_POST['p3'], $_POST['p4'], $_POST['p5'], $_POST['p6'], $_POST['p7'], $_POST['p8'], $_POST['p9'], $_POST['p10']];

$aciertos = 0;

foreach ($respuestas as $respuesta) {
    if ($respuesta == "true") {
        $aciertos++;
    }
}

echo "Tus aciertos han sido: $aciertos";


?>