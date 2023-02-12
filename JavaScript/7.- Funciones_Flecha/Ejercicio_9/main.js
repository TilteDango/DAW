const p = document.getElementById('p')

const calculateEvens = () => {
    const even = []
    let i = 0
    while(even.length < 20){
        if (i % 2 == 0) {
            even.push(i)
        }
        i++
    }
    
    p.textContent = `[${even}]`
}

calculateEvens()




