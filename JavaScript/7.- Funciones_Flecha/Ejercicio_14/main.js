const price = document.getElementById('price')
const iva = document.getElementById('iva')
const button = document.getElementById('calculate')
const p = document.getElementById('res')

const calculateIVA = (price, iva) =>{
    return price += parseInt(price) * (parseFloat(iva) / 100)
}

button.addEventListener('click', () =>{
   let floatPrice = parseFloat(price.value.replace(',', '.'))
   let floatIva = parseFloat(iva.value)
 
    

   if (Number.isNaN(floatIva) && iva.value.length == 0) {
        floatIva = 21
   }
   if (ValidateNumbers(floatPrice) && ValidateNumbers(floatIva)) {
    let total = calculateIVA(floatPrice, floatIva)
    p.textContent = `${floatPrice.toString().replace('.', ',')}€ con un IVA del ${floatIva}% es ${Number(total.toFixed(2)).toString().replace('.', ',')}` 
   }else{
    p.textContent = `Disculpe, los datos introducidos son erróneos`
   }
    
}
)

function ValidateNumbers(number){
    let regEx = /\d+(,\d+)?/
    return regEx.test(number)
}










