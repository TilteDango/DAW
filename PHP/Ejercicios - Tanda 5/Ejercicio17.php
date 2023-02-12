<?php 

if (isset($_POST['n'])) {
    $n = $_POST['n'];

    $dec = bindec($n);

    echo $dec;
}else{
    ?>
        <form action="Ejercicio17.php" method="post">
            Introduce un número binario
            <input type="number" name="n">
            <input type="submit" value="Enviar">
        </form>
    <?php
}


?>