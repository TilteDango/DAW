const email = document.getElementById('email')
const url = document.getElementById('url')
const res1 = document.getElementById('resultado1')
const res2 = document.getElementById('resultado2')
const confirms = document.getElementById('confirmar')

confirms.addEventListener('click', (e) => {
    e.preventDefault()
    if (CheckMail(email.value)) {
        res1.textContent = "Correcto"
    }else{
        res1.textContent = "Incorrecto"
    }

    if (CheckUrl(url.value)) {
        res2.textContent = "Correcto"
    }else{
        res2.textContent = "Incorrecto"
    }
})


function CheckMail(mail){
let regex = /^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*$/
return regex.test(mail)
}

function CheckUrl(url){
let regex = /(\S+\.(com|net|org|edu|gov)(\/\S+)?)/
return regex.test(url)
}