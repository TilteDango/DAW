<?php 
$opciones = array(PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8");
$conection = new PDO('mysql:host=localhost;dbname=dwes', 'dwes', 'abc123', $opciones);


?>