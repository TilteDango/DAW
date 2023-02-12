const form = document.getElementById('form')
const select = document.getElementById('SelectAll')
const diselect = document.getElementById('DisSelectAll')
for (let i = 0; i < 100; i++) {
    let r = Math.floor(Math.random() * 1200)
    const input = document.createElement('input')
    const label = document.createElement('label')
    label.textContent = r
    input.type = 'checkbox'
    input.value = r
    form.appendChild(label)
    form.appendChild(input)
}

select.addEventListener('click', () => {
    checkbxs = Array.from(document.querySelectorAll("input[type ='checkbox']"))

    checkbxs.forEach(element => element.checked = true)
})

diselect.addEventListener('click', () => {
    checkbxs = Array.from(document.querySelectorAll("input[type ='checkbox']"))

    checkbxs.forEach(element => element.checked = false)
})

