const res = document.getElementById('res')

let convert_centigrade_to_fahrenheit = centigrade => centigrade * 1.8 + 32

res.addEventListener('click', () => {
    const n = document.getElementById('number').value
    const p = document.getElementById('pharag')

    p.textContent = convert_centigrade_to_fahrenheit(n) + ' ºF'
}) 