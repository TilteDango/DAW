<?php require_once './conexion.php';

if (isset($_GET['cod'])) {
    $cod = $_GET['cod'];
    $nombre = $_GET['nombre'];
    $desc = $_GET['desc'];
    $pvp = $_GET['pvp'];
    $familia = $_GET['familia'];


    $sql = "INSERT INTO `producto` (`cod`, `nombre`, `nombre_corto`, `descripcion`, `PVP`, `familia`) VALUES ('{$cod}', '', '{$nombre}', '{$desc}', '{$pvp}', '{$familia}')";

    $conection->exec($sql);
}

?>