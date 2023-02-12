function Genera(){
    const button = document.getElementById('genera')
    button.disabled = true
    const paraghraps = document.querySelectorAll('p')
    const div1 = document.getElementById('primero')
    const div2 = document.getElementById('segundo')
    const p = document.createElement('p')
    const p2 = document.createElement('p')
    paraghraps.forEach(element => {
        element.remove()
    });
    let r = Math.floor(Math.random() * 10)
    p.textContent = r
    div1.appendChild(p)
    

  

    let r2 = Math.floor(Math.random() * 10)
    if (r2 != r) {
        p2.textContent = r2
    }else{
        while(r2 == r){
            r2 = Math.floor(Math.random() * 10)
        }
        p2.textContent = r2
    }  
    div2.appendChild(p2)
}

function Compara(){
    const paraghraps = document.querySelectorAll('p')
    const button = document.getElementById('genera')
    button.disabled = false
    const divres = document.getElementById('resultado')
    const p = document.createElement('p')
    let n1 = parseInt(paraghraps[0].textContent)
    let n2 = parseInt(paraghraps[1].textContent)

    if(n1 > n2){
        paraghraps[0].textContent = ""
        p.textContent = n1
    }else{
        paraghraps[1].textContent = ""
        p.textContent = n2
    }

    divres.appendChild(p)
}