<?php 


$day = $_POST['day'];

switch($day){
    case "lunes" : echo "Empresa e iniciativa emprendedora"; break;
    case "martes" : echo "Desarrollo en entrono servidor"; break;
    case "miercoles" : echo "Desarrollo en entrono servidor"; break;
    case "jueves" : echo "Inglés"; break;
     case "viernes" : echo "Inglés";  break;
     default : echo "Día incorrecto o fin de semana";
}

?>