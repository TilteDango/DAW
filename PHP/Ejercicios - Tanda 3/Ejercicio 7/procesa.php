<?php 
if (!isset($_POST['val'])) {
    $oportunidades = 4;
    $n = 1234554;
}else{
    $n = $_POST['val'];
}
$secret = 1234;
    if ($secret == $n) {
        echo "¡Felicidades, la caja fuerte se ha abierto!";
    }else{
        echo "Lo siento, te quedan $oportunidades oportunidades";
        $oportunidades--;
    
        if ($oportunidades == 0) {
            echo "Lo siento, no se va a volver a abrir";
        }else{
            echo "<p>Debes adivinar la convinación de la caja fuerte</p>";
            echo "<form action='#'>";
            echo "<input type='number' name='val'>";
            echo "</form>";
            echo "<input type='submit'>";
        } 
    }

?>