<?php require_once './conexion.php';


if (isset($_GET['where'])) {
    $where = $_GET['where'];

    $sql = "DELETE FROM `producto` WHERE `producto`.`cod` = '{$where}'";

    $conection->exec($sql);
}



?>