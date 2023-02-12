
const res = document.getElementById('res')

let random = param => Math.floor(Math.random() * param + 1)

res.addEventListener('click', () => {
    const number = document.getElementById('number').value
    const pharag = document.getElementById('pharag')

    pharag.innerText = random(number)

})
   