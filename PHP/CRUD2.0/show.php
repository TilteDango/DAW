<?php require_once './conexion.php';


$sql = "SELECT * FROM producto";
  $resultados = $conection->query($sql);
  
  $JSON = $resultados->fetchAll();

  echo json_encode($JSON);

?>