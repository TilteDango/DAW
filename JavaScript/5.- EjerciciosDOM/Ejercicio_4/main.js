const list = document.querySelector('ul')

function anade() {

lorem = ['perro', 'gato', 'burro', 'zorro']

let r = Math.floor(Math.random() * lorem.length)
list.innerHTML += `<li>${lorem[r]}</li>`
}