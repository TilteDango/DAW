const res = document.getElementById('res')
let dec_to_bin = n => n.toString(2)

const submit = document.getElementById('res')
submit.addEventListener('click', () => {
    const p = document.getElementById('p')
    const n = parseInt(document.getElementById('number').value)
    
    p.textContent = dec_to_bin(n)
})



   