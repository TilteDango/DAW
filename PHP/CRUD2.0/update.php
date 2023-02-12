<?php require_once './conexion.php';

if (isset($_GET['cod'])) {
    $cod = $_GET['cod'];
    $nombre = $_GET['nombre'];
    $desc = $_GET['desc'];
    $pvp = $_GET['pvp'];
    $familia = $_GET['familia'];


    $sql = "UPDATE `producto` SET `cod` = '{$cod}', `nombre_corto` = '{$nombre}', `descripcion` = '{$desc}', `PVP` = '{$pvp}', `familia` = '{$familia}' WHERE `producto`.`cod` = '{$cod}'";

   echo $conection->exec($sql);
}


?>