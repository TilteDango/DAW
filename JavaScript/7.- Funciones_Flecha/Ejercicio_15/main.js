const text = document.getElementById('text')
const reverse = document.getElementById('reverse')
const p = document.getElementById('res')

const reverseText = text => text.split("").reverse().join("") 

reverse.addEventListener('click', () =>{
    if (text.value.length != 0) {
        let reversedText =reverseText(text.value)
        p.textContent = `"${text.value}" dado la vuelta se convierte en: "${reversedText}"`
        text.value = ""
        text.focus()
    }else{
        p.textContent = "Por favor, introduzca una cadena antes de presionar el botón."
    }

   
})









