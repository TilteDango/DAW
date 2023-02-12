const input = document.getElementById('dni')
const valid = document.getElementById('valid')

const DniLetter = (number) => {
    const letters = "TRWAGMYFPDXBNJZSQVHLCKE"
    let letter = number % 23
    return letters[letter]
}

dni.addEventListener('keypress', e =>{
    if (!/[0-9]+$/.test(e.key) && e.key != "Backspace") {
        e.preventDefault()
        valid.textContent = "DNI erróneo(Solo permite números)"
    }else{
        valid.textContent = ""
        if (e.target.value.length == 7) {
            let letter = DniLetter(e.target.value + e.key)
            console.log(letter)
            e.target.value += e.key + " - " + letter
            e.preventDefault()
        }
    }
})


