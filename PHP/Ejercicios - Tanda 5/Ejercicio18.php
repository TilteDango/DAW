<?php 

if (isset($_POST['n'])) {
    $n = $_POST['n'];

    $bin = decbin($n);

    echo $bin;
}else{
    ?>
        <form action="Ejercicio18.php" method="post">
            Introduce un número decimal
            <input type="number" name="n">
            <input type="submit" value="Enviar">
        </form>
    <?php
}


?>