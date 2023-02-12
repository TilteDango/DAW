const reappear = document.getElementById('reaparecer')

const paraghraps = [...document.querySelectorAll('p')]

console.log(reappear, paraghraps)


paraghraps[0].addEventListener('click', () => paraghraps[0].style.visibility = 'hidden')
paraghraps[1].addEventListener('click', () => paraghraps[1].style.visibility = 'hidden')
paraghraps[2].addEventListener('click', () => paraghraps[2].style.visibility = 'hidden')
paraghraps[0].addEventListener('dblclick', () => paraghraps[0].remove())
paraghraps[1].addEventListener('dblclick', () => paraghraps[1].remove())
paraghraps[2].addEventListener('dblclick', () => paraghraps[2].remove())


reappear.addEventListener('click', () => {
       paraghraps.forEach(element => {
        element.style.visibility = 'visible'
    })
})