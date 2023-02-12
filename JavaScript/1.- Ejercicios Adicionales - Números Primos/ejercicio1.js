var  reloj = 60;
setInterval(function(){
    reloj--;
    document.getElementById("reloj").innerHTML = reloj;
    if (reloj == 0) {
        alert("Has perdido");
        location.reload();
    }
}, 1000);


let container = document.getElementById("container"); 
for (let i = 1; i <= 50; i++) {
let button = document.createElement('button');
button.innerText = i;
button.id = "btn-" + i;
button.onclick = function(){
   ComprobarPrimo(button.innerHTML);      
}
container.appendChild(button);

};
var fallos = 0;
var numerosAcertados = [];


function ComprobarPrimo(n){

    let primos = [1, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47];
    let esPrimo = false;
    for (let i = 0; i < primos.length; i++) {
        if (n == primos[i]) {
            esPrimo = true;
        }
    }

    if (esPrimo) {
        document.getElementById("btn-" + n).innerHTML = "_";
        document.getElementById("btn-" + n).disabled = true;
        numerosAcertados.push(n);
        if(haGanado(primos)){
            document.getElementById("res").innerHTML = "Felicidades, has ganado";
            alert("Felicidades, has ganado");
            location.reload();
        };
    }else{
        document.getElementById("btn-" + n).style.color = "red";
        document.getElementById("btn-" + n).disabled = true;
        fallos++;
    }

    document.getElementById("fallos").innerHTML = "Número total de fallos: " + fallos;
}


function haGanado(primos){

    numerosAcertados = numerosAcertados.sort(function(a, b){
        return a - b;
    });
    let k = 0;
    for (let i = 0; i < numerosAcertados.length; i++) {
        if (numerosAcertados[i] == primos[i]) {
            k++;
        }
        
    }

    if (k == primos.length) {
        
        console.log(primos.length, numerosAcertados.length);
        return true;
    }else{

        console.log(numerosAcertados,k);
        return false;
    }
}
