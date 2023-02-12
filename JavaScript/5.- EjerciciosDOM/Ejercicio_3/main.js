const additional = document.querySelector('.adicional')
const button = document.querySelector('.enlace')

onload = () => {
    additional.style.visibility = 'hidden'
}

function Muestra(){
    additional.style.visibility = 'visible'
    button.style.visibility = ' hidden'
}