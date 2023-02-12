const res = document.getElementById('res')
const calculateArgs = (args) => args.length
    
res.addEventListener('click', () => {
    const params = document.getElementById('para').value
    const p = document.getElementById('p')
    let len = calculateArgs(params.split(','))
    
    p.textContent = len  
})


