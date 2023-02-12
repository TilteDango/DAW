function enviarSaludo(){
    const person_name = document.getElementById('nombre').value;
    const surname = document.getElementById('apellido').value;
    const p = document.getElementById('saludo');
    p.textContent = `hola ${person_name} ${surname}, gracias por rellenar el formulario`
}