const res = document.getElementById('res')
let show_table = n => {
    let fragment = document.createDocumentFragment()
    for (let i = 1; i <= 10; i++) {
        let tr = document.createElement('tr')
        let td1 = document.createElement('td')
        let res = document.createElement('td')

        td1.textContent = `${n} * ${i} = `
        res.textContent = n * i
        
        tr.appendChild(td1)
        tr.appendChild(res)
        fragment.appendChild(tr)
    }
    return fragment
}

const table = document.getElementById('table')
const submit = document.getElementById('res')
submit.addEventListener('click', () => {
    const n = document.getElementById('number').value
    fragment = show_table(n)
    table.appendChild(fragment)
})



   