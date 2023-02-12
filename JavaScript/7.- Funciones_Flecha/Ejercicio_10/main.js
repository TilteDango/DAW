const p = document.getElementById('p')

const calculateTime = () => {
    let time = 73000 / 120
    p.textContent = `El tiempo que tarda es: ${Number(time.toFixed(2))} horas`
}


calculateTime()


