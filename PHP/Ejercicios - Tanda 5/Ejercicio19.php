<?php

if (isset($_GET['n'])) {
    $base = $_GET['base'];
    $n = $_GET['n'];
    $conversion = $_GET['select'];
    $aux = "";
    switch ($base) {
        case '0':
            switch ($conversion) {
                case '1':
                    $aux = bindec($n);
                    break;
                case '2':
                    $aux = decoct(bindec($n));
                    break;
                case '3':
                    $aux = bin2hex($n);
                    break;

                default:
                    $aux = "No compatible";
                    break;
            }
            break;
        case '1':
            switch ($conversion) {
                case '0':
                    $aux = decbin($n);
                    break;
                case '2':
                    $aux = decoct($n);
                    break;
                case '3':
                    $aux = dechex($n);
                    break;

                default:
                    $aux = "No compatible";
                    break;
            }
            break;
        case '2':
            switch ($conversion) {
                case '0':
                    $aux = decbin(octdec($n));
                    break;
                case '1':
                    $aux = octdec($n);
                    break;
                case '3':
                    $aux = dechex(octdec($n));
                    break;

                default:
                    $aux = "No compatible";
                    break;
            }
            break;
        case '3':
            switch ($conversion) {
                case '0':
                    $aux = hex2bin($n);
                    break;
                case '1':
                    $aux = hexdec($n);
                    break;
                case '2':
                    $aux = decoct(hexdec($n));
                    break;

                default:
                    $aux = "No compatible";
                    break;
            }
            break;

        default:
            "No esta bien introducido los datos";
            break;
    }




    echo $aux;
} else {
?>
    <form action="Ejercicio19.php" method="get">
        Introduce un número y su base

        <input type="number" name="n">
        <select name="base">
            <option value="0">Binario</option>
            <option value="1">Decimal</option>
            <option value="2">Octal</option>
            <option value="3">Hexadecimal</option>
        </select>
        <br>Base a convertir: <br>
        <select name="select">
            <option value="0">Binario</option>
            <option value="1">Decimal</option>
            <option value="2">Octal</option>
            <option value="3">Hexadecimal</option>
        </select>
        <input type="submit" value="Enviar">
    </form>
<?php
}


?>