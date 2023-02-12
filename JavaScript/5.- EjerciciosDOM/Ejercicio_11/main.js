const newElemet = document.getElementById('button')
const list = document.getElementById('list')


newElemet.addEventListener('click', () => {
    let r = Math.floor(Math.random() * 1000)
    
    const li = document.createElement('li')
    li.textContent = r
    list.appendChild(li)


})