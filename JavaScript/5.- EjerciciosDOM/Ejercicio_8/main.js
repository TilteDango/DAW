const n1 = document.getElementById('valor1').value
const n2 = document.getElementById('valor2').value
const operation = document.getElementById('operacion').value
const operate = document.getElementById('calculo')
const operate_multiple = document.getElementById('calculomultiple')
const result = document.getElementById('resultado1')
const result2 = document.getElementById('resultado2')


operate.addEventListener('click', () => {
    const n1 = parseInt(document.getElementById('valor1').value)
    const n2 = parseInt(document.getElementById('valor2').value)
    const operation = document.getElementById('operacion').value
    console.log(operation)
    let str = ""
     if(operation == 'suma') {
        str = `La suma es ${n1 + n2}` 
    }else{
        str = `La diferencia es ${n1 - n2}`
    }
    result.textContent = str;   
})


operate_multiple.addEventListener('click', () => {
    const n1 = parseInt(document.getElementById('valor1').value)
    const n2 = parseInt(document.getElementById('valor2').value)
    const operation = document.getElementById('operaciones')
    let str = ""
    const values = Array.from(operation.selectedOptions).map(option => option.value)

     if(values.length == 1) {
        if (values[0] == 'suma') {
            str = `La suma es ${n1 + n2}`
        }else{
            str = `La diferencia es ${n1 - n2}`
        }    
    }else{
        str = `La suma es: ${n1 + n2} - La diferencia es: ${n1 -n2}`
    }

    result2.textContent = str;
    
})
