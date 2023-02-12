function Validacion(){
    const nams = document.getElementById('nombre')
    const surname1 = document.getElementById('apellido1')
    const surname2 = document.getElementById('apellido2')
    const tel = document.getElementById('telefono')
    const email = document.getElementById('email')
    const passed = document.getElementById('contraseña')
    const radio = Array.from(document.getElementsByName('sexo'))
    
    if (!CheckSurnames(nams.value)) {
        nams.style.background = 'red'
        nams.focus()
    } else if(!CheckSurnames(surname1.value) || !CheckSurnames(surname2.value)){
        surname1.style.background = 'red'
        surname2.style.background = 'red'
        surname1.focus()
    }else if (!CheckTel(tel.value)){
        tel.focus()
        tel.style.background = 'red'
    }else if (!CheckEmail(email.value)){
        email.style.background = 'red'
        email.focus()
    }else if (!CheckPasswd(passed.value)){
        passed.style.background = 'red'
        passed.focus() 
    }else if (!radio[0].checked && !radio[1].checked){
        alert("Tiene que decir que sexo es")
    }else{
        alert("Enviado")
    }
}

const nams = document.getElementById('nombre')
const surname1 = document.getElementById('apellido1')
const surname2 = document.getElementById('apellido2')
const tel = document.getElementById('telefono')
nams.addEventListener('keypress', (e) => {
    if(!isLetter(e.key) && e.key != " "){
        e.preventDefault();
    }
} )

surname1.addEventListener('keypress', (e) => {
    if(!isLetter(e.key)){
        e.preventDefault();
    }
})

surname2.addEventListener('keypress', (e) => {
    if(!isLetter(e.key)){
        e.preventDefault();
    }
})

tel.addEventListener('keypress', (e) => {
    inp = e.target.value.length
    if (inp > 11 || isNaN(e.key) || e.key == " "){
        e.preventDefault()
    }else{
        if (inp === 3 || inp === 6 || inp === 9) {
            e.preventDefault()
            tel.value += ' ' + e.key;
        }
    }
})

function CheckSurnames(surname){
    let regp = /^[A-Z][a-zA-Z]+$/
    return regp.test(surname)
}

function CheckTel(tel){
    let regp = /(\+34|0034|34)?[ -]*(6|7)[ -]*([0-9][ -]*){8}/
    return regp.test(tel)
}

function CheckEmail(email){
    
    let regp = /^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/
    return regp.test(email.trim())
}


// La contraseña debe tener al entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula, al menos una mayúscula y al menos un carácter no alfanumérico.
function CheckPasswd(passwd){
    let regp = /^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$/
    return regp.test(passwd)
}

function isLetter(str) {
    return str.length === 1 && str.match(/[a-zñáéíóúÁÉÍÓÚÜü]/i)
}
