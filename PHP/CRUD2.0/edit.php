<?php require_once './conexion.php';


if (isset($_GET['where'])) {
    $where = $_GET['where'];

   $sql = "SELECT * FROM `producto` WHERE `producto`.`cod` = '{$where}';";
   $resultados = $conection->query($sql);

    $JSON = $resultados->fetchAll(); 

    echo json_encode($JSON);
}



?>