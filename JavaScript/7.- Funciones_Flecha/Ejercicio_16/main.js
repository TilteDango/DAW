const min = document.getElementById('min')
const max = document.getElementById('max')
const p = document.getElementById('res')
const button = document.getElementById('button')


const randomMinMax = (min, max) => Math.floor(Math.random() * (max - min)) + min


button.addEventListener('click', () => {
    let intMin = 1
    let intMax = 100
    
    if (min.value.length != 0) {
        intMin = parseInt(min.value)
    }

    if (max.value.length != 0) {
        intMax = parseInt(max.value)
    }
     
    let random = randomMinMax(intMin, intMax)

    p.textContent = `El número aleatorio es: ${random}` 
})













