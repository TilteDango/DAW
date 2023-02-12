const res = document.getElementById('res')
const calculateAverage = (args) => ((args.reduce((a,b) => a + b)) / args.length)
    
res.addEventListener('click', () => {
    const params = document.getElementById('para').value
    const p = document.getElementById('p')
    let array = params.split(',')
    Intarray = array.map( n => parseInt(n))
    p.textContent =   calculateAverage(Intarray)
})


