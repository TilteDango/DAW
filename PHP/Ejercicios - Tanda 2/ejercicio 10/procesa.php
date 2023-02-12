<?php 


$day = $_POST['day'];
$month = $_POST['month'];



switch($month){
   case 1 : if ($day >= 21) {
        echo "Tu horoscopo es: Capricornio";
             } else{
        echo "Tu horoscopo es: Acuario";
                   }
            break; 
    case 2 : if ($day >= 19) {
        echo "Tu horoscopo es: Acuario";
             } else{
        echo "Tu horoscopo es: Piscis";
                   }
            break; 
    case 3 : if ($day >= 21) {
        echo "Tu horoscopo es: Aries";
             } else{
        echo "Tu horoscopo es: Piscis";
                   }
            break; 
    case 4 : if ($day >= 21) {
        echo "Tu horoscopo es: Tauro";
             } else{
        echo "Tu horoscopo es: Aries";
                   }
            break; 
    case 5 : if ($day >= 22) {
        echo "Tu horoscopo es: Géminis";
             } else{
        echo "Tu horoscopo es: Tauro";
                   }
            break;         

    case 6 : if ($day >= 21) {
        echo "Tu horoscopo es: Géminis";
             } else{
        echo "Tu horoscopo es: Cáncer";
                   }
            break; 

    case 7 : if ($day >= 22) {
        echo "Tu horoscopo es: Cáncer";
             } else{
        echo "Tu horoscopo es: Leo";
                   }
            break; 
    
    case 8 : if ($day >= 22) {
        echo "Tu horoscopo es: Leo";
             } else{
        echo "Tu horoscopo es: Virgo";
                   }
            break; 

    case 9 : if ($day >= 22) {
        echo "Tu horoscopo es: Virgo";
             } else{
        echo "Tu horoscopo es: Libra";
                   }
            break; 

    case 10 : if ($day >= 22) {
        echo "Tu horoscopo es: Libra";
             } else{
        echo "Tu horoscopo es: Escorpio";
                   }
            break; 

    case 11 : if ($day >= 23) {
        echo "Tu horoscopo es: Escorpio";
             } else{
        echo "Tu horoscopo es: Sagitario";
                   }
            break; 

    case 12 : if ($day >= 21) {
        echo "Tu horoscopo es: Sagitario";
             } else{
        echo "Tu horoscopo es: Capricornio";
                   }
            break; 
    default : echo "Datos introducidos erroneamente";
            
}

?>