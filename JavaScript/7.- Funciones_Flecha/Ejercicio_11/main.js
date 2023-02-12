const p = document.getElementById('p')

const Fibonnaci = () => {
    let fibonnaciNumbers = [0, 1]
    for (let i = 2; i < 10; i++) {
        let newNumber = fibonnaciNumbers[i-2] + fibonnaciNumbers[i-1]
        fibonnaciNumbers.push(newNumber)
    }
    p.textContent = `La sucesión de los 10 primeros números es: [${fibonnaciNumbers}]`
}

Fibonnaci()



