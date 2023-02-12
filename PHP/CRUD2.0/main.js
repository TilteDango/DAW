onload = ShowElements;

const form = document.getElementById("form");
form.addEventListener('submit', getDates);

var editando = false;



function getDates(){
    let familias = ["CAMARA", "CONSOL", "EBOOK", "IMPRES", "MEMFLA", "MP3", "MULTIF", "NETBOK", "ORDENA", "PORTAT", "ROUTER", "SAI", "SOFTWA", "TV", "VIDEOC"];
    
    const cod = document.getElementById("id").value; 
    const nombre_corto = document.getElementById("nombre").value;
    const desc = document.getElementById("desc").value;
    const pvp = document.getElementById("pvp").value;
    const familia = familias[document.getElementById("familia").value];
    let url;
    if (!editando) {
         url = `insert.php?cod=${cod}&nombre=${nombre_corto}&desc=${desc}&pvp=${pvp}&familia=${familia}`;
    }else{
        document.getElementById("submit").innerText = "Crear producto";
        editando = false;
         url = `update.php?cod=${cod}&nombre=${nombre_corto}&desc=${desc}&pvp=${pvp}&familia=${familia}`;     
    }

    document.getElementById("id").value = "";
    document.getElementById("nombre").value = "";
    document.getElementById("desc").value = "";
    document.getElementById("pvp").value ="";
    document.getElementById("familia").value = -1;
   
    let xhr = new XMLHttpRequest();
    xhr.onload = function() {
        ShowElements();
    }

    xhr.open("GET", url);
    xhr.send();
    
}

function ShowElements(){
    let familias = {"CAMARA" : "Cámara Digital",
                    "CONSOL" : "Consola", 
                    "EBOOK" : "Libro electrónico", 
                    "IMPRES" : "Impresora", 
                    "MEMFLA" : "Memoria Flash", 
                    "MP3" : "Reproductor MP3", 
                    "MULTIF" : "Equipo multifunción", 
                    "NETBOK" : "Netbook", 
                    "ORDENA" : "Ordenador", 
                    "PORTAT" : "Ordenador portátil", 
                    "ROUTER" : "Router", 
                    "SAI" : "Sistema de alimentación ininterrumpida", 
                    "SOFTWA" : "Software", 
                    "TV" : "Televisor", 
                    "VIDEOC" : "Videocámara"
                };
    let xhr = new XMLHttpRequest();
    xhr.onload = function() {
        let results = JSON.parse(xhr.responseText);
        let cadena = "";
        results.forEach(element => {
            cadena += "<tr>";
            cadena += `<td> ${element[0]}</td>`;
            cadena += `<td> <a href="javascript:GetElement(${element[0]})">${element[2]}</a></td>`;
            cadena += `<td> ${element[4].replace('.', ',')}€</td>`;
            cadena += `<td> ${familias[element[5]]}</td>`;
            cadena += `<td><button id = "${element[0]}" onclick="DeleteProduct(${element[0]})">Borrar</button></td>`;
            cadena += "</tr>";
        });

        document.getElementById("tbody").innerHTML = cadena;
        
    }
  
        xhr.open("GET", 'show.php');
        xhr.send();
}

function DeleteProduct(button){
   
    let url = `borrar.php?where=${button.id}`;
    let xhr = new XMLHttpRequest();
    xhr.onload = function(){
        ShowElements();
    }

    xhr.open("GET", url);
    xhr.send();
}

function GetElement(button){
    editando = true;
    document.getElementById("submit").innerText = "Editar Producto";
    let familias = {"CAMARA" : 0, "CONSOL" : 1, "EBOOK" : 2, "IMPRES" : 3, "MEMFLA" : 4, "MP3" : 5, "MULTIF" : 6, "NETBOK" : 7, "ORDENA" : 8, "PORTAT" : 9, "ROUTER" : 10, "SAI" : 11, "SOFTWA" : 12, "TV" : 13, "VIDEOC" : 14};
    let url = `edit.php?where=${button.id}`;
    let xhr = new XMLHttpRequest();
    xhr.onload = function(){
     const cod = document.getElementById("id"); 
     const nombre_corto = document.getElementById("nombre");
     const desc = document.getElementById("desc");
     const pvp = document.getElementById("pvp");
     const familia = document.getElementById("familia");

     let results = JSON.parse(xhr.responseText);
    cod.value = results[0].cod;
    nombre_corto.value = results[0].nombre_corto;
    desc.value = results[0].descripcion;
    pvp.value = parseFloat(results[0].PVP);
    familia.value = familias[results[0].familia];
    }

    xhr.open("GET", url);
    xhr.send();

}