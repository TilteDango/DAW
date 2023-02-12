const n1 = document.getElementById('valor1').value
const n2 = document.getElementById('valor2').value
const addition = document.getElementById('suma')
const subtraction = document.getElementById('resta')
const operate = document.getElementById('calculo')
const result = document.getElementById('resultado')


operate.addEventListener('click', () => {
    const n1 = parseInt(document.getElementById('valor1').value)
    const n2 = parseInt(document.getElementById('valor2').value)
    let str = ""
     if(addition.checked) {
        str = `La suma es ${n1 + n2}` 
    }

    if (subtraction.checked && !addition.checked) {
        str = `La diferencia es ${n1 - n2}`
    }else{
        if (subtraction.checked && addition.checked) {
            str += ` - La diferencia es ${n1 - n2}`
        }
    }

    result.textContent = str;
    
})

