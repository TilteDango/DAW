const table = document.getElementById('table')

for (let i = 0; i < 100; i++) {
    const tr = document.createElement('tr')
    for (let k = 0; k < 100; k++) {

        const td = document.createElement('td')
        if (CasiPrimo((i * 100) + k)) {
            td.classList.add('primo')
        }
        td.textContent = (i * 100) + k;
        tr.appendChild(td)
    }

    table.appendChild(tr)
}


function CasiPrimo(n){
    let k = 0
    for (let i = 2; i < n; i++) {
        if (n % i == 0) {
            k++;
        }
    }

    let res = false;
    if (k == 1) {
        res = true
    }

    return res;

}